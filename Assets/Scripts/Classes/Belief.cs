using UnityEngine;
using System.Collections;

public abstract class Belief {

	public enum BeliefType {positionBelief, stateBelief}

	BeliefType beliefType;

	Belief(BeliefType type)
	{
		this.beliefType = type;
	}
}
