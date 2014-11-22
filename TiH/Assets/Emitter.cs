using UnityEngine;
using System.Collections;

public class Emitter : MonoBehaviour {


	public GameObject shot;
	private Quaternion bulletrot;
	private Quaternion rotate1 = Quaternion.Euler (0.0f, 0.0f, 72.0f); 
	private Quaternion rotate2 = Quaternion.Euler (0.0f, 0.0f, 2.0f*72.0f); 
	private Quaternion rotate3 = Quaternion.Euler (0.0f, 0.0f, 3.0f*72.0f); 
	private Quaternion rotate4 = Quaternion.Euler (0.0f, 0.0f, 4.0f*72.0f); 


	// Use this for initialization
	void Start () {
		bulletrot = gameObject.transform.rotation;
		//Vector3 offset = new Vector3 (0.5f, 0.0f, 0.0f);

		InvokeRepeating ("SpiralShoot", 0.1f, 0.1f);

	
	}



	void SpiralShoot()
	{

		bulletrot = gameObject.transform.rotation;// * (Quaternion.Euler (0.0f, 0.0f, 72.0f));
		
		//Quaternion.Euler (0.0f, 0.0f, 72.0f); 
		
		
		
		Instantiate (shot, (gameObject.transform.position + new Vector3 (0.005f, 0.0f, 0.0f)), (bulletrot));
		bulletrot = gameObject.transform.rotation*rotate1;
		Instantiate (shot, (gameObject.transform.position + new Vector3 (0.005f, 0.0f, 0.0f)), (bulletrot));
		bulletrot = gameObject.transform.rotation*rotate2;
		Instantiate (shot, (gameObject.transform.position + new Vector3 (0.005f, 0.0f, 0.0f)), (bulletrot));
		bulletrot = gameObject.transform.rotation*rotate3;
		Instantiate (shot, (gameObject.transform.position + new Vector3 (0.005f, 0.0f, 0.0f)), (bulletrot));
		bulletrot = gameObject.transform.rotation*rotate4;
		Instantiate (shot, (gameObject.transform.position + new Vector3 (0.005f, 0.0f, 0.0f)), (bulletrot));
	
	
	}



	
	// Update is called once per frame
	void Update () {

		transform.Rotate (Vector3.forward, Time.deltaTime * 60, Space.World);


		
		//create object at each angle
		//one should be rotated at zero degrees



	}
}
