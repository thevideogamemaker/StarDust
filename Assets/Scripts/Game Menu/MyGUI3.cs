using UnityEngine;
using System.Collections;

public class MyGUI3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI ()
	{
		if (GUI.Button(new Rect(10,10,80,80), "Level 1")) 
		{
			Application.LoadLevel("W 1-1");	
		}
		if (GUI.Button(new Rect(110,10,80,80), "Level 2")) 
		{
			Application.LoadLevel("W 1-2");	
		}
		if (GUI.Button(new Rect(210,10,80,80), "Level 3")) 
		{
			Application.LoadLevel("W 1-3");	
		}
		if (GUI.Button(new Rect(310,10,80,80), "Level 4")) 
		{
			Application.LoadLevel("W 1-4");	
		}
		if (GUI.Button(new Rect(410,10,80,80), "Level 5")) 
		{
			Application.LoadLevel("W 1-5");	
		}
	}
}
