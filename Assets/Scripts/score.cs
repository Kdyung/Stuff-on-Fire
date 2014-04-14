using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

//	public float gameScore = 0;
//	public float points = 20;
//	public playerscript player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		guiText.text = playerscript.points.ToString ("F0");
//		if (player.) {
//			gameScore += points;
//		}

	}

//	public static void IncreaseScore(int score) {
//
//		gameScore += score;
//	}
}
