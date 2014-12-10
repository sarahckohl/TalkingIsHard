using UnityEngine;
using System.Collections;

public class BurstEmitter : MonoBehaviour {

	bool waiting;
	public GameObject shot;

	// Use this for initialization
	void Start () {
		StartCoroutine(delay());
	
	}
	
	// Update is called once per frame
	void Update () {

		if (!waiting) {
				}
		
		

	
	}


		IEnumerator delay(){
			waiting = true; // Delay started
			
			yield return new WaitForSeconds(4);
			waiting = false; // Delay ended
		}

}
