using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationScripts : MonoBehaviour {

	public void playTheGame(){
		int level = PlayerPrefs.GetInt ("selectedLevel");
		SceneManager.LoadScene ("Level" + level);
	}

	public void selectLevel(){
		SceneManager.LoadScene ("LevelSelector");
	}
}
