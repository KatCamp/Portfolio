using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class hit : MonoBehaviour {

	//score recording
	//public static int friendlyFire;
	//public string score;
	//public int points;
	//public GUIText scoreText;
	public Rigidbody2D ash;
	public static Transform destination;
	public ParticleSystem boom;
	// Use this for initialization


	void Start () {
		Physics2D.IgnoreLayerCollision (8, 8, true);

	}



	//get rid of objects that hit wall
	void OnCollisionEnter2D(Collision2D coli) { 

		if (coli.gameObject.tag == "wall") {
			if(this.gameObject.tag == "foe"){
				score.friendlyFire ++;
			}
			if(this.gameObject.tag == "bird"){
				score.friendlyFire ++;
			}
			Destroy(this.gameObject);
		}

	}


	void Update () {
//
//		Touch myTouch = Input.GetTouch (0);
//
//		List<Touch> myTouches = Input.touches;
//
//		foreach( Touch touch in myTouches){
//
//			if (touch.phase == TouchPhase.Began){
//
//				Ray ray = Camera.main.ScreenPointToRay(touch.position);
//
//				RaycastHit dead;
//
//				if (Physics.Raycast(ray, out dead)){
//
//					destination = dead.collider.gameObject.transform;
//					GameObject.Find("LineRenderer").GetComponent<drawLine>().Shoot ();
//
//					// friendly fire count Taco
//					if (dead.collider.gameObject.tag == "taco") {
//						score.friendlyFire++;
//						Destroy (this.gameObject);
//						Rigidbody2D instaciatedprojectile = Instantiate (ash, transform.position, transform.rotation) as Rigidbody2D;
//					
//						}
//					//friendly fire count cat
//					if (dead.collider.gameObject.tag == "cat") {
//						score.friendlyFire++;
//						Destroy (this.gameObject);
//						Rigidbody2D instaciatedprojectile = Instantiate (ash, transform.position, transform.rotation) as Rigidbody2D;
//					
//						}
//					// kill humans, add points
//					if (dead.collider.gameObject.tag == "foe") {
//						score.points++;
//						Destroy (this.gameObject);
//						Rigidbody2D instaciatedprojectile = Instantiate (ash, transform.position, transform.rotation) as Rigidbody2D;
//					
//						}
//					}
//				}
//
//			}
//	

	}


	//destoy clicked on objs
	void OnMouseDown(){

		destination = this.gameObject.transform;
		GameObject.Find("LineRenderer").GetComponent<drawLine>().Shoot ();


		// friendly fire count Taco
		if (this.gameObject.tag == "taco") {
			score.friendlyFire++;
			Destroy (this.gameObject);
			//make boom
			Instantiate(boom, transform.position, transform.rotation);
			// make ash
			Rigidbody2D instaciatedprojectile = Instantiate (ash, transform.position, transform.rotation) as Rigidbody2D;

		}

		//friendly fire count cat
		if (this.gameObject.tag == "cat") {
			score.friendlyFire++;
			// make boom
			Instantiate(boom, transform.position, transform.rotation);
			// make ash
			Rigidbody2D instaciatedprojectile = Instantiate (ash, transform.position, transform.rotation) as Rigidbody2D;
			//	print ("FF" + score.friendlyFire);
		}

		// kill humans, add points
		if (this.gameObject.tag == "foe") {
			score.points++;
			Destroy (this.gameObject);
			// make boom
			Instantiate(boom, transform.position, transform.rotation);
			// make ash
			Rigidbody2D instaciatedprojectile = Instantiate (ash, transform.position, transform.rotation) as Rigidbody2D;
		//	print ("pints =" + score.points);
		}


		if (this.gameObject.tag == "bird") {
			score.points++;
			Destroy (this.gameObject);
			// make boom
			Instantiate(boom, transform.position, transform.rotation);

		}

	}   









}
