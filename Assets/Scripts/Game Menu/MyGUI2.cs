using UnityEngine;
using System.Collections;

public class MyGUI2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI ()
	{
		if (GUI.Button(new Rect(10,10,200,60), "World 1")) 
		{
			Application.LoadLevel("World 1");	
		}
		if (GUI.Button(new Rect(10,80,200,60), "World 2")) 
		{
			Application.LoadLevel("World 2");	
		}
		if (GUI.Button(new Rect(10,150,200,60), "World 3")) 
		{
			Application.LoadLevel("World 3");	
		}

	}
}
