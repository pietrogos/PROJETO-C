using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Container {

	int maxCapacity;
	string containerId;
	string containerName;
	Vector3 containerPosition;
	List<Item> inventory;

	public Container(string containerId, string containerName, Vector3 containerPosition, int maxCapacity)
	{
		this.maxCapacity = maxCapacity;
		this.containerId = containerId;
		this.containerName = containerName;
		this.containerPosition = containerPosition;
		inventory = new List<Item>(maxCapacity);
	}

	public bool removeItem(string itemId)
	{
		for(int i = 0; i < maxCapacity; i++)
		{
			if(inventory[i].itemId == itemId)
			{
				inventory.RemoveAt(i);
				return true;
			}
		}
		return false;
	}

	public bool insertItem(Item item)
	{
		if(inventory.Count < maxCapacity)
		{
			inventory.Add(item);
			return true;
		}
		return false;
	}
}
