using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace VGP23U
{
    public class QueueTester : MonoBehaviour
    {
        private DataStructures.Queue<int> _testQueue;
        
        void Awake()
        {
            _testQueue = new DataStructures.Queue<int>();
        }

        public void AddToQueue(int x)
        {
            _testQueue.Enqueue(x);

            Debug.Log($"Added {x} to the queue.");
        }

        public void Dequeue()
        {
            int i = _testQueue.Front;
            _testQueue.Dequeue();
            
            Debug.Log($"Removed {i} from the queue.");
        }
    }
}
