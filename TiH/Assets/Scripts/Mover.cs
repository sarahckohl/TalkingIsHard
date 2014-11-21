using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	float speed = 1;

	// Use this for initialization
	void Start () {
		rigidbody2D.velocity = transform.up * speed;


	}
}
