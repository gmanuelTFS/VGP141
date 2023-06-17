using System.Collections.Generic;
using UnityEngine;
using VGP141_22S.DesignPatterns;

namespace VGP141_22S
{
    public class BuildMenu : MonoBehaviour, IObserver
    {
        [SerializeField] private BuildMenuButton _buildMenuButtonPrefab;

        private Dictionary<BuildableCategory, BuildQueue> _buildQueueMap;
        private List<BuildMenuButton> _menuButtons;
        private TechTree _techTree;
        
        public void CreateBuildRequest(BuildableData pBuildableData, BuildMenuButton pBuildMenuButton)
        {
            BuildRequest buildRequest = new(pBuildableData);
            buildRequest.AddObserver(pBuildMenuButton);
            if (!_buildQueueMap.TryGetValue(pBuildableData.BuildableCategory, out BuildQueue buildQueue))
            {
                Debug.LogError($"{nameof(BuildableCategory)} named {pBuildableData.BuildableCategory} is not handled by {nameof(CreateBuildRequest)}");
                return;
            }
            
            buildQueue.AddBuildRequest(buildRequest);
        }

        public void Notify(string pMessage)
        {
            throw new System.NotImplementedException();
        }

        public void Notify<T>(string pMessage, T pData)
        {
            switch (pMessage)
            {
                // TODO: This will likely create the build strategy for buildings
                case Notifications.BUILD_PROCESS_START when pData is BuildableData buildableData && buildableData.BuildableCategory.IsBuilding:
                    break;
                // TODO: Build menu will need to observe something for this
                case Notifications.BUILD_PROCESS_FINISH when pData is BuildableData:
                    Refresh();
                    break;
            }
        }
        
        private void Awake()
        {
            _buildQueueMap = new Dictionary<BuildableCategory, BuildQueue>();
            _menuButtons = new List<BuildMenuButton>();
        }

        private void Start()
        {
            HashSet<BuildableData> allPossibleBuildableData = new();
            BuildableCategory[] buildableCategories = Resources.LoadAll<BuildableCategory>(nameof(BuildableCategory));
            foreach (BuildableCategory buildableCategory in buildableCategories)
            {
                BuildQueue categoryBuildQueue = new();
                categoryBuildQueue.AddObserver(this);
                _buildQueueMap.Add(buildableCategory, categoryBuildQueue);
                BuildableData[] buildableData = Resources.LoadAll<BuildableData>($"{nameof(BuildableData)}/{buildableCategory.name}");
                allPossibleBuildableData.UnionWith(buildableData);
                foreach (BuildableData data in buildableData)
                {
                    BuildMenuButton button = Instantiate(_buildMenuButtonPrefab, transform);
                    button.Initialize(this, data);
                    button.name = $"{data.PlayerFacingName}BuildMenuButton";
                    _menuButtons.Add(button);
                    categoryBuildQueue.AddObserver(button);
                }
            }
            
            _techTree = new TechTree(allPossibleBuildableData);
            Refresh();
        }
        
        private void Update()
        {
            foreach (BuildQueue buildQueue in _buildQueueMap.Values)
            {
                buildQueue.Update(Time.deltaTime);
            }
        }

        private void Refresh()
        {
            foreach (BuildMenuButton buildMenuButton in _menuButtons)
            {
                // Enable/disable based on dependencies
                buildMenuButton.gameObject.SetActive(_techTree.CheckDependencies(buildMenuButton.BuildableData));
            }
        }
    }   
}