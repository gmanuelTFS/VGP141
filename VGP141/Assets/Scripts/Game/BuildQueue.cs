using UnityEngine;

namespace Game
{
    public class BuildQueue : MonoBehaviour
    {
        private readonly DataStructures.Queue<BuildRequest> _queue = new();

        public void Enqueue(BuildRequest pBuildRequest)
        {
            _queue.Enqueue(pBuildRequest);
        }

        // Update is called once per frame
        private void Update()
        {
            if (!_queue.Empty)
            {
                BuildRequest request = _queue.Front;

                request.ReduceRemainingTime(Time.deltaTime);

                if (request.RemainingBuildTime == 0)
                {
                    Debug.Log($"Completed building {request.BuildableData}");
                    _queue.Dequeue();
                }
            }
        }
    }
}