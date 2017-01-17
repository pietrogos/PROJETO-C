using UnityEngine;
using System.Collections;

public class StateBelief {

	public string itemId;
	public int state; //mudar pro que usar de state depois


	public StateBelief(string itemId, int state)
	{
		this.itemId = itemId;
		this.state = state;
	}
}
