using UnityEngine;
using System.Collections;

public class Paralax : MonoBehaviour {

	public float paraSpeed = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector2 offset = new Vector2 (Time.time * paraSpeed, 0);

		GetComponent<Renderer>().material.mainTextureOffset = offset;
	}
}
