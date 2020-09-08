using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour {

	public Text leveltext;
	int selectedLevel;
	int playerLevel;

	// Use this for initialization
	void Start () {
		selectedLevel = PlayerPrefs.GetInt ("selectedLevel");
		playerLevel = PlayerPrefs.GetInt ("playerLevel");
		leveltext.text = "" + selectedLevel;
	}
	
	public void goPrev(){
		if (selectedLevel > 1) {
			selectedLevel -= 1;
			PlayerPrefs.SetInt ("selectedLevel", selectedLevel);
			leveltext.text = "" + selectedLevel;
		}
	}
	public void goNext(){
		if (selectedLevel < playerLevel && selectedLevel < 10) {
			selectedLevel += 1;
			PlayerPrefs.SetInt ("selectedLevel", selectedLevel);
			leveltext.text = "" + selectedLevel;
		}
	}
}
