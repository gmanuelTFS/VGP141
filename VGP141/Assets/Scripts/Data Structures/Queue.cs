using System.Collections.Generic;

namespace VGP141_22S.DataStructures
{
    public class Queue<T>
    {
        private LinkedList<T> _data;
    
        public T Front => _data.First.Value;
        public bool Empty => _data.Count == 0;
        public int Size => _data.Count;
    
        public void Enqueue(T pValue)
        {
            _data.AddLast(pValue);
        }

        public void Dequeue()
        {
            _data.RemoveFirst();
        }

        public void Clear()
        {
            _data.Clear();
        }
    }
}