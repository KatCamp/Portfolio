using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {

	public static int friendlyFire;
	//score recording
	private string scores;
	public static int points;
	public Text scoreText;
	private int BScore;
	private string BscoreString;
	// losing score
	public Image hit1;
	public Image hit2;
	public Image hit3;
	public Sprite Kill;

	// Lost game 
	public Image end;
	public Button replay;
	public Button menu;
	public Text gameO;
	public Text EndScore;
	public Text bestScore;
	// Use this for initialization
	void Start () {
		friendlyFire = 0;
		points = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

		// update win score
		if (BScore < points) {
			BScore = points;
		}
		// turn best score to string
		BscoreString = BScore.ToString();
		//updating score
		scores = points.ToString ();
		scoreText.text = scores;

		// updating losing
		if (friendlyFire == 1) {
			//change texture hit 1
			hit1.sprite = Kill;
		} else if (friendlyFire == 2) {
			//change texture hit 2
			hit2.sprite = Kill;
		} else if (friendlyFire >= 3) {
			//change texture hit 3
			hit3.sprite = Kill;
			//lost menu comes up
			end.gameObject.SetActive(true);
			replay.gameObject.SetActive(true);
			menu.gameObject.SetActive(true);
			EndScore.gameObject.SetActive(true);
			bestScore.gameObject.SetActive(true);
			gameO.gameObject.SetActive(true);
			EndScore.text = "Score     " + scores;
			bestScore.text = "Best Score    " + BscoreString;
			// score goes away
			scoreText.gameObject.SetActive(false);



		} 
	}


}
