using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildRequest
{
    public readonly UnitData UnitData;
    public float RemainingBuildTime;

    public BuildRequest(UnitData unitData)
    {
        UnitData = unitData;
        RemainingBuildTime = UnitData.BaseBuildTime;
    }

    public override string ToString()
    {
        return $"{nameof(UnitData)}: {{{UnitData}}}, {nameof(RemainingBuildTime)}: {RemainingBuildTime}";
    }
}
