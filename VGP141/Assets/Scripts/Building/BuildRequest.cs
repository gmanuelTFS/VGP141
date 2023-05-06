namespace VGP141_22S
{
    public class BuildRequest
    {
        public readonly BuildableData BuildableData;
        public float RemainingBuildTime;

        public BuildRequest(BuildableData pBuildableData)
        {
            BuildableData = pBuildableData;
            RemainingBuildTime = BuildableData.BuildTime;
        }
    }   
}
