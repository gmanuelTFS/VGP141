using System;

namespace VGP141_22S
{
    public enum BuildableType
    {
        Gi,
        AttackDog,
        //Engineer,
        //Spy,
        //Sniper,
        GrizzlyTank,
        Ifv,
        //Miner,
    }

    public enum BuildableCategory
    {
        Infantry,
        Vehicle,
        Building,
        DefensiveBuilding,
    }

    public static class BuildableTypeExtensions
    {
        public static BuildableCategory TypeToCategory(this BuildableType pBuildableType)
        {
            switch (pBuildableType)
            {
                case BuildableType.Gi:
                case BuildableType.AttackDog:
                // case BuildableType.Engineer:
                // case BuildableType.Spy:
                // case BuildableType.Sniper:
                    return BuildableCategory.Infantry;
                case BuildableType.GrizzlyTank:
                case BuildableType.Ifv:
                // case BuildableType.Miner:
                    return BuildableCategory.Vehicle;
                default:
                    throw new ArgumentOutOfRangeException(nameof(pBuildableType), pBuildableType, null);
            }
        }
    }   
}