using UnityEngine;
using System.Collections;

public class optionbox : MonoBehaviour {


	public GameObject textBox;
	public GameObject options2;
	public GameObject optionText;
	public GameObject optionText2;
	public GameObject controller;
	int currindex=0;
	bool choicePicked;
	int anger;
	int happy;
	string[] messages = new string[5]{
		"HEY THERE HELLO HI",
		"Hello",
		"UGH NO ONE UNDERSTAANDS ME",
		"I'm person!",
		"What book is that?",

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
		happy=controller.GetComponent<GameController>().getHappy();
		print (anger);
		if(Input.GetKeyDown("space")&& choicePicked && choicepair==0 && anger>0 && happy<1){
			textBox.GetComponent<myGUI>().response(messages[2],2);
			StartCoroutine(textBox.GetComponent<myGUI>().delay());
			optionText.GetComponent<TextMesh>().text="Introduce self";
			optionText2.GetComponent<TextMesh>().text="Ask about book";
		}
		else if(Input.GetKeyDown("space")&& choicePicked && choicepair==0 && happy>0 && anger<1 ){
			textBox.GetComponent<myGUI>().response(messages[0],2);
			StartCoroutine(textBox.GetComponent<myGUI>().delay());
			optionText.GetComponent<TextMesh>().text="Introduce self";
			optionText2.GetComponent<TextMesh>().text="Ask about book";
		}

		else if(Input.GetKeyDown("space")&& choicePicked && choicepair==0 ){
			textBox.GetComponent<myGUI>().response(messages[1],1);
			StartCoroutine(textBox.GetComponent<myGUI>().delay());
			optionText.GetComponent<TextMesh>().text="Introduce self";
			optionText2.GetComponent<TextMesh>().text="Ask about book1111";
		}

		else if(Input.GetKeyDown("space")&& choicePicked && choicepair==1){
			textBox.GetComponent<myGUI>().response(messages[3],2);
			StartCoroutine(textBox.GetComponent<myGUI>().delay());
			optionText.GetComponent<TextMesh>().text="Ask about book";
			optionText2.GetComponent<TextMesh>().text="Ask about book";
		}
		else if(Input.GetKeyDown("space")&& choicePicked && choicepair==2){
			textBox.GetComponent<myGUI>().response(messages[4],4);
			StartCoroutine(textBox.GetComponent<myGUI>().delay());
			optionText.GetComponent<TextMesh>().text="Discuss Achilles heel";
			optionText2.GetComponent<TextMesh>().text="Discuss incest";
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