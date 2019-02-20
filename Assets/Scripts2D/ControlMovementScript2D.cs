using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMovementScript2D : MonoBehaviour {

	public float bottomLimit;
	public float topLimit;
	[SerializeField] 																// makes it editable in the inspector
	bool isRight;																	// is it the Right Control

	[SerializeField] 																// makes it editable in the inspector
	float speed = 0.2f;      	 													// paddle speed

	Transform myTransform;															// reference to the object's transform
	int direction = 0; 																// 0 = not moving, 1= up, -1 = down
	private Rigidbody2D rb; 															// rigidbody is rb now


	void Start () {																	// Start function
		myTransform = transform; 													// define myTransform
		rb = GetComponent<Rigidbody2D>(); 											// get that rigidbody
	//	col = GetComponent<CapsuleCollider2D>();									// get that collider
	}//END START


	void FixedUpdate () {															// FixedUpdate is called once per physics tick/frame
		if (isRight) {																// is this the right control?
			if (Input.GetKey (KeyCode.O))													// make 'O' the up key for right control
				MoveUp (); 															// call move up
			else if (Input.GetKey (KeyCode.L)) 											// make 'L' the down key for right control
				MoveDown (); 														// call move down
			else {																	// else
				rb.velocity = Vector2.zero; 										// otherwise don't move
			} // end else not moving
		} // end right side control scheme

		else { 																		// if it's not right control (making it left)
			if (Input.GetKey (KeyCode.Q)) 												// make 'Q' the up key for the left control
				MoveUp ();															// call move up
			else if (Input.GetKey (KeyCode.A))											// make 'A' the down key for left control
				MoveDown (); 														// call move down
			else {																	// else
				rb.velocity = Vector2.zero;											// otherwise don't move
			} // end else not moving
		} // end left side control scheme
	} // END FIXED UPDATE

	void MoveUp() { 																// MoveUp function, to move control up, effected by 'speed'
		if (rb.transform.position.y <= topLimit) {
			rb.velocity += new Vector2(0, speed); // simplified upwards movement
			rb.MovePosition(transform.position + new Vector3(0, speed,0));
			//Debug.Log("moving up");
			//Debug.Log(rb.velocity + "is up velocity");
		}//if in range
	}//END MOVE UP

	void MoveDown() {																// MoveDown function, to move control down, effected by 'speed'
		if (rb.transform.position.y >= bottomLimit) {
			rb.velocity += new Vector2(0, -speed); // simplified downwards momvement
			rb.MovePosition(transform.position - new Vector3(0, speed,0));
			//Debug.Log("moving down");
			//Debug.Log(rb.velocity + "is down velocity");
		}//end if in range
	}//END MOVE DOWN
		
}//END SCRIPT