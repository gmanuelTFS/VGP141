using System;
using UnityEngine;
using VGP141_22S.DesignPatterns;
using Object = UnityEngine.Object;

namespace VGP141_22S
{
    public class AutoBuildingPlacementStrategy : Subject, IBuildingPlacementStrategy
    {
        public Action<BuildableData, BuildableView> BuildableViewPlaced { get; set; }
        public BuildableView BuildableView { get; private set; }

        public void StartPlacement(BuildableData pBuildableData)
        {
            Vector3 spawnPosition = Vector3.zero;
            
            // Here we would position the buildable. Each buildable would have a set position
            switch (pBuildableData.name)
            {
                case "Barracks":
                    spawnPosition.Set(-6, 0, 6);
                    break;
                case "ConstructionYard":
                    spawnPosition.Set(0, 0, 6);
                    break;
                case "BattleLab":
                    spawnPosition.Set(6, 0, 6);
                    break;
                case "OreRefinery":
                    spawnPosition.Set(-6, 0, -6);
                    break;
                case "PowerPlant":
                    spawnPosition.Set(0, 0, -6);
                    break;
                case "WarFactory":
                    spawnPosition.Set(6, 0, -6);
                    break;
                case "Pillbox":
                    spawnPosition.Set(3, 0, 0);
                    break;
                case "PrismTower":
                    spawnPosition.Set(-3, 0, 0);
                    break;
            }

            BuildableView = Object.Instantiate(pBuildableData.InWorldPrefab, spawnPosition, Quaternion.LookRotation(Vector3.back));
            BuildableView.name = pBuildableData.PlayerFacingName;
            BuildableViewPlaced?.Invoke(pBuildableData, BuildableView);
        }
    }
}


