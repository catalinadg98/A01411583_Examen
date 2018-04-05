using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

	public static int scoreValue = 0;
	private Text scoreText;				

	void Start () {
		scoreText = GetComponent<Text> ();
		//Reset ();
		scoreText.text = scoreValue.ToString ();
	}
		
	void Update () {

	}

	public void Score(int points) {
		scoreValue += points;
		scoreText.text = scoreValue.ToString ();
	}

/*	public static void Reset() {
		scoreValue = 0;
	}*/
}
