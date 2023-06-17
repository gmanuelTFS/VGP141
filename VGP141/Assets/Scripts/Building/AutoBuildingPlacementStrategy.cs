using UnityEngine;

namespace VGP141_22S
{
    public class AutoBuildingPlacementStrategy : IBuildingPlacementStrategy
    {
        public BuildableView BuildableView { get; private set; }

        public void StartPlacement(BuildableData pBuildableData)
        {
            BuildableView = pBuildableData.InWorldPrefab;

            Vector3 spawnPosition = Vector3.zero;
            
            // Here we would position the buildable. Each buildable would have a set position
        }

        public BuildableView EndPlacement(BuildableData pBuildableData) => throw new System.NotImplementedException();
    }
}


