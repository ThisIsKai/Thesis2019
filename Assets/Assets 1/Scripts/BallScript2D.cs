using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class BallScript2D: MonoBehaviour { // BALL SCRIPT : overrides z posistion if it hits a hole, 
										  // and sends stuff to the console when it collides with stuff

	public AudioSource suction_sound_source;
	public AudioClip suction_sound_clip;

	public float ballMinZ; 						// the minimum Z coordinate for the ball
	private Rigidbody ballRB; 					// the ball's rigidbody
	public float suctionSpeed; 					// the speed of the z movement once the ballRB breaches the ballMinZ
	Transform ballTransform; 					// the ball's transform

	void Start () {																			// START FUNCTION
		ballTransform = transform; 															// define ballTransform
		ballRB = GetComponent<Rigidbody>(); 												// get that rigidbody
	}//END START	

	/void FixedUpdate () {																	// FIXED UPDATE FUNCTION
		if (this.gameObject.transform.position.z > ballMinZ) { 								// if this game object (the ball)'s z posistion 
//			suction_sound_source.PlayOneShot (suction_sound_clip);
																							// is greater than the ballMinZ THEN
			ballRB.MovePosition (transform.position + new Vector3 (0, 0, suctionSpeed));	// the ball's rigidbody will move posistion 
//			suction_sound_source.Stop(); 													// from it's current transform
																							// based on the Vector3 (x=0,y=0, z=suctionSpeed
		} // END IF
	} // END FIXED UPDATE

	void OnTriggerEnter(Collider other) {													// collision function,for when ball hits this goal
			if (other.gameObject.tag == "Goals") { 
				
			}
		} //END ON COLLISION					
		

 }// END SCRIPT "BALL SCRIPT"
	

*/
