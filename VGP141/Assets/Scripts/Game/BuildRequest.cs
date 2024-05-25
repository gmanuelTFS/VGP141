using System;

namespace Game
{
    public class BuildRequest
    {
        public readonly Data.BuildableData BuildableData;
        
        public float RemainingBuildTime { get; private set; }

        public Action<float> OnRemainingBuildTimeChanged;

        public BuildRequest(Data.BuildableData buildableData)
        {
            BuildableData = buildableData;
            RemainingBuildTime = buildableData.BuildTime;
        }

        public void ReduceRemainingTime(float amount)
        {
            RemainingBuildTime -= amount;

            if (RemainingBuildTime < 0)
            {
                RemainingBuildTime = 0;
            }
            
            OnRemainingBuildTimeChanged?.Invoke(RemainingBuildTime);
        }

        public override string ToString()
        {
            return $"{nameof(BuildRequest)}: " +
                $"{nameof(BuildableData)}: {BuildableData}, " +
                $"{nameof(RemainingBuildTime)}: {RemainingBuildTime}";
        }
    }
}