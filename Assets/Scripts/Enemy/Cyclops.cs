using UnityEngine;
using System.Collections;

public class Cyclops : MonoBehaviour {

	public int HP = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){

		if(other.tag == "Star")
		{
			if(HP >= 1)
			{
				HP -=1;
				Debug.Log("Enemy lost a life");
			}
		}
	}
}
