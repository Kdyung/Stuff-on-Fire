using UnityEngine;
using System.Collections;

public class breakable : MonoBehaviour {
	
	public int health = 10;
	public int currHealth;
	public int score = 20;
	public bool isEnemy = true;
	public bool isDead = false;

	// Sprites
	private SpriteRenderer breakSprite;
	public Sprite thing;
	public Sprite hurtThing;
	public Sprite deadThing;

	// Use this for initialization
	void Start () {
		breakSprite = gameObject.GetComponent<SpriteRenderer>();
		currHealth = health;
	}
	
	// Update is called once per frame
	void Update () {

		// If at half health switch to damaged sprite
		if(currHealth < health/2 ) {
			
			breakSprite.sprite = hurtThing;
			
		}
		
		// If at no health, switch to damaged sprite
		if(currHealth == 0 && isDead != true) {
			
			breakSprite.sprite = deadThing;
			isDead = true;
			
		}
	
	}

	void OnTriggerEnter2D(Collider2D collider) { 
	
		/*laser beam = collider.gameObject.GetComponent<laser>();

		// Avoid friendly fire
		if(beam.isEnemyShot != isEnemy && this.isDead != true)
		{
			currHealth -= beam.damage;


		}
		*/

	}

}
