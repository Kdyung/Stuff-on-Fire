using UnityEngine;
using System.Collections;

public class player_rotate : MonoBehaviour {
	
	private Quaternion rotation;//KYCode
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update () {
		/*KYCode - character-mouse rotation*/
		print ("Updating player_rotate");
		var mousePos = Input.mousePosition;
		var objectPos = Camera.main.WorldToScreenPoint(transform.position);
		var dir = Input.mousePosition - objectPos;
		rotation = Quaternion.Euler(0,0,Mathf.Atan2 (dir.y,dir.x) * Mathf.Rad2Deg);
	}	
	void FixedUpdate() {
		transform.rotation = rotation;
	}
}
