using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// QUEBRAR EM MULTIPLAS CLASSES!!!!!!!

//

public abstract class Action
{
	public enum ACTION_TYPE {GET, DROP, EAT, REST, MOVE};

	public ACTION_TYPE type;

	public Action(ACTION_TYPE type)
	{
		this.type = type;
	}
		
}