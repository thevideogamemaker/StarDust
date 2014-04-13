using UnityEngine;
using System.Collections;

public class MoveStar : MonoBehaviour {


	public Rigidbody2D Star;
	public float StarSpeed = 6f;
	public bool facingRight = true;


	// Use this for initialization
	void Start () 
	{
		facingRight = GetComponent<Playercontrols>();

	}
	// Update is called once per frame
	void Update () 
	{
			rigidbody2D.velocity = new Vector2 (StarSpeed, 0);
	}

	void OnColliderEnter2D(Rigidbody2D other)
	{
		if(other.tag == "World")
		{
			Destroy(Star);
		}
	}

}
