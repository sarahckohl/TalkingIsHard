using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private int angerExp;
	private int Anger;
	private int happyExp;
	private int Happy;
	public GameObject Player;
	public CharacterControllerScript characterController;
	public GameObject angerPrefab;
	public GameObject happyPrefab;
	public GameObject MeilingEmitterPrefab;
	//public TextMesh angerXPtext;
	public TextMesh score;
	public TextMesh happyscore;

	// Use this for initialization
	void Start () {
		characterController =  GameObject.FindGameObjectWithTag ("Player").GetComponent<CharacterControllerScript>();
		InvokeRepeating("spawnMeiling", 4.0f,4.0f);

		Anger = 0;
		angerExp = 0;
		Happy = 0;
		happyExp = 0;
		score.text = "Anger: 0";
		happyscore.text = "Happy: 0";
		//angerXPtext.text = "AngerXP: 0";

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//I'd really like to have an "Increment Emotion" that does for any emotion by reference
	public void incrementAngerExp(int amount)
	{
		angerExp += amount;
		if (angerExp >= 5) {
			angerExp = 0;
			dropAnger ();
		}
		//angerXPtext.text = "AngerXP: " + angerExp.ToString();
	}

	//maybe generalize this to LevelUp(emotion)
	public void AngerUp()
	{
		Anger++;
		score.text = "Anger: " + Anger.ToString();
	}

	public void dropAnger()
	{
		float randX = Random.Range (0.5f,8.5f);
		Vector3 loc = new Vector3 (randX, 6.0f, 0.0f);
		Quaternion rot = new Quaternion ();
		Instantiate (angerPrefab,loc,rot);
		//spawnMeiling ();

		}


	public void incrementHappyExp(int amount)
	{
		happyExp += amount;
		if (happyExp >= 5) {
			happyExp = 0;
			dropHappy ();
		}
	}
	
	//maybe generalize this to LevelUp(emotion)
	public void HappyUp()
	{
		Happy++;
		happyscore.text = "Happy: " + Happy.ToString();
		print ("DROP DA HAPPY");
	}
	
	public void dropHappy()
	{
		float randX = Random.Range (0.5f,8.5f);
		Vector3 loc = new Vector3 (randX, 6.0f, 0.0f);
		Quaternion rot = new Quaternion ();
		Instantiate (happyPrefab,loc,rot);
		//spawnMeiling ();
		
	}

	public void spawnMeiling()
	{
		Instantiate (MeilingEmitterPrefab);
	}



	//same here, would be nice to generalize this
	public int getAnger()
	{
		return Anger;
	}
	public int getHappy()
	{
		return Happy;
	}
	public void resetPlayer()
	{
		resetEmotions ();
		Player.SendMessage ("resetPosition");

	}

	public void resetEmotions()
	{
		Anger = 0;
		angerExp = 0;
		Happy = 0;
		happyExp = 0;

	}

}
