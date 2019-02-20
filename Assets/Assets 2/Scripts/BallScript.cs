using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
	private Rigidbody2D ballRB;
	//public Vector2 bounceForce;
	public float bounceForce;


	// Use this for initialization
	void Start () {
		ballRB = gameObject.GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision other) {					// collision function,for when ball hits this goal
		if (other.gameObject.name == "BouncyBlock") {					// if the other object (the one hitting this object) has a tag that is "Ball" THEN
			Debug.Log("Ball hit" + other.gameObject.name);
			AddBounceForce();
		}	// end  if other object is ball
	}//END ON COLLISION ENTER FUNCTION

	void AddBounceForce (){
		ballRB.velocity = ballRB.velocity * bounceForce;

	}
}
