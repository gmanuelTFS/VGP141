using UnityEngine;
using VGP141_22S.DesignPatterns;

namespace VGP141_22S
{
    public class BuildQueue : IObserver
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
            currentRequest.ModifyRemainingTime(pDeltaTime);
        }
        
        public void AddBuildRequest(BuildRequest pBuildRequest)
        {
            pBuildRequest.AddObserver(this);
            _buildRequestQueue.Enqueue(pBuildRequest);
        }

        private void BuildRequestComplete(BuildRequest pBuildRequest)
        {
            // Remove ourselves as an observer
            pBuildRequest.RemoveObserver(this);
            
            // Dequeue the request
            _buildRequestQueue.Dequeue();
            
            Debug.Log($"BuildRequest for {pBuildRequest.BuildableData.name} was completed.");
        }

        public void Notify(string pMessage)
        {
            
        }

        public void Notify<T>(string pMessage, T pData)
        {
            switch (pMessage)
            {
                case Notifications.BUILD_REQUEST_COMPLETED when pData is BuildRequest buildRequest:
                    BuildRequestComplete(buildRequest);
                    break;
            }
        }
    }   
}
