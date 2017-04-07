using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GlobalInfos {

	static GlobalInfos instance;
	Item[] allItems;
	Container[] allContainers;

	public static GlobalInfos getInstance()
	{
		if(instance == null)
			instance = new GlobalInfos();
		return instance;
	}

	public void setAllItems(Item[] allItems)
	{
		this.allItems = allItems;
	}

	public void setAllContainers(Container[] allContainers)
	{
		this.allContainers = allContainers;
	}
}
