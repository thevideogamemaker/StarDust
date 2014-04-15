using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
	public int score = 0;	// I was able to get the score to display. We still need to have it so that when the 
				//player actually interacts withs something (Ex. Kills an enemy) then the score 
				//updates by itself.


	private Playercontrols playerControl;	// Reference to the player control script.
	private int previousScore = 0;			// The score in the previous frame.


	void Awake ()
	{
		// Setting up the reference.
		playerControl = GameObject.FindGameObjectWithTag("Player").GetComponent<Playercontrols>();
	}


	void Update ()
	{
		// Set the score text.
		guiText.text = "Score: " + score;

		// If the score has changed...
		if(previousScore != score)

		// Set the previous score to this frame's score.
		previousScore = score;
	}

}
