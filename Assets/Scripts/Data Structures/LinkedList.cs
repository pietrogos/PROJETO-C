using UnityEngine;
using System.Collections;

public class LinkedList<T> 
{

	private class Node<T>
	{
		public Node<T> next;
		public T data;

		public Node(T data)
		{
			this.data = data;
		}
	}

	private Node<T> root;
	private Node<T> tail;
	private int count;

	public LinkedList()
	{
		
	}

	public void insert(T data)
	{
		Node<T> newNode = new Node<T>(data);
		if(root == null)
		{
			root = newNode;
			//tail = newNode;
			count++;
			return;
		}

		tail.next = newNode;
		tail = newNode;
	
		count++;
	}

	public void insertAt(int pos, T data)
	{
		Node<T> newNode = new Node<T>(data);

		if(pos == count)
		{
			tail = newNode;
		}

		if(pos == 0)
		{
			newNode.next = root;
			root = newNode;
			count++;
			return;
		}

		Node<T> cur = root;
		for(int i = 0; i < pos-1; ++i)
		{
			cur = cur.next;
		}
		newNode.next = cur.next.next;
		cur.next = newNode;

		count++;
	}

	public void removeHead()
	{
		if(count > 0)
		{
			root = root.next;
		}

		if(count == 1)
			tail = null;

		count--;
	}

	public void removeTail()
	{
		//TODO: FAZER
	}








}
