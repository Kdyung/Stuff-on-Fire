using UnityEngine;
using System.Collections;

public class playerscript : MonoBehaviour {

	public Vector2 speed = new Vector2(50, 50);
	// Use this for initialization


	void Start () {
	}

	private Vector2 movement;

	// Update is called once per frame
	void Update () {

		// 3 - Retrieve axis information
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");
		
		// 4 - Movement per direction
		movement = new Vector2(
			speed.x * inputX,
			speed.y * inputY); 

		/*KYCode - camera-mouse rotation
		var mousePos = Input.mousePosition;
		var objectPos = Camera.main.WorldToScreenPoint(transform.position);
		var dir = Input.mousePosition - objectPos;
		transform.rotation = Quaternion.Euler(0,0,Mathf.Atan2 (dir.y,dir.x) * Mathf.Rad2Deg);*/


	}

	void FixedUpdate() {
		// 5 - Move the game object
		rigidbody2D.velocity = movement;

	}
}
