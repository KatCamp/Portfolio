using UnityEngine;
using System.Collections;

public class spawnTwo : MonoBehaviour {

	public float maxTime;
	public float minTime;
	private float time;
	private float spawnTime;
	public Rigidbody2D walkerTwo;
	
	//speed up velocity
	public static float BirdSpeedMin;
	public static float BirdSpeedMax;

	private float worldTime;
	private float speedUpT = 10;
	private bool AlreadySpedUp = false;
	
	
	// Use this for initialization
	void Start () {
		// spawn times
		SetRandomTime ();
		time = minTime;

		BirdSpeedMin = 2.3f;
		BirdSpeedMax = 4;
		
		
		
	}
	
	
	void Update () {
		
		//gameplay time
		worldTime = Time.time;

		
		//check for righ time speed up		
		if ((int)worldTime % speedUpT == 0) {
			//only once while it is on that second
			if (AlreadySpedUp == false) {
				//only call once (because its on more that one object)
				if (gameObject.name ==  "BirdSpawn"){
					BirdSpeedMin += .2f;
					BirdSpeedMax += .2f;
					AlreadySpedUp = true;
				}
			}		
		} else {
			AlreadySpedUp = false;
		}


		
		if ((int)worldTime > 10) {
			//count up
			time += Time.deltaTime;
		
			//check for righ time to spawn 
			if (time >= spawnTime) {
				Spawn ();
				SetRandomTime ();
			}
		
		
		}
	}
	
	void Spawn (){
		time = 0;
		Rigidbody2D instaciatedprojectile = Instantiate (walkerTwo, transform.position, transform.rotation) as Rigidbody2D;
		
	}
	
	void SetRandomTime(){
		spawnTime = Random.Range(minTime, maxTime);
	}
}
