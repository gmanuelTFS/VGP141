using System;

namespace VGP141_22S
{
    public interface IBuildingPlacementStrategy
    {
        public Action<BuildableData, BuildableView> BuildableViewPlaced { get; set; }      
        BuildableView BuildableView { get; }
        
        void StartPlacement(BuildableData pBuildableData);
    }
}