using UnityEngine;
using System.Collections;

using UnityEngine.UI; 

public class startmenu : MonoBehaviour {

	string currentRoom = "Computer";


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		string textBuffer = "You are currently in: " + currentRoom;

		if ( currentRoom == "Computer" ) {
			textBuffer += "\nYou've somehow teleported inside your computer! The only way out: finish your assignment.";
			textBuffer += "\npress [F] to go on Facebook";
			textBuffer += "\npress [U] to go to Unity";

			if ( Input.GetKeyDown (KeyCode.F) ) {
				currentRoom = "Facebook";
			} 

	}
}

}