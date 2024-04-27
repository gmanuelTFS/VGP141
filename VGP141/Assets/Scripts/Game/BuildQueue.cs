using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class BuildQueue : MonoBehaviour
    {
        private readonly DataStructures.Queue<BuildRequest> _queue = new();

        void Awake()
        {
            for (int i = 0; i < 10; i++)
            {
                _queue.Enqueue(
                    new BuildRequest(
                        i % 2 == 0 ? UnitType.Conscript : UnitType.RhinoTank, i)
                    );
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            while (!_queue.Empty)
            {
                Debug.Log(_queue.Front);
                _queue.Dequeue();
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}