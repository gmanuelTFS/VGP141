namespace VGP141_22S
{
    public interface IBuildingPlacementStrategy
    {
        BuildableView BuildableView { get; }
        
        void StartPlacement(BuildableData pBuildableData);
        BuildableView EndPlacement(BuildableData pBuildableData);
    }
}