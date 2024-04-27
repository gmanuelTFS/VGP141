using System.Collections.Generic;

namespace DataStructures
{
	public class Queue<T>
	{
		private readonly LinkedList<T> _data = new();

		public T Front => _data.First.Value;

		public bool Empty => _data.Count == 0;

		public int Count => _data.Count;

		public void Enqueue(T value)
		{
			_data.AddLast(value);
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