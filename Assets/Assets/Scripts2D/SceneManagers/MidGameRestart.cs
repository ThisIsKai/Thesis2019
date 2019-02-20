using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MidGameRestart : MonoBehaviour { // SHORTCUT TO RESTART THE GAME 

	void Start () {
		//nothing needed here yet
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.R)) {
			UnityEngine.SceneManagement.SceneManager.LoadScene ("GameScene");
		}//END MID GAME RESTART
	}//END UPDATE FUNCTION
}// END MIDGAME RESTART SCRIPT
