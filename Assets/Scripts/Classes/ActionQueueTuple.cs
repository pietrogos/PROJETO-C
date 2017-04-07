using UnityEngine;
using System.Collections;
using System;

public class ActionQueueTuple : IComparable<ActionQueueTuple> {

	public ActionChain actionChain;
	public float priority;

	public int CompareTo(ActionQueueTuple other)
	{
		if(priority < other.priority) return -1;
		else if(priority == other.priority) return 0;
		else return 1;
	}

	public override string ToString()
	{
		string str = "priority: "+ priority;
		return str;
	}

	public override int GetHashCode ()
	{
		return (priority).GetHashCode();
	}

	/*public override bool Equals (object obj)
	{
		AStarTuple other = obj as AStarTuple;
		return position == other.position;
	}*/
}
