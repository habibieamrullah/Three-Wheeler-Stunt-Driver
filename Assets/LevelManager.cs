using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	int currentLevel;

	void Start () {
		if (!PlayerPrefs.HasKey ("playerLevel")) {
			PlayerPrefs.SetInt ("playerLevel", 1);
			PlayerPrefs.SetInt ("selectedLevel", 1);
		} else {
			currentLevel = PlayerPrefs.GetInt ("playerLevel");
		}
	}
}
