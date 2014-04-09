using UnityEngine;
using System.Collections;

public class ShootStar : MonoBehaviour {
	
	public GameObject Player;
	public Rigidbody2D Star;
	public Animator anim;

	void Start()
	{
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			anim.SetBool("Shoot", true);
			Instantiate(Star, transform.position, Quaternion.identity);
		}
		if(Input.GetKeyUp(KeyCode.Space))
		{
			anim.SetBool("Shoot", false);
	}
}
}