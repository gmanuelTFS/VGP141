using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VGP141_22S
{
    public class BuildMenu : MonoBehaviour
    {
        private BuildQueue _infantryBuildQueue;
        private BuildQueue _vehicleBuildQueue;
        private BuildQueue _buildingBuildQueue;
        private BuildQueue _defensiveBuildingBuildQueue;
        // [SerializeField] private List<BuildMenuButton> _menuButtons;

        private void Awake()
        {
            _infantryBuildQueue = new BuildQueue();
            _vehicleBuildQueue = new BuildQueue();
            _buildingBuildQueue = new BuildQueue();
            _defensiveBuildingBuildQueue = new BuildQueue();
        }

        private void Start()
        {

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