using UnityEngine;
using System.Collections;

public class SideWalk : MonoBehaviour {

	// Use this for initialization
	private float randomSpeed;
	private Rigidbody2D walker;
	void Start () {

		//human speed
		if (this.gameObject.tag == "foe") {
			randomSpeed = Random.Range(spawn.HumanSpeedMin, spawn.HumanSpeedMax);
			walker = GetComponent<Rigidbody2D> ();
			walker.velocity = new Vector2 (-randomSpeed, 0);
			// print( "min " + spawn.HumanSpeedMin);
		}
		
		//cat speed
		if (this.gameObject.tag == "cat") {
			randomSpeed = Random.Range(spawn.CatSpeedMin, spawn.CatSpeedMax);
			walker = GetComponent<Rigidbody2D> ();
			walker.velocity = new Vector2 (-randomSpeed, 0);
		}

		//taco speed
		if (this.gameObject.tag == "taco") {
			walker = GetComponent<Rigidbody2D> ();
			walker.velocity = new Vector2 (-spawn.TacoSpeed, 0);
		}

		if (this.gameObject.tag == "blast") {
			walker = GetComponent<Rigidbody2D> ();
			walker.velocity = new Vector2 (-spawn.TacoSpeed, 0);
		}

	}


	// Update is called once per frame
	void Update () {

	
	}
}
