using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZKLogoTimer : MonoBehaviour {

	float countDown = 3f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (countDown > 0)
			countDown -= Time.deltaTime;
		else
			Application.LoadLevel ("MainMenu");
	}
}
