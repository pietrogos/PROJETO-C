using UnityEngine;
using System.Collections;
using System.Collections.Generic;




public class Inventory 
{
	private const int INVENTORY_SIZE = 30;

	List<Item> inventory;

	public Inventory()
	{
		inventory = new List<Item>(INVENTORY_SIZE);
	}

	public bool insertInInventory(Item item)
	{
		if(inventory.Count < INVENTORY_SIZE)
		{
			inventory.Add(item);
			return true;
		}
		return false;
	}

	public bool removeFromInventory(string itemId)
	{
		for(int i = 0; i < INVENTORY_SIZE; i++)
		{
			if(inventory[i].itemId == itemId)
			{
				inventory.RemoveAt(i);
				return true;
			}
		}
		return false;
	}


}
