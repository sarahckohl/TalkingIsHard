using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {
	public float speed = 0.1f;
	// Use this for initialization
	void Start () {
		Destroy(gameObject, 7f);
	}
	
	// Update is called once per frame
	void Update () {

				
	
		transform.position += transform.up * Time.deltaTime * speed;
	}
	void OnMouseOver(){
	
						//GameObject Textbox = GameObject.Find ("Textbox");
						//myGUI playerscript = Textbox.GetComponent<myGUI> ();
						//playerscript.messages = "FUAHK";
						//playerscript.response ();
						Destroy (gameObject);
				
	}
}
