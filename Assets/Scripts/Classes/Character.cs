using UnityEngine;
using System.Collections;

public abstract class Character : MonoBehaviour {


	protected int health;
	protected float velocity;

	// Use this for initialization
	protected void Start () 
	{
		health = 100;
		velocity = 1.5f;
	}

	protected float distanceTo(Vector3 point)
	{
		return Mathf.Sqrt( Mathf.Pow(gameObject.transform.position.x - point.x, 2) + Mathf.Pow(gameObject.transform.position.y - point.y, 2) + Mathf.Pow(gameObject.transform.position.z - point.z, 2));
	}
}
