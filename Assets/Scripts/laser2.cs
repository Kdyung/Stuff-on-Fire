using UnityEngine;
using System.Collections;

[RequireComponent(typeof(LineRenderer))]

public class laser2 : MonoBehaviour 
{
	Vector2 mouse;
	RaycastHit2D hit;
	float range = 10.0f;
	LineRenderer line;
	public Material lineMaterial;
	timer second;

//	GameObject player = GameObject.Find ("player");
//	Transform playerTransform = player.transform;
//	Vector3 position = playerTransform.position;

	void Start()
	{
		line = GetComponent<LineRenderer>();
		line.SetVertexCount(2);
		line.renderer.material = lineMaterial;
		line.SetWidth(1f, 0.5f);
	}
	
	void Update()
	{
		// get point where mouse is
		Vector3 mousePos = Input.mousePosition;
		mousePos = Camera.main.ScreenToWorldPoint (mousePos);
	
		hit = Physics2D.Raycast (transform.position, mousePos - transform.position, range);
		//if(hit.collider.tag == "Player") {
			if(Input.GetMouseButton(0))
			{
				line.enabled = true;
				line.SetPosition(1, transform.position);
//			print (transform.position.x);
				line.SetPosition(0, hit.point + hit.normal);
			}
			else
				line.enabled = false;
		//}
		
	}

	// for debugging
	void OnDrawGizmos() {
		if (hit != null) {
			Gizmos.color = Color.red;
			Gizmos.DrawLine(gameObject.transform.position, hit.point + hit.normal);
		}
	}
}