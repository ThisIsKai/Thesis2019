using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverSceneToStartScene : MonoBehaviour { //CHANGES FROM THE GAME OVER SCREEN TO THE START SCREEN

	void Start () {
		//nothing needed here yet	
	}


	void Update () {
		if (Input.GetKey (KeyCode.Return)) {
			UnityEngine.SceneManagement.SceneManager.LoadScene ("StartScreen");
		}//END LOAD SCENE
	}//END UPDATE FUNCTION
}//END GAME OVER SCENE TO START SCREEN
