using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		SceneManager.LoadScene (name);
	}

	public void EndGame(){
		Application.Quit ();
	}

	public void ItemsCollected(){
		if (Items.collected <= 0) 
		{
			LoadNextLevel ();
		}
	}

	public void LoadNextLevel(){
		Items.collected = 0;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
}