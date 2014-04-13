using UnityEngine;
using System.Collections;

public class DestroyStar : MonoBehaviour {

	public GameObject Star;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnColliderEnter2D(Collider2D col)
	{
		if(col.name == "W 1-1")
		{
			Destroy(Star);
			Debug.Log("Destroyed");
		}
	}

}
