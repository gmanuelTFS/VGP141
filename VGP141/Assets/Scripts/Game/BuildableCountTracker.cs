using System.Collections.Generic;
using Game.Data;
using UnityEngine;

namespace Game
{
    public class BuildableCountTracker : MonoBehaviour
    {
        private HashSet<BuildableData> _buildableCounts = new();

        public void TrackBuiltBuildable(BuildableData pBuildableData)
        {
            _buildableCounts.Add(pBuildableData);
        }
        
        public bool HasBeenBuilt(BuildableData pBuildableData)
        {
            return _buildableCounts.Contains(pBuildableData);
        }

        public bool CanBeBuilt(BuildableData pBuildableData)
        {
            foreach (BuildableData dependency in pBuildableData.Dependencies)
            {
                if (!HasBeenBuilt(dependency))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
