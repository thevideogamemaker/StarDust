using UnityEngine;
using System.Collections;

public class HowtoPlay : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI ()
	{
		GUI.TextArea(new Rect (10,10,500,200),"Use the arrow keys to move in various directions. Use the spacebar to shoot stars. Defeat enemies to increase your score. Touch the level door at the end to advance to the next level.");

		if(GUI.Button(new Rect(10,250, 50,20), "Back"))
		{
			Application.LoadLevel("Main Menu");
		}
	}
}
