using System.Collections.Generic;

public class DynamicQueue<T>
{
	private readonly LinkedList<T> data = new LinkedList<T>();

	public bool Empty => data.Count == 0;

	public void Enqueue(T value)
	{
		data.AddLast(value);
	}

	public void Dequeue()
	{
		data.RemoveFirst();
	}

	public T Peek()
	{
		return data.First.Value;
	}

	public int Size()
	{
		return data.Count;
	}

	public void Clear()
	{
		data.Clear();
	}
}
