
using UnityEngine;
using System.Collections;



public class myGUI : MonoBehaviour {
	public int choicePairNum=0;
	string[] messages = new string[6]{
		"(A girl stands there. She is reading a book)",
		"(She looks up)'Oh. Uh... Hi..?'",
		"*Awkward silence*",
		"Go jump off a cliff",
		"It's Oedipus.",
		"Take a long hike off a short pier."
		
	};
	//public string messages= "HOLA";
	float timer=0.0f;
	Rect button1 = new UnityEngine.Rect (Screen.width/2+50, Screen.height-60, Screen.width/5,30);
	Rect button2 = new UnityEngine.Rect (Screen.width/2+50+Screen.width/5, Screen.height-60, Screen.width/5,30);

	Rect textbox= new UnityEngine.Rect(10, Screen.height-110, Screen.width/2,100);
	Rect previoustext = new UnityEngine.Rect (10, Screen.height-250, Screen.width/4, 100);
	//to be printed
	public string messageBuffer="";
	
	public string messageBuffer2="";
	
	public string current="";

	int convoNum=0;
	
	//total characters in the current message
	float total=0.0f;
	
	//Which message we are on
	public int currIndex=0;
	public int lastIndex=0;
	// Use this for initialization
	void Start () {
		GUIStyle stupidFont;
		stupidFont = new GUIStyle ();
		stupidFont.fontSize = 72;
		current = messages [0];
		StartCoroutine(delay());
		
	}
	
	// Update is called once per frame && total > (messages [currIndex].ToString.Length - 1))
	void Update () {
		//timer += Time.deltaTime;
	
		//print (timer);
		//right side
		if (convoNum == 4 && !waiting) {

			StartCoroutine(delay());
			response (messages[4],0);
			convoNum=0;
			choicePairNum=4;
				}

		//left side
		if (convoNum == 1 && !waiting) {
			
			StartCoroutine(delay());
			response (messages[1],0);
			convoNum=0;
			choicePairNum=1;
		}

		if (convoNum == 2 && !waiting) {
			
			StartCoroutine(delay());
			response (messages[2],0);
			convoNum=0;
			choicePairNum=2;
		}

		if (convoNum == 3 && !waiting) {
			
			StartCoroutine(delay());
			response (messages[3],0);
			convoNum=0;
			choicePairNum=3;
		}
		if (convoNum == 5 && !waiting) {
			
			StartCoroutine(delay());
			response (messages[5],0);
			convoNum=0;
			choicePairNum=5;
		}
		
		/*if (Input.GetKeyDown ("return")) {
						currIndex = (currIndex + 1) % messages.Length;
			  			lastIndex=(currIndex - 1) % messages.Length;
						total = 0; //resets total char count
						messageBuffer = "";

						messageBuffer = messages[currIndex];
				if(currIndex>0){
				messageBuffer2 = messages[lastIndex];
			}
			else{
				messageBuffer2 = "";
			}
				}*/
		//	}
		//scroll the text in the buffer. If Total goes out of bound, set it back to Length.
		/*
		if(total> messages[currIndex].Length){
			total=(float)messages[currIndex].Length;
		}
		messageBuffer = messages [currIndex].Substring (0, (int)total);
		total++;
*/
		
	}

	bool waiting; // tells whether the delay is running

	public IEnumerator delay(){
		waiting = true; // Delay started

		yield return new WaitForSeconds(4);
		waiting = false; // Delay ended
		}

	public void response(string x,int y){
		messageBuffer2 = current;
		
		current = x;
		convoNum = y;
		//messageBuffer2 = current;
			
		//current = messages [1];
						
				}




	void OnGUI(){
		
		/*if (GUI.Button (button1, "OOGA")) {
			response ("HEY TALK TO ME",1);

		}
		
		if (GUI.Button (button2, "BOOGA")) {
			response ("Excuse me",2);
		}*/

		GUI.Box (previoustext, "");
		GUI.Label (previoustext,"<size=30)>"+ messageBuffer2+"</size>");

		//GUI.Box (button1, "OOGA");
		///GUI.Box (button2, "BOOGA");

		GUI.Box (textbox, "");
		GUI.Label (textbox,"<size=30)>"+ current+"</size>");
		//GUI.TextArea (new Rect (10, Screen.height-110, Screen.width-20, 100), "This is a text box");
		
		

		
		
		
	}
	
}

