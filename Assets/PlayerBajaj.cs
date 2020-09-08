using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBajaj : MonoBehaviour {

	int currentLevel;
	int playerLevel;

	void Start () {
		currentLevel = PlayerPrefs.GetInt ("selectedLevel");
		playerLevel = PlayerPrefs.GetInt ("playerLevel");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider cldr){
		if (cldr.name == "FallInHell") {
			SceneManager.LoadScene ("Level" + currentLevel);
		}
		if (cldr.name == "FinishLine") {
            if (ZKAd.interstitial.IsLoaded())
            {
                ZKAd.interstitial.Show();
            }
            if (currentLevel == playerLevel && currentLevel < 10) {
				PlayerPrefs.SetInt ("playerLevel", currentLevel + 1);
				PlayerPrefs.SetInt ("selectedLevel", currentLevel + 1);
			}
			SceneManager.LoadScene ("LevelSelector");
		}
	}

	public void reloadLevel(){
		SceneManager.LoadScene ("Level" + currentLevel);
	}

	public void goHome(){
		SceneManager.LoadScene ("MainMenu");
	}
}
