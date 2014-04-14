using UnityEngine;
using System.Collections;

public class playerscript : MonoBehaviour {

	public Vector2 speed = new Vector2(50, 50);
	public static float points = 0;
	public static int numOfEnemies = 0;
	public float addpoints = 20;
	void Start () {
	}

	private Vector2 movement;

	
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.name == "npc") {
			points += addpoints;
			numOfEnemies -= 1;
			Destroy (collision.gameObject);
		} 
	}


	void Update () {

		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");

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
