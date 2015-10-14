using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {
	

	//spawing characters
	public float maxTime;
	public float minTime;
	private float time;
	private float spawnTime;
	public Rigidbody2D walker;

	//speed up velocity
	public static float HumanSpeedMin;
	public static float HumanSpeedMax;
	public static float CatSpeedMin;
	public static float CatSpeedMax;
	public static float TacoSpeed;
	private float worldTime;
	private float speedUpT = 20;
	private bool AlreadySpedUp = false;


	// Use this for initialization
	void Start () {
		// spawn times
		SetRandomTime ();
		time = minTime;

		//set first speed
			TacoSpeed = 2;
			CatSpeedMin = 2.5f;
			CatSpeedMax = 3f;
			HumanSpeedMin = 2.3f;
			HumanSpeedMax = 4;

		

	}
	
	
	void Update () {

		//gameplay time
		worldTime = Time.time;
		
		// speed up human

			//check for righ time speed up		
			if ((int)worldTime % speedUpT == 0) {
			//only once while it is on that second
			if (AlreadySpedUp == false) {
				//only call once (because its on more that one object)
				if (gameObject.name ==  "CatSpawn"){
					HumanSpeedMin += .2f;
					HumanSpeedMax += .2f;
					CatSpeedMin += .1f;
					CatSpeedMin += .1f;
					AlreadySpedUp = true;
				}
			}		
		} else {
			AlreadySpedUp = false;
		}


		//count up
		time += Time.deltaTime;
		
		//check for righ time to spawn 
		if (time >= spawnTime) {
			Spawn();
			SetRandomTime();
		}
	}
	
	void Spawn (){
		time = 0;
		Rigidbody2D instaciatedprojectile = Instantiate (walker, transform.position, transform.rotation) as Rigidbody2D;
	
	}
	
	void SetRandomTime(){
		spawnTime = Random.Range(minTime, maxTime);
	}
}
