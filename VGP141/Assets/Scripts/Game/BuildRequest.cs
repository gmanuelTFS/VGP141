using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class BuildRequest
    {
        public readonly UnitType UnitType;
        public float RemainingBuildTime;

        public BuildRequest(UnitType unitType, float remainingBuildTime)
        {
            UnitType = unitType;
            RemainingBuildTime = remainingBuildTime;
        }

        public override string ToString()
        {
            return $"{nameof(BuildRequest)}: " +
                $"{nameof(UnitType)}: {UnitType}, " +
                $"{nameof(RemainingBuildTime)}: {RemainingBuildTime}";
        }
    }
}