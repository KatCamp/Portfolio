using UnityEngine;
using System.Collections;

public class drawLine : MonoBehaviour {

	public LineRenderer lineRenderer;
	public Material[] lineColor;
	public Transform origin;
	//private float dist;
	//private float count; 
	//public float lineSpeed =  .2f;
	
	// Use this for initialization
	void Start () {
		//lineRenderer = GetComponent<LineRenderer> ();
		//	lineRenderer.SetPosition (0, origin.position);
		//	lineRenderer.SetWidth (.45f, .45f);
		
		//	DistanceJoint2D = Vector3.Distance (origin.position, hit.destination);
	}
	
	public void Shoot(){
		lineRenderer = gameObject.AddComponent<LineRenderer> ();
		lineRenderer = GetComponent<LineRenderer> ();
		lineRenderer.materials = lineColor;
		lineRenderer.SetPosition (0, origin.position);
		lineRenderer.SetPosition (1, hit.destination.position);
		lineRenderer.SetWidth (.3f, .3f);
		Invoke ("destroyLine", .2f);
		
		//	dist = Vector3.Distance (origin.position, hit.destination.position);
		
		//		if (count < dist) {
		//			count += .1f / lineSpeed;
		//			float x = Mathf.Lerp ( 0 , dist, count);
		//			Vector3 start = origin.position;
		//			Vector3 end = hit.destination.position;
		//			Vector3 pointAlongLine = x * Vector3.Normalize(end -start) + start;
		//			lineRenderer.SetPosition(1, pointAlongLine);
		
		//		}
	}
	void destroyLine(){
		
		Destroy (lineRenderer);
		
	}
	// Update is called once per frame
	void Update () {
		
		
	}
}


