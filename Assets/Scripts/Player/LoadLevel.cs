using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour 
{

	public string Level = "";

	void OnTriggerStay2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			Application.LoadLevel(Level);
			Debug.Log("You have entered door");
		}
	}
}