using UnityEngine;
using System.Collections;

public class MeilingEmitter : MonoBehaviour {


	public GameObject shot;
	private Quaternion bulletrot;
	private Quaternion rotate1 = Quaternion.Euler (0.0f, 0.0f, 72.0f);
	private GameObject target;
	private Quaternion lookatRotation;

	// Use this for initialization
	void Start () {
		target = GameObject.FindWithTag("Player");
		//lookatRotation = Quaternion.LookRotation (target.transform.position - transform.position, new Vector3(1,0,0));
		float randX = Random.Range (0.5f,4.5f);
		Vector3 loc = new Vector3 (randX, 7.5f, 0.0f);
		gameObject.transform.position = Vector3.zero;


		Vector3 diff = target.transform.position - transform.position;
		diff.Normalize();
		
		float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
		bulletrot = gameObject.transform.rotation;
		MeilingShoot ();
		//Vector3 offset = new Vector3 (0.5f, 0.0f, 0.0f);
		//Destroy (gameObject);

	
	} 


	void MeilingShoot()
	{
		bulletrot = gameObject.transform.rotation;// * (Quaternion.Euler (0.0f, 0.0f, 72.0f));
		Vector3 speedmodifier = new Vector3 (0f,0f,0f);

		//Quaternion.Euler (0.0f, 0.0f, 72.0f);
		print ("Meiling gets called");

		for (int i=0; i<10; i++) {
			//make each one a little faster than the last (will need to modify it's velocity which probably
			//means binding it to a variable
			GameObject newshot = (GameObject) Instantiate (shot, (gameObject.transform.position), (bulletrot));
			//newshot.rigidbody2D.velocity = speedmodifier;
			float newspeed = 1+i*0.3f;
			newshot.GetComponent<Mover>().setSpeed(newspeed);
		}


	}



	
	// Update is called once per frame
	void Update () {


		
		//create object at each angle
		//one should be rotated at zero degrees



	}
}
