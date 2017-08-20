using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class MaxHeap<T> where T : IComparable<T> {

	private List<T> elements = new List<T>();

	private int leftSonIndex(int index) { return index * 2 + 1; }
	private int rightSonIndex(int index) { return index * 2 + 2; }
	private int fatherIndex(int index) { return index / 2; }

	private void bubbleUp(int index)
	{
		T value = elements[index];

		while (value.CompareTo(elements[fatherIndex(index)]) > 0)
		{
			T aux = elements [fatherIndex (index)];
			elements [fatherIndex (index)] = value;
			elements [index] = aux;

			index = fatherIndex (index);

			if (index == 0)
				return;
		}
	}

	private void bubbleDown()
	{
		if(elements.Count == 0) return;

		T value = elements[0];
		int index = 0;

		while (true)
		{
			if(leftSonIndex(index) < elements.Count && value.CompareTo(elements[leftSonIndex(index)]) <= 0)
			{
				if(rightSonIndex(index) < elements.Count && elements[rightSonIndex(index)].CompareTo(elements[leftSonIndex(index)]) > 0)
				{
					T aux = elements[rightSonIndex(index)];
					elements[rightSonIndex(index)] = value;
					elements[index] = aux;

					index = rightSonIndex(index);
				}
				else
				{
					T aux = elements[leftSonIndex(index)];
					elements[leftSonIndex(index)] = value;
					elements[index] = aux;

					index = leftSonIndex(index);
				}
			}
			else if(rightSonIndex(index) < elements.Count && value.CompareTo(elements[leftSonIndex(index)]) < 0)
			{
				T aux = elements[rightSonIndex(index)];
				elements[rightSonIndex(index)] = value;
				elements[index] = aux;

				index = rightSonIndex(index);
			}
			else break;
		}
	}

	public T pop()
	{
		Debug.Log("elementos: " + elements.Count);

		if(elements.Count == 0) return default(T);

		T element = elements[0];
		elements[0] = elements[elements.Count-1];
		elements.RemoveAt(elements.Count-1);
		bubbleDown();
		return element;
	}

	public void insert(T element)
	{
		elements.Insert(elements.Count, element);
		bubbleUp(elements.Count-1);
	}

	public int size()
	{
		return elements.Count;
	}

	public void print()
	{
		foreach(T t in elements)
		{
			Debug.Log(t.ToString());
		}
	}

}
