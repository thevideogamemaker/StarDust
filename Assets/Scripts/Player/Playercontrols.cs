using UnityEngine;
using System.Collections;

public class Playercontrols : MonoBehaviour 
{
	public float maxSpeed = 10f;
	public bool facingRight = true;
	public GameObject Player;

	Animator anim;

	public bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 400f;
	public int playerlives = 5;
	public int Player_health = 100;

	public GUIStyle HealthbarGUI;
	public GUIStyle HeartlivesGUI;
	public GUIStyle Pausebutton;

	bool doubleJump = false;

	private bool isPaused;
	
	void Start () 
	{
		anim = GetComponent<Animator> ();
		isPaused = false;
	}

	void FixedUpdate () 
	{
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);

		if(grounded)
			doubleJump = false;

		anim.SetFloat ("vSpeed", rigidbody2D.velocity.y);



		float move =Input.GetAxis ("Horizontal");

		anim.SetFloat ("Speed", Mathf.Abs (move));

		rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);

		if(move > 0 &&!facingRight)
			Flip ();
		else if(move < 0 && facingRight)
			Flip ();

	}

	void Update()
	{
		if((grounded || !doubleJump) && Input.GetKeyDown(KeyCode.UpArrow))
		{
			anim.SetBool("Ground",false);
			rigidbody2D.AddForce (new Vector2(0, jumpForce));

			if(!doubleJump && !grounded)
				doubleJump = true;
		}

		if (Input.GetKeyDown (KeyCode.P)) 
		{
			Pause ();
		}

		if(Player_health > 100) 
		{
			Player_health = 100;
		}
		if(Player_health < 0)
		{
			Player_health = 0;
		}

		if(Player_health == 0)
		{
			if(playerlives >= 1)
			{
				playerlives = playerlives -1;
				DestroyObject(Player);
				Debug.Log ("You lost a life");
			}
		}
}

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	void Pause()
	{
		if(Time.timeScale == 1)
		{
			Time.timeScale = 0;
			isPaused = true;
		}
		else
		{
			Time.timeScale = 1;
			isPaused = false;
		}   
	}

	void OnGUI()
	{
		if(isPaused)
		{
			GUI.Box(new Rect(175,100,Screen.width/2,Screen.height/4),"Game is Paused");
			
				if(GUI.Button(new Rect(279,123,Screen.width/5,Screen.height/6),"Unpause"))
				{
					isPaused = false;
					Pause();
					Debug.Log("Unpause button clicked");
				}
		}

		GUI.Box (new Rect (5, 5, Player_health, 15), "" + Player_health, HealthbarGUI);
		GUI.Box (new Rect (5, 23, 16, 14), "     " + playerlives, HeartlivesGUI);
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.name == "Outside of Map")
			Player_health = 0;
	}
	
}