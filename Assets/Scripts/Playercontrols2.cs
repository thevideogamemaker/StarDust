using UnityEngine;
using System.Collections;

public class Playercontrols2 : MonoBehaviour {

	public float playerspeed = 5.0f;


	// Use this for initialization
	void Start () {
	
		//Player Spawn Point. This is where player will start at beginning of game
		//player = game object. Game object ==tranform;

		transform.position = new Vector3 (-9, -4, 0);

	}
	
	// Update is called once per frame
	void Update () {
	
		//player to move left/right/up/down
		//player (gameobject) aka transform to move when i press the arrow keys

		transform.Translate (Vector3.right * Input.GetAxis("Horizontal") * playerspeed * Time.deltaTime);




	}
}
