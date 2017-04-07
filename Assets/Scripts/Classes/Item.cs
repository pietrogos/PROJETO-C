using UnityEngine;
using System.Collections;

public class Item{

	public string itemId;
	public string itemName;
	//public Vector3 itemPosition;

	public Item(string itemId, string itemName)
	{
		this.itemId = itemId;
		this.itemName = itemName;
	}
}
