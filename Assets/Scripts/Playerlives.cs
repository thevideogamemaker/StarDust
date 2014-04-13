using UnityEngine;
using System.Collections;

public class Playerlives : MonoBehaviour {

	public int lives = 5;
	public GUIStyle HeartlivesGUI;



	void OnGUI ()
	{
		GUI.Box (new Rect (5, 23, 12, 12), "", HeartlivesGUI);
	}

}