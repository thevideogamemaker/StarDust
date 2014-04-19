using UnityEngine;
using System.Collections;

public class MyGUI : MonoBehaviour {

	public GUITexture Startbutton;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI() {

		//Make a background for the button

		GUI.Box (new Rect(240,50,100,200), "Menu");

		//make a button. Be able to click the button. If clicked, return inventory screen.

		if (GUI.Button(new Rect(250,80,80,25), "Play Game")) {
			Application.LoadLevel("Level Select");	
		}

		if (GUI.Button(new Rect(250,115,80,25), "Settings")) {
			Application.LoadLevel("Settings");	
		}

		if (GUI.Button(new Rect(250,150,80,25), "How to Play")) {
			Application.LoadLevel("How to Play");	
		}



	}
	
}