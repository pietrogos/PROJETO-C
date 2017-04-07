using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ActionChain {

	Action[] actionList;
	bool[] done;
	int currentTaskPointer;

	public ActionChain(Action[] actionList)
	{
		this.actionList = actionList;
		done = new bool[actionList.Length];
		currentTaskPointer = 0;
	}

	public void clearProgress()
	{
		for(int i = 0; i < actionList.Length; i++)
		{
			done[i] = false;
		}
	}

	public void advanceProgress()
	{
		if(currentTaskPointer < done.Length)
		{
			done[currentTaskPointer] = true;
			currentTaskPointer++;
		}
	}

	public bool isActionComplete()
	{
		return currentTaskPointer == done.Length;
	}

	public int getCurrentTask()
	{
		return currentTaskPointer;
	}
}
