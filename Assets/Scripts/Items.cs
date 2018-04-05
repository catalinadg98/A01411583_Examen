using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour {

	public Sprite[] hitSprites;
	public static int collected = 0;
	public int scoreValue = 0; 
	private ScoreKeeper scoreKeeper; 
	private int timesHit;
	private LevelManager levelManager;
	private bool isThere;

	void Start () {
		isThere = (this.tag == "isThere");

		if (isThere) {
			collected++;
		}

		timesHit = 0;

		scoreKeeper = GameObject.Find("Score").GetComponent<ScoreKeeper>();
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}

	void OnCollisionEnter2D (Collision2D collision){
		if (isThere) {
			HandleHits ();
		}
	}

	void HandleHits(){
		timesHit++;
		int maxHits = hitSprites.Length + 1;
		if (timesHit >= maxHits) {
			collected--;
			levelManager.ItemsCollected ();
			Destroy (gameObject);
		} 
	}

	void LoadSprites(){
		int spriteIndex = timesHit - 1;
		if (hitSprites [spriteIndex] != null) {
			this.GetComponent<SpriteRenderer> ().sprite = hitSprites [spriteIndex];
		} else {
			Debug.LogError ("Item sprite missing");
		}
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.tag == "Player")
		{
			scoreKeeper.Score(scoreValue);
			Destroy(gameObject);

		}
	}
}