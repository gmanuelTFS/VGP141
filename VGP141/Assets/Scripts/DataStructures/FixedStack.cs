using System.Collections;
using System.Collections.Generic;

/// <summary>
/// It's a stack. Implementation is using a fixed array
/// </summary>
/// <typeparam name="T"></typeparam>
public class FixedStack<T>
{
	private T[] data;
	private int tp;

	public FixedStack(uint capacity)
	{
		data = new T[capacity];
		tp = -1;
	}

	public void Push(T value)
	{
		data[++tp] = value;
	}

	public void Pop()
	{
		--tp;
	}

	public T Top()
	{
		return data[tp];
	}

	public bool Empty()
	{
		return tp < 0;
	}

	public int Size()
	{
		return tp + 1;
	}

	public void Clear()
	{
		tp = -1;
	}
}
