using UnityEngine;
using System.Collections;

public class optionbox : MonoBehaviour {


	public GameObject textBox;
	public GameObject options2;
	bool choicePicked;
	// Use this for initialization
	void Start () {
		

	// pos=GameObject.Find("Character").transform.position;
		//Screen.width/2+50, Screen.height-60, Screen.width/5,30
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown("space")&& choicePicked){
			textBox.GetComponent<myGUI>().response("HEY COME TALK TO ME",1);
		}


	/*	print (pos.x);
		print (pos.y);

		if (pos.x > Screen.width / 2 + 50
			&& pos.x < (Screen.width / 2 + 50) + (Screen.width / 5)
		    && pos.y<60 
		    && pos.y>60 - 30

		   ) {
			print (Input.mousePosition.y);
				}
GameObject go = GameObject.Find("somegameobjectname");
ScriptB other = (ScriptB) go.GetComponent(typeof(ScriptB));
other.DoSomething();
*/
	}

	public void disable(){
		choicePicked=false;
	}
	
	void OnTriggerEnter2D(Collider2D player){
		if (player.gameObject.tag == "Player") {
			print ("hit");
			choicePicked=true;
			options2.GetComponent<optionbox2>().disable();
		}
		}

	
}