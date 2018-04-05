using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public AudioClip sound;		
	public float damage = 10f;

	private Rigidbody2D rgb;				
	//private ScoreKeeper scoreKeeper;		

	void Start () {
//		scoreKeeper = GameObject.Find ("Score").GetComponent<ScoreKeeper> ();
	}

	public float getDamage() {
		return damage;
	}
}