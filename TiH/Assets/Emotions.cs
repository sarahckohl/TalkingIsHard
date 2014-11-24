using UnityEngine;
using System.Collections;

public class Emotions : MonoBehaviour {

	private int angerExp;
	private int Anger;

	// Use this for initialization
	void Start () {
		Anger = 0;
		angerExp = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//I'd really like to have an "Increment Emotion" that does for any emotion by reference
	public void incrementAngerExp(int amount)
	{
		angerExp += amount;
		if (angerExp >= 10) {
			angerExp = 0;
			//drop an emotion pickup
		}
	}

	//maybe generalize this to LevelUp(emotion)
	public void AngerUp()
	{
		Anger++;
	}

	//same here, would be nice to generalize this
	public int getAnger()
	{
		return Anger;
	}
}
