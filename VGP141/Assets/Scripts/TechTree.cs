using System.Collections.Generic;
using UnityEngine;
using VGP141_22S.DesignPatterns;

namespace VGP141_22S
{
    public class TechTree : IObserver
    {
        /// <summary>
        /// Tracks how many of each BuildableData is currently in existence
        /// </summary>
        private readonly Dictionary<BuildableData, uint> _buildCounts;

        public TechTree(IEnumerable<BuildableData> pBuildableData)
        {
            _buildCounts = new Dictionary<BuildableData, uint>();
            foreach (BuildableData buildableData in pBuildableData)
            {
                if (buildableData == null)
                {
                    continue;
                }
                _buildCounts.Add(buildableData, 0);
            }
        }

        public bool TryBuild(BuildableData pBuildableData)
        {
            if (pBuildableData == null) 
            {
                Debug.LogError("Cannot build a null structure.");
                return false;
            }

            if (!_buildCounts.ContainsKey(pBuildableData))
            {
                Debug.LogError($"Cannot build {pBuildableData.PlayerFacingName}. Unknown {nameof(BuildableData)}");
                return false;
            }
	
            if (!CheckDependencies(pBuildableData))
            {
                Debug.LogError($"Cannot build {pBuildableData.PlayerFacingName}. Missing dependencies:");
                PrintMissingDependencies(pBuildableData);
                return false;
            }
            
            // add structure
            ++_buildCounts[pBuildableData];

            Debug.Log($"Built {pBuildableData.PlayerFacingName}");

            return true; // success
        }
        
        public bool TryDestroy(BuildableData pBuildableData)
        {
            // check if already built
            if (!_buildCounts.TryGetValue(pBuildableData, out uint buildCount) || buildCount == 0)
            {
                return false;
            }

            --_buildCounts[pBuildableData];
            Debug.Log($"Destroyed {pBuildableData.PlayerFacingName}. Remaining: {_buildCounts[pBuildableData]}");
            return true; // success
        }
        
        
        public bool CheckDependencies(BuildableData pBuildableData)
        {
            foreach (BuildableData dependency in pBuildableData.BuildDependencies)
            {
                // look up the parent in built structures
                _buildCounts.TryGetValue(dependency, out uint buildCount);
                if (buildCount == 0)
                {
                    // parent not found; dependency check failed
                    return false;
                }
            }
            // if we get here, all is good
            return true;
        }

        private void PrintMissingDependencies(BuildableData pBuildableData)
        {
            foreach (BuildableData dependency in pBuildableData.BuildDependencies)
            {
                // look up the parent in built structures
                _buildCounts.TryGetValue(dependency, out uint buildCount);
                if (buildCount != 0)
                {
                    continue;
                }

                // parent not found; dependency check failed
                Debug.LogError(dependency.PlayerFacingName);
                PrintMissingDependencies(dependency);
            }
        }

        public void Notify(string pMessage)
        {
            throw new System.NotImplementedException();
        }

        public void Notify<T>(string pMessage, T pData)
        {
            switch (pMessage)
            {
                case Notifications.BUILDABLE_BUILT when pData is BuildableData buildableData:
                    TryBuild(buildableData);
                    break;
            }
        }
    }
}

