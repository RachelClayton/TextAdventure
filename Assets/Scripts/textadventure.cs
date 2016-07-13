using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class textadventure : MonoBehaviour {

	string currentRoom = "Computer";

	// Use this for initialization
	void Start () {
		

	}

	bool hasGoodIdea = false;
	bool hasCorrectCode = false;

	void Update () {
		string textBuffer = "You are currently in: " + currentRoom;

		if ( currentRoom == "Computer" ) {
			textBuffer += "\nYou've somehow teleported inside your computer! The only way out: finish your assignment.";
			textBuffer += "\npress [F] to go on Facebook";
			textBuffer += "\npress [U] to go to Unity";

			if ( Input.GetKeyDown (KeyCode.F) ) {
				currentRoom = "Facebook";
			} else if ( Input.GetKeyDown (KeyCode.U) ) {
				currentRoom = "Unity";
			}
		} else if ( currentRoom == "Unity" ) {
			
			textBuffer += "\nSince you're here, you might as well iterate.";
			if ( hasCorrectCode == false ) {

			textBuffer += "\nOh no! You can't test your game until you compile all errors! Will the horrors never end?";
			} else {
				textBuffer += "\nPress [P] to play your game.";
				if ( Input.GetKeyDown (KeyCode.P) ) {
					currentRoom = "Game"; 
		
			}
			} 
			textBuffer += "\nPress [F] to go on Facebook.";
			textBuffer += "\nPress [S] to open your script."; 
			if ( Input.GetKeyDown (KeyCode.F) ) {
				currentRoom = "Facebook";
			} else if ( Input.GetKeyDown (KeyCode.S) ) {
				currentRoom = "Script"; }
			
		} else if ( currentRoom == "Facebook" ) {
			
			textBuffer += "\nSweet procrastination. Oh, there's a corn dog festival in Astoria next month? Interested...";
			textBuffer += "\nPress [U] to return to Unity.";
			textBuffer += "\nPress [M] to message Kelly."; 
			if ( Input.GetKeyDown (KeyCode.U) ) {
					currentRoom = "Unity";
				} else if ( Input.GetKeyDown (KeyCode.M) ) {
					currentRoom = "Message with Kelly"; }

		} else if ( currentRoom == "Script" ) {
			textBuffer += "\nEverything looks fine! Stupid code...";
			textBuffer += "\nOh. It seems you forgot a curly bracket. Better add that in.";
			hasCorrectCode = true;

			textBuffer += "\nPress [U] to return to Unity.";

			if ( Input.GetKeyDown (KeyCode.U) ) {
				currentRoom = "Unity";
			}

		} else if ( currentRoom == "Message with Kelly" ) {
			textBuffer += "\nYou complain to Kelly about your problems. Coding is so hard!";
			textBuffer += "\nShe doesn't understand. If only there was a way she could experience your pain....";
			textBuffer += "\nYou have an idea!";
			textBuffer += "\npress [U] to go to Unity";
			hasGoodIdea = true; 

			if ( Input.GetKeyDown (KeyCode.U) ) {
				currentRoom = "Unity";
			} 
		} else if ( currentRoom == "Game" ) {
			if ( hasGoodIdea == false ) {

				textBuffer += "\nEverything works now, but man is this boring! If only you had a better idea...";
				textBuffer += "\nPress [U] to return to Unity.";
				textBuffer += "\nPress [S] to open your script."; 
				if ( Input.GetKeyDown (KeyCode.U) ) {
					currentRoom = "Unity";
				} else if ( Input.GetKeyDown (KeyCode.S) ) {
					currentRoom = "Script"; }
			} else {
				textBuffer += "\nYou implement your new idea."; 
				textBuffer += "\nEverything works, and it's super fun to play!";
				textBuffer += "\n The End";
			} 

		}
		GetComponent<Text> ().text = textBuffer;
	}


	
	// Update is called once per frame

	


	}