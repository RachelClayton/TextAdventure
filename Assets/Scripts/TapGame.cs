using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class TapGame : MonoBehaviour {

	public Text myTextObject;

	int currentPoints = 0; 


	// Use this for initialization
	void Start () {
	
		myTextObject.text = "Press Space to Play!"; 

	}
	
	// Update is called once per frame
	void Update () {
		// give player 1 point if they press Space
		if ( Input.GetKeyDown(KeyCode.Space) ) {
			currentPoints += 1;
			myTextObject.text = "CURRENT SCORE: " + currentPoints.ToString();
		}

		if ( Input.GetKeyDown(KeyCode.W) ) {
			currentPoints += 5000;
			myTextObject.text = "CURRENT SCORE: " + currentPoints.ToString();
		}
	}
}
