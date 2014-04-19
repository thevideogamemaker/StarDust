using UnityEngine;
using System.Collections;

public class Respawnplayer : MonoBehaviour {

	public bool dead;
	public GameObject Player;
	public GameObject Spawnpoint;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if(dead)
		{
			Instantiate(Player,transform.position, Quaternion.identity);
			dead = false;
		}
	}
}
