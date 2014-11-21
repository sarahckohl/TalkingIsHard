using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//print ("bullet made...");
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x < 0)
						DestroyImmediate (gameObject);

	
	}

	void OnBecameInvisible () {
		//print ("bullet invisible.");
		DestroyImmediate(gameObject);
	}


}
