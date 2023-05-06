using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.UI;

namespace VGP141_22S
{
    public class BuildQueue
    {
        private DataStructures.Queue<BuildRequest> _buildRequestQueue;

        public BuildQueue()
        {
            _buildRequestQueue = new DataStructures.Queue<BuildRequest>();
        }

        public void Update(float pDeltaTime)
        {
            if (_buildRequestQueue.Empty)
            {
                return;
            }
            
            // Grab the first request
            BuildRequest currentRequest = _buildRequestQueue.Front;

            // Update it's remaining time
            currentRequest.RemainingBuildTime -= pDeltaTime;
            if (currentRequest.RemainingBuildTime < 0)
            {
                currentRequest.RemainingBuildTime = 0;
            }

            // If there is remaining time, we're done in this frame
            if (currentRequest.RemainingBuildTime > 0)
            {
                return;
            }
            
            // Dequeue the request
            _buildRequestQueue.Dequeue();
            
            // Spawn the unit/notify something to spawn the unit
            BuildRequestComplete(currentRequest);
        }
        
        public void AddBuildRequest(BuildRequest pBuildRequest)
        {
            _buildRequestQueue.Enqueue(pBuildRequest);
        }

        private void BuildRequestComplete(BuildRequest pBuildRequest)
        {
            Debug.Log($"BuildRequest for {pBuildRequest.BuildableData.BuildableType} was completed.");
        }
    }   
}
