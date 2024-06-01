using Game.Data;
using UnityEngine;

namespace Game
{
    public class BuildQueue : MonoBehaviour
    {
        [SerializeField] private BuildableCountTracker _buildableCountTracker;
        
        private readonly DataStructures.Queue<BuildRequest> _queue = new();

        public void Enqueue(BuildRequest pBuildRequest)
        {
            _queue.Enqueue(pBuildRequest);
        }

        // Update is called once per frame
        private void Update()
        {
            if (_queue.Empty)
            {
                return;
            }

            BuildRequest request = _queue.Front;

            request.ReduceRemainingTime(Time.deltaTime);

            if (request.RemainingBuildTime != 0)
            {
                return;
            }

            BuildBuildable(request.BuildableData);
            _queue.Dequeue();
        }

        private void BuildBuildable(BuildableData pBuildableData)
        {
            _buildableCountTracker.TrackBuiltBuildable(pBuildableData);
            Instantiate(pBuildableData.ViewPrefab);
        }
    }
}