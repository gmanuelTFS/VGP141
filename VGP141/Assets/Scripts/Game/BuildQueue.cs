using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class BuildQueue : MonoBehaviour
    {
        public Data.BuildableData BuildableData;

        private readonly DataStructures.Queue<BuildRequest> _queue = new();
        private readonly List<Data.BuildableData> _buildables = new();

        void Awake()
        {
            _buildables.AddRange(Resources.LoadAll<Data.BuildableData>("BuildableData"));
        }

        // Start is called before the first frame update
        private void Start()
        {
            for (int i = 0; i < 10; i++)
            {
                _queue.Enqueue(
                    new BuildRequest(_buildables[i % _buildables.Count])
                    );
            }
        }

        // Update is called once per frame
        private void Update()
        {
            if (!_queue.Empty)
            {
                BuildRequest request = _queue.Front;

                request.RemainingBuildTime -= Time.deltaTime;

                if (request.RemainingBuildTime < 0)
                {
                    request.RemainingBuildTime = 0;
                }

                if (request.RemainingBuildTime == 0)
                {
                    Debug.Log($"Completed building {request.BuildableData}");
                    _queue.Dequeue();
                }
            }
        }
    }
}