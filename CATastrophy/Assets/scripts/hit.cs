﻿using UnityEngine;
using System.Collections;

public class hit : MonoBehaviour {

	//score recording
	//public static int friendlyFire;
	//public string score;
	//public int points;
	//public GUIText scoreText;
	// Use this for initialization
	void Start () {
		Physics2D.IgnoreLayerCollision (8, 8, true);

	}

	//get rid of objects that pass cat
	void OnCollisionEnter2D(Collision2D coli) { 

		if (coli.gameObject.tag == "wall") {
			if(this.gameObject.tag == "foe"){
				score.friendlyFire ++;
			}
			Destroy(this.gameObject);
		}

	}

	void Update () {

	}

	//destoy clicked on objs
	void OnMouseDown(){

		// friendly fire count Taco
		if (this.gameObject.tag == "taco") {
			score.friendlyFire++;
			Destroy (this.gameObject);
		//	print ("FF" + score.friendlyFire);
		}
		//friendly fire count cat
		if (this.gameObject.tag == "cat") {
			score.friendlyFire++;
			Destroy (this.gameObject);
		//	print ("FF" + score.friendlyFire);
		}
		// kill humans, add points
		if (this.gameObject.tag == "foe") {
			score.points++;
			Destroy (this.gameObject);
		//	print ("pints =" + score.points);
		}

	}   
}