using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VGP141_22S.DesignPatterns;

namespace VGP141_22S
{
    public class BuildingPlacer : Subject
    {
        private IBuildingPlacementStrategy _buildingPlacementStrategy;

        public BuildingPlacer(IBuildingPlacementStrategy pBuildingPlacementStrategy)
        {
            _buildingPlacementStrategy = pBuildingPlacementStrategy;
            _buildingPlacementStrategy.BuildableViewPlaced += OnBuildingPlaced;
        }

        public void StartPlacement(BuildableData pBuildableData)
        {
            _buildingPlacementStrategy.StartPlacement(pBuildableData);
        }

        private void OnBuildingPlaced(BuildableData pBuildableData, BuildableView pBuildableView)
        {
            NotifyObservers(Notifications.BUILDABLE_BUILT, pBuildableData);
            NotifyObservers(Notifications.BUILD_PROCESS_FINISH, pBuildableView);
        }
    }   
}
