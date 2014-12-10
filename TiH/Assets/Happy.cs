using UnityEngine;
using System.Collections;

public class Happy : MonoBehaviour {
	
	GameController gameController;
	float speed = 1.2f;
	
	
	// Use this for initialization
	void Start () {
		
		gameController = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController>();
		rigidbody2D.velocity = Vector3.down * speed;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -3.0 )
			Destroy(gameObject);
		
		
		
	}
	
	
	void OnTriggerEnter2D(Collider2D other){
		
		if (other.gameObject.tag == ("Player")) {
			gameController.HappyUp ();
			Destroy (gameObject);
		} else
			return;
		
		
	}
	
	
	
}
