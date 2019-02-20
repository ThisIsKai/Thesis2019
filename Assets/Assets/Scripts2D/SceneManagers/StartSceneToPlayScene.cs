using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneToPlayScene : MonoBehaviour { //MOVES YOU FROM THE START SCREEN TO THE MAIN GAME SCENE

	void Start () {
		//nothing needed here yet
	}
		
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			UnityEngine.SceneManagement.SceneManager.LoadScene ("GameScene");
		}//END LOAD SCENE
	}//END GET KEY
}//END START SCENE TO PLAY SCENE SCRIPT
