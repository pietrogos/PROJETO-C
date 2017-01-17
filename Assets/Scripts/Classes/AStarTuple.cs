using UnityEngine;
using System.Collections;
using System;

public class AStarTuple : IComparable<AStarTuple> {

	public float costDistance;
	public float heurDistance;
	public Vector3 position;
	public AStarTuple lastStep;

	public AStarTuple(float costdist, float heurdist, Vector3 pos, AStarTuple last = null)
	{
		costDistance = costdist;
		heurDistance = heurdist;
		position = pos;
		lastStep = last;
	}

	public int CompareTo(AStarTuple other)
	{
		if(costDistance + heurDistance < other.costDistance + other.heurDistance) return -1;
		else if(costDistance + heurDistance == other.costDistance + other.heurDistance) return 0;
		else return 1;
	}

	public override string ToString()
	{
		string str = "costDistance: " + costDistance + ", heurDistance: " + heurDistance;
		return str;
	}

	public override int GetHashCode ()
	{
		return (position).GetHashCode();
	}

	public override bool Equals (object obj)
	{
		AStarTuple other = obj as AStarTuple;
		return position == other.position;
	}


}
