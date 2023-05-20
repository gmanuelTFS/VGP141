using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VGP141_22S
{
    public class BuildMenu : MonoBehaviour
    {
        [SerializeField] private BuildMenuButton _buildMenuButtonPrefab;
        
        private BuildQueue _infantryBuildQueue;
        private BuildQueue _vehicleBuildQueue;
        private BuildQueue _buildingBuildQueue;
        private BuildQueue _defensiveBuildingBuildQueue;
        private List<BuildMenuButton> _menuButtons;

        private void Awake()
        {
            _infantryBuildQueue = new BuildQueue();
            _vehicleBuildQueue = new BuildQueue();
            _buildingBuildQueue = new BuildQueue();
            _defensiveBuildingBuildQueue = new BuildQueue();
            _menuButtons = new List<BuildMenuButton>(Enum.GetNames(typeof(BuildableType)).Length);
        }

        private void Start()
        {
            for (int i = 0; i < _menuButtons.Capacity; i++)
            {
                BuildMenuButton button = Instantiate(_buildMenuButtonPrefab, transform);
                button.Initialize(this, Resources.Load<BuildableData>($"BuildableData/{(BuildableType)i}"));
            }
        }


        private void Update()
        {
            _infantryBuildQueue.Update(Time.deltaTime);
            _vehicleBuildQueue.Update(Time.deltaTime);
            _buildingBuildQueue.Update(Time.deltaTime);
            _defensiveBuildingBuildQueue.Update(Time.deltaTime);
        }

        public void CreateBuildRequest(BuildableData pBuildableData)
        {
            switch (pBuildableData.BuildableCategory)
            {
                case BuildableCategory.Infantry:
                    _infantryBuildQueue.AddBuildRequest(new BuildRequest(pBuildableData));
                    break;
                case BuildableCategory.Vehicle:
                    _vehicleBuildQueue.AddBuildRequest(new BuildRequest(pBuildableData));
                    break;
                case BuildableCategory.Building:
                    _buildingBuildQueue.AddBuildRequest(new BuildRequest(pBuildableData));
                    break;
                case BuildableCategory.DefensiveBuilding:
                    _defensiveBuildingBuildQueue.AddBuildRequest(new BuildRequest(pBuildableData));
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }   
}