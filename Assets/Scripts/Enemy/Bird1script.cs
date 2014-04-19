using UnityEngine;
using System.Collections;

public class Bird1script : MonoBehaviour {

	public int HP = 2;
	private Score score;

	public GameObject Bird1;
	public GameObject Score;
	public GameObject Enemyexplode;

	// Use this for initialization
	void Start () {
		score = GameObject.Find ("Score").GetComponent <Score> ();
	}
	
	// Update is called once per frame
	void Update () {

		if(HP < 1)
		{
			DestroyObject(Bird1);
			score.score += 50;
			Instantiate(Enemyexplode,transform.position, Quaternion.identity);
		}

	}

	void OnTriggerEnter2D(Collider2D other){

		if(other.tag == "Star")
		{
			if(HP >= 1)
			{
				HP -=1;
				Debug.Log("Enemy lost a life");
			}
		}
	}

	//void OnCollisionExit2D(Collision2D other)
	//{
		//if(other.gameObject.tag == "Enemy")
		//{
			//if(Player_health >= 1)
		//	{
		//		Player_health = Player_health -10;
		//		Debug.Log ("You have lost health");
		//	}
		//}
	//}
}
