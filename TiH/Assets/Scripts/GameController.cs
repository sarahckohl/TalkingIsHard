using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private int angerExp;
	private int Anger;
	public GameObject Player;
	public CharacterControllerScript characterController;
	public GameObject angerPrefab;
	public TextMesh score;
	public GameObject MeilingEmitterPrefab;
	public TextMesh angerXPtext;


	// Use this for initialization
	void Start () {
		characterController =  GameObject.FindGameObjectWithTag ("Player").GetComponent<CharacterControllerScript>();

		Anger = 0;
		angerExp = 0;
		score.text = "Anger: 0";
		angerXPtext.text = "AngerXP: 0";

	
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
		angerXPtext.text = "AngerXP: " + angerExp.ToString();
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
		spawnMeiling ();

		}

	public void spawnMeiling()
	{
		float randX = Random.Range (0.5f,4.5f);
		Vector3 loc = new Vector3 (randX, 7.5f, 0.0f);
		Quaternion rot = new Quaternion ();
		Instantiate (MeilingEmitterPrefab);
	}



	//same here, would be nice to generalize this
	public int getAnger()
	{
		return Anger;
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

	}

}
