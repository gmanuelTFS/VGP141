using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class BuildRequest
    {
        public readonly Data.BuildableData BuildableData;
        public float RemainingBuildTime;

        public BuildRequest(Data.BuildableData buildableData)
        {
            BuildableData = buildableData;
            RemainingBuildTime = buildableData.BuildTime;
        }

        public override string ToString()
        {
            return $"{nameof(BuildRequest)}: " +
                $"{nameof(BuildableData)}: {BuildableData}, " +
                $"{nameof(RemainingBuildTime)}: {RemainingBuildTime}";
        }
    }
}