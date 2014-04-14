using UnityEngine;
using System.Collections;

public class npc : MonoBehaviour {
	//Generates npcs of a certain number
	public int numberOfObjects = 5; 
	public GameObject myObject; 
	private Vector3 position;
	public bool onfire = false;
	private Vector2 movement;
	private float velocity = 5;

	public static int health = 40;

	// Use this for initialization
	private Quaternion rotation;//KYCode

	void Start () {
		print ("Initualizing npc-creation loop");
		for (var i = 1; i< numberOfObjects ; i++){
			print ("NPC created");
			position = new Vector3(Random.Range(10, -10), Random.Range(0, -0), Random.Range(10, -10));
			Instantiate(myObject, position, Quaternion.identity);
		}
		Destroy(this);
	}

	// Update is called once per frame
	void Update () {
		if (onfire == true) {
			velocity=10;
		}else{
			velocity = 5;
		}
		Run ();
	}
	//updates the direction of movement randomly
	void getVelocity(){
		//gets a random point to run to, and 
		var nextPos = new Vector3 (Random.Range (10, -10)*velocity, Random.Range (10, -10)*velocity, 0);
		var objectPos = transform.position;
		var dir = nextPos - objectPos;
		rotation = Quaternion.Euler(0,0,Mathf.Atan2 (dir.y,dir.x) * Mathf.Rad2Deg);
		movement = dir/5;
	}
	//Maps behavior pattern of NPC 
	void Run(){
		Wait (1000);
		getVelocity ();
		Wait (1000);
		transform.rotation = rotation;
		Wait (100000);
	}
	//Wait function to wait for an interval
	IEnumerator Wait(int x){
		yield return new WaitForSeconds(x);
	}
	void FixedUpdate() {
		rigidbody2D.velocity = movement;
	}
}
