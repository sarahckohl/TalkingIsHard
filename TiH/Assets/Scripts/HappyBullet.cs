using UnityEngine;
using System.Collections;

public class HappyBullet : MonoBehaviour {

	GameController gameController;
	// Use this for initialization
	void Start () {
		//print ("bullet made...");
		gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController>();
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x < 0 || transform.position.y > 5 || transform.position.x > 11.5 || transform.position.y < -2.8 )
						Destroy(gameObject);


	
	}
	void OnTriggerEnter2D(Collider2D other){
		
		
		if(other.gameObject.tag ==("Bullet" )){
			return;
			//print ("Hit" + other);
			//Destroy (gameObject);
		}
		if (other.gameObject.tag == ("Player")) {
			gameController.incrementHappyExp(1);
				}
		if(other.gameObject.tag == ("Hitbox"))
		   {
			print("Hit");
			Destroy (gameObject);
			gameController.resetPlayer();
			gameController.resetEmotions();

		}


	}
	void OnBecameInvisible () {
		//print ("bullet invisible.");
		DestroyImmediate(gameObject);
	}


}
