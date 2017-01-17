using UnityEngine;
using System.Collections;

public class InGameTime : MonoBehaviour {

	static InGameTime instance;
	int hours;
	float minutes;

	public static InGameTime getInstance()
	{
		if(instance == null)
			instance = (new GameObject()).AddComponent<InGameTime>();
		return instance;
	}
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		addTime(Time.deltaTime);
		//Debug.Log(getTime());
	}

	void addTime(float timetoadd)
	{
		minutes += timetoadd;
		if(minutes/60.0f >= 1)
		{
			hours += (int) minutes/60;
			if(hours > 24)
			{
				hours = hours % 24;
			}
			minutes = minutes % 60.0f;
		}
	}

	public string getTime()
	{
		int min = (int) minutes;
		//Debug.Log(hours.ToString() + ":" + min.ToString());

		return hours.ToString() + ":" + min.ToString();

	}

	public void setTime(string time)
	{
		char[] chars = {':'};
		string[] lol = time.Split(chars, 1);
		hours =  int.Parse(lol[0]);
		minutes = int.Parse(lol[1]);
	}
}
