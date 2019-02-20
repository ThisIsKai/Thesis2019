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

    private SliderJoint2D joint;
    private JointMotor2D motor;
	void Start () {																	// Start function
		myTransform = transform; 													// define myTransform
		rb = GetComponent<Rigidbody2D>(); 											// get that rigidbody

        joint = GetComponent<SliderJoint2D>();
        motor = joint.motor;
	//	col = GetComponent<CapsuleCollider2D>();									// get that collider
	}//END START


	void FixedUpdate () {															// FixedUpdate is called once per physics tick/frame
		if (isRight) {																// is this the right control?
			if (Input.GetKey (KeyCode.O))													// make 'O' the up key for right control
				MoveUp (); 															// call move up
			else if (Input.GetKey (KeyCode.L)) 											// make 'L' the down key for right control
				MoveDown (); 														// call move down
			else {                                                                  // else
                                                                                    //rb.velocity = Vector2.zero; 										// otherwise don't move
                motor.motorSpeed = 0;
                joint.motor = motor;
			} // end else not moving
		} // end right side control scheme

		else { 																		// if it's not right control (making it left)
			if (Input.GetKey (KeyCode.Q)) 												// make 'Q' the up key for the left control
				MoveUp ();															// call move up
			else if (Input.GetKey (KeyCode.A))											// make 'A' the down key for left control
				MoveDown (); 														// call move down
			else {                                                                  // else
                                                                                    //rb.velocity = Vector2.zero;											// otherwise don't move

                motor.motorSpeed = 0;
                joint.motor = motor;
            } // end else not moving
		} // end left side control scheme
	} // END FIXED UPDATE

	void MoveUp() { 																// MoveUp function, to move control up, effected by 'speed'
		if (rb.transform.position.y <= topLimit) {
            //if (rb.velocity.magnitude < speed) {
            //rb.AddForce(new Vector2(0, speed), ForceMode2D.Impulse);	
            //}

            //	rb.velocity += new Vector2(0, speed); // simplified upwards movement

            //get the anchor points of the joint in world coordinates

            //only move if we want to move less than that distance

            //             rb.MovePosition(transform.position + new Vector3(0, Mathf.Min(speed,currentDistance), 0));

            motor.motorSpeed = -speed*100f;
            joint.motor = motor;
   
            Debug.Log("reaction force " + joint.reactionForce.magnitude);

			
			//Debug.Log("moving up");
			Debug.Log(rb.velocity + "is up velocity");
		}//if in range
	}//END MOVE UP

	void MoveDown() {																// MoveDown function, to move control down, effected by 'speed'
		if (rb.transform.position.y >= bottomLimit) {

            motor.motorSpeed = speed * 100f;
            joint.motor = motor;

     //       rb.velocity += new Vector2(0, -speed); // simplified downwards momvement
			//rb.MovePosition(transform.position - new Vector3(0, speed,0));
			//Debug.Log("moving down");
			//Debug.Log(rb.velocity + "is down velocity");
		}//end if in range
	}//END MOVE DOWN
		
}//END SCRIPT