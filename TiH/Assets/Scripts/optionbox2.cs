using UnityEngine;
using System.Collections;

public class optionbox2 : MonoBehaviour {
	
	
	public GameObject textBox;
	public GameObject options1;
	public GameObject optionText;
	public GameObject optionText2;
	public GameObject controller;
	bool choicePicked;
	int currindex=0;
	int anger;
	
	string[] messages = new string[5]{
		"What book is that?",
		"Pshhh who reads!",
		"U FOKING WOT M8!",
		"Message 3!",
		"Message 4!",
		
	};
	// Use this for initialization
	void Start () {
		
		// pos=GameObject.Find("Character").transform.position;
		//Screen.width/2+50, Screen.height-60, Screen.width/5,30
		
	}
	
	// Update is called once per frame
	void Update () {
		int choicepair=textBox.GetComponent<myGUI>().choicePairNum;
		anger=controller.GetComponent<GameController>().getAnger();

		if(Input.GetKeyDown("space")&& choicePicked && choicepair==0 && anger>0){
			textBox.GetComponent<myGUI>().response(messages[1],3);
			StartCoroutine(textBox.GetComponent<myGUI>().delay());
			optionText.GetComponent<TextMesh>().text="Pshhh";
			optionText2.GetComponent<TextMesh>().text="Pshhh";
		}
		else if(Input.GetKeyDown("space")&& choicePicked && choicepair==0 ){
			textBox.GetComponent<myGUI>().response(messages[0],4);
			StartCoroutine(textBox.GetComponent<myGUI>().delay());
			optionText.GetComponent<TextMesh>().text="Discuss Achilles heel";
			optionText2.GetComponent<TextMesh>().text="Discuss incest";
		}
		
		if(Input.GetKeyDown("space")&& choicePicked && choicepair==1){
			textBox.GetComponent<myGUI>().response(messages[0],4);
			StartCoroutine(textBox.GetComponent<myGUI>().delay());
			optionText.GetComponent<TextMesh>().text="Introduce self1";
			optionText2.GetComponent<TextMesh>().text="Introduce self1";
		}
		if(Input.GetKeyDown("space")&& choicePicked && choicepair==4 && anger>0){
			textBox.GetComponent<myGUI>().response(messages[2],3);
			StartCoroutine(textBox.GetComponent<myGUI>().delay());
			optionText.GetComponent<TextMesh>().text="Pshhh";
			optionText2.GetComponent<TextMesh>().text="Pshhh";
		}
		if(Input.GetKeyDown("space")&& choicePicked && choicepair==3 && anger>0){
			textBox.GetComponent<myGUI>().response(messages[2],5);
			StartCoroutine(textBox.GetComponent<myGUI>().delay());
			optionText.GetComponent<TextMesh>().text="Pshhh";
			optionText2.GetComponent<TextMesh>().text="Pshhh";
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
			
			choicePicked=true;
			options1.GetComponent<optionbox>().disable();
		}
	}
	
	
}