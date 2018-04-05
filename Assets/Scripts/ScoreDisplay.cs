using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

	private ScoreKeeper scoreKeeper;
	public int scoreValue;

	// Use this for initialization
	void Start () {
		Text scoreText = GetComponent<Text> ();
		scoreText.text = ScoreKeeper.scoreValue.ToString ();
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.tag == "Player")
		{
			scoreKeeper.Score(scoreValue);
			Destroy(gameObject);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
