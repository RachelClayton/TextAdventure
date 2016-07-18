using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class intro4real : MonoBehaviour {

	string currentRoom = "Computer";

	// Use this for initialization
	void Start () {


	}
		

	void Update () {
		string textBuffer = "You stare at the glowing screen, trying to make sense of your code.";

		if ( currentRoom == "Computer" ) {
			textBuffer += "\nWhy did you wait until it was so late to start your homework?";
			textBuffer += "\nYou feel your eyes glazing over and your head getting heavier...";
			textBuffer += "\nSo sleepy...must...finish....";
			textBuffer += "\npress [S] to Start";


			if ( Input.GetKeyDown (KeyCode.S) ) {
				SceneManager.LoadScene(1);
			} 
		} 

 
		
		GetComponent<Text> ().text = textBuffer;
	}



	// Update is called once per frame




}
