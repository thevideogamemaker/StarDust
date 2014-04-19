using UnityEngine;
using System.Collections;

public class MoveStar : MonoBehaviour {


	public Rigidbody2D Star;
	public float StarSpeed = 6f;

	private Playercontrols facingRight;


	// Use this for initialization
	void Start () 
	{
		facingRight = GameObject.Find ("Player").GetComponent<Playercontrols> ();
	}
	// Update is called once per frame
	void Update () 
	{
		//for some reason these two if statements aren't working. It should work by sayng that if facing right is true, then shoot it in the x position + 6 and when not facing right, he should shoot it -6, making it go the opposite way.
		if (facingRight)
		{
			rigidbody2D.velocity = new Vector2 (6, 0);
		}
		if (facingRight == false)
		{
			rigidbody2D.velocity = new Vector2 (-6, 0);
		}
	}

	void OnColliderEnter2D(Rigidbody2D other)
	{
		if(other.tag == "World")
		{
			Destroy(Star);
		}
	}

}
