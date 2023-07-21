using System.Collections.Generic;

namespace VGP23U.DataStructures
{
    public class Queue<T>
    {
        private readonly LinkedList<T> _data;

        public T Front => _data.First.Value;

        public int Size => _data.Count;

        public bool IsEmpty => _data.Count == 0;

        public Queue()
        {
            _data = new LinkedList<T>();
        }

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