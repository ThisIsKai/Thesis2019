using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackboardScript : MonoBehaviour {

	void OnTriggerEnter(Collider other) {						// collision function,for when ball hits this goal
	//	Debug.Log ("first debug, ball hit" + other.gameObject.name);
		if(other.gameObject.tag == "Ball") {						// if the other object (the one hitting this object) has a tag that is "Ball" THEN
			UnityEngine.SceneManagement.SceneManager.LoadScene ("GameOverScreen");
		//	Debug.Log ("second debug, ball hit" + other.gameObject.name);
		} //END BALL COLLISION
	} // END ON TRIGGER

} // END SCRIPT "GOALSCRIPT"
