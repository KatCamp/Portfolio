using UnityEngine;
using System.Collections;

public class ash : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter2D(Collision2D coli) { 
		
		if (coli.gameObject.tag == "wall") {
			Destroy(this.gameObject);
		}
		
	}
	// Update is called once per frame
	void Update () {
	
	}
}
