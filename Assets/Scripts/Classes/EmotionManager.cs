using UnityEngine;
using System.Collections;

public class EmotionManager {

	float hungerMeter;
	float energyMeter;

	public EmotionManager() 
	{
		hungerMeter = 100.0f;
		energyMeter = 100.0f;
	}

	public void updateEmotion()
	{
		//valores arbitrarios por enquanto
		hungerMeter += -Time.deltaTime * 2;
		energyMeter += -Time.deltaTime;
	}

	public float howHungry()
	{
		return 100 - hungerMeter;
	}

	public float howTired()
	{
		return 100 - energyMeter;
	}
}
