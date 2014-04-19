using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour 
{
	//This whole thing might need to be re-written. It should be a waypoints system that can be used for moving platforms and enemy AI by checking if it's at the maximun X or Y position, and then moving in the opposite direction until reaching the minimun position.
	
	public Transform DestinationSpot;
	public Transform OriginSpot;
	public float Speed;
	public bool Switch = false;
	
	void FixedUpdate()
	{
		// For these 2 if statements, it's checking the position of the platform.
		// If it's at the destination spot, it sets Switch to true.
		if(transform.position == DestinationSpot.position)
		{
			Switch = true;
		}
		if(transform.position == OriginSpot.position)
		{
			Switch = false;
		}
		
		// If Switch becomes true, it tells the platform to move to its Origin.
		if(Switch)
		{
			transform.position = Vector3.MoveTowards(transform.position, OriginSpot.position, Speed);
		}
		else
		{
			// If Switch is false, it tells the platform to move to the destination.
			transform.position = Vector3.MoveTowards(transform.position, DestinationSpot.position, Speed);
		}
	}
}
