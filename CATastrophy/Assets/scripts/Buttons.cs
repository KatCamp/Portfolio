using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	// reload sceen
	public void ReloadLoadScene(){
		Application.LoadLevel (Application.loadedLevel);
	}

	public void Loadplay(){
		Application.LoadLevel (1);
	}

	public void LoadMenu(){
		Application.LoadLevel (0);
	}

	// reset bestscore
	public void ResetScore(){

		PlayerPrefs.DeleteKey("BestScore");

	}



	// Update is called once per frame
	void Update () {
	
	}
}
