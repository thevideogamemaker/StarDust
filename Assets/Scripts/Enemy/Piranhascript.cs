using UnityEngine;
using System.Collections;

public class Piranhascript : MonoBehaviour {

	public int HP = 2;
	private Score score;
	
	public GameObject Piranha;
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
			DestroyObject(Piranha);
			score.score += 60;
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
}
