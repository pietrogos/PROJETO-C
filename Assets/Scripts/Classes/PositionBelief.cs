using UnityEngine;
using System.Collections;

public class PositionBelief {

	public string itemId;
	public Vector3 position;
	public string insideId;


	public PositionBelief(string itemId, Vector3 position, string insideId = null)
	{
		this.itemId = itemId;
		this.position = position;
		this.insideId = insideId;
	}
}
