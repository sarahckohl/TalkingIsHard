using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	float speed = 1.0f;

	// Use this for initialization
	void Awake (){
		//print ("awake");
		// (1.0f);
		rigidbody2D.velocity = transform.up * speed;
	}

	void Start () {
		//print ("start");



	}


	public void setSpeed(float _speed){
		//print ("setspeed");
		speed = _speed;
		rigidbody2D.velocity = transform.up * speed;
		//rigidbody2D.AddForce(transform.up * 50);
	}


}
