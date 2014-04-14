using UnityEngine;
using System.Collections;

public class timer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public float time = 300; // set duration time in seconds in the Inspector

	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		if (time > 0){
			guiText.text = time.ToString("F0");
			if(playerscript.numOfEnemies == 0 && Application.loadedLevelName == "whatisthis")
			{
				guiText.text = "LEVEL 1\nCOMPLETE\nPress X\nfor Level 2";
				Time.timeScale = 0;
				if (Input.GetKeyDown("x")){ // reload the same level
					Application.LoadLevel("whatisthis2electricboogaloo");
					playerscript.points = 0;
					Time.timeScale = 1;
				}
			}
			else if(playerscript.numOfEnemies == 0 && Application.loadedLevelName == "whatisthis2electricboogaloo")
			{
				guiText.text = "WIN\nPress X\nto restart";
				Time.timeScale = 0;
				if (Input.GetKeyDown("x")){ // reload the same level
					Application.LoadLevel("menu");
					playerscript.points = 0;
					Time.timeScale = 1;
					}
			}

		} else {
			guiText.text = "WIN\nPress X\nto restart";
			Time.timeScale = 0;
			if (Input.GetKeyDown("x")){ // reload the same level
				Application.LoadLevel("menu");
				playerscript.points = 0;
				Time.timeScale = 1;
			}
			else{
				time = 0;
			}
		}
	}



}
