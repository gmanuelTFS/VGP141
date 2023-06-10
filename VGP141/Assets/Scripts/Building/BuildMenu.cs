using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VGP141_22S
{
    public class BuildMenu : MonoBehaviour
    {
        [SerializeField] private BuildMenuButton _buildMenuButtonPrefab;

        private Dictionary<BuildableCategory, BuildQueue> _buildQueueMap;
        private List<BuildMenuButton> _menuButtons;

        private void Awake()
        {
            _buildQueueMap = new Dictionary<BuildableCategory, BuildQueue>();
            _menuButtons = new List<BuildMenuButton>();
        }

        private void Start()
        {
            BuildableCategory[] buildableCategories = Resources.LoadAll<BuildableCategory>(nameof(BuildableCategory));
            foreach (BuildableCategory buildableCategory in buildableCategories)
            {
                _buildQueueMap.Add(buildableCategory, new BuildQueue());
                BuildableData[] buildableData = Resources.LoadAll<BuildableData>($"{nameof(BuildableData)}/{buildableCategory.name}");
                foreach (BuildableData data in buildableData)
                {
                    BuildMenuButton button = Instantiate(_buildMenuButtonPrefab, transform);
                    button.Initialize(this, data);
                    _menuButtons.Add(button);
                }
            }
        }


        private void Update()
        {
            foreach (BuildQueue buildQueue in _buildQueueMap.Values)
            {
                buildQueue.Update(Time.deltaTime);
            }
        }

        public void CreateBuildRequest(BuildableData pBuildableData, BuildMenuButton pBuildMenuButton)
        {
            BuildRequest buildRequest = new BuildRequest(pBuildableData);
            buildRequest.AddObserver(pBuildMenuButton);
            if (!_buildQueueMap.TryGetValue(pBuildableData.BuildableCategory, out BuildQueue buildQueue))
            {
                Debug.LogError($"{nameof(BuildableCategory)} named {pBuildableData.BuildableCategory} is not handled by {nameof(CreateBuildRequest)}");
                return;
            }
            
            buildQueue.AddBuildRequest(buildRequest);
        }
    }   
}