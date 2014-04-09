using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour
{
	public int score = 0;					// The player's score.


	private Playercontrols playercontrols;	// Reference to the player control script.
	private int previousScore = 0;			// The score in the previous frame.


	void Awake ()
	{
		// Setting up the reference.
		playercontrols = GameObject.FindGameObjectWithTag("Player").GetComponent<Playercontrols>();
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
