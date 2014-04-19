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

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag == "Enemy")
		{
			Destroy(Star);
		}
		if(col.tag == "World")
		{
			Destroy(Star);
		}
	}

}
