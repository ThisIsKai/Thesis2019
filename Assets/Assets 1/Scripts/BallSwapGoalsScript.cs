using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSwapGoalsScript : MonoBehaviour { // A SCRIPT ATTACHED TO THE GOAL CUBES

	public float timeUntilDestroyed;
	public float colorChangeTimer;
	public GameObject firstBallType;
	public GameObject secondBallType;
	public Vector3 swappedBallSpawnPoint;
	GameObject currentBall;
	bool thisGoalHit;


	void Start(){
		thisGoalHit = false;

	//float colorChangeTimer = timeUntilDestroyed;
	}//END START


	void OnCollisionEnter2D(Collision2D other) {					// collision function,for when ball hits this goal
			if(other.gameObject.tag == "Ball") {					// if the other object (the one hitting this object) has a tag that is "Ball" THEN
			Debug.Log ("Ball Hit  " + this.gameObject.name);

			thisGoalHit = true;
			StartCountdownTimer();
			ChangeMaterialColor ();
		//	GameManager.Instance.DecreaseScore ();	
			SwapBallObject ();

			}// end  if other object is ball
	}//END ON COLLISION ENTER FUNCTION


void Update(){
//
//		if (thisGoalHit == true) {
//			
//		}//end if goal hit
}//END UPDATE


	void StartCountdownTimer (){
		Debug.Log (this.gameObject.name+" Countdown Timer Started");

		timeUntilDestroyed -= (Mathf.FloorToInt(Time.deltaTime));
		Debug.Log (timeUntilDestroyed + " is the timeUntilDestroyed");

		if (timeUntilDestroyed <= 0) {
			Destroy (this.gameObject);													// destroy this game object (the one this script is attached to)
			Debug.Log (this.gameObject.name+"destroyed");

		}//END TIME UNTIL DESTROYED

	}//END START COUNTDOWN TIMER FUNCTION


	void ChangeMaterialColor (){
		float lerp = colorChangeTimer;
		Debug.Log (this.gameObject.name+ "Color Change Started");

		Renderer goalColor = GetComponent<Renderer>();											//get renderer for the goals

		goalColor.material.shader = Shader.Find("_Color");										//get the main color
		goalColor.material.SetColor("Color", (Color.Lerp(Color.cyan,Color.black, lerp)));		//set the main color

		goalColor.material.shader = Shader.Find("_Specular"); 									//get the specular shader
		goalColor.material.SetColor("SpecColor",(Color.Lerp(Color.clear,Color.cyan, lerp)));	//set the specular shader

		goalColor.material.shader = Shader.Find(" _EmissionColor"); 							//get emissive shader
		goalColor.material.SetColor("EmissColor", (Color.Lerp(Color.clear,Color.cyan, lerp)));	//set the emissive shader
	
	}//end change material color

	void SwapBallObject(){

//		float ball_x;
//		float ball_y;
//		float ball_z;

	//	GameObject.FindGameObjectWithTag("Ball") = currentBall;
		if (currentBall.name == firstBallType.name) {
			InstantiateNewBall (secondBallType); 

		}//END SWAP BALL

		if (currentBall.name == secondBallType.name){	
			InstantiateNewBall (firstBallType);
		}
				
//		swappedBallSpawnPoint = new Vector3 (ball_x, ball_y, ball_z);
//
//		currentBall.transform.position.x = ball_x;
//		currentBall.transform.position.y = ball_y;
//		currentBall.transform.position.z = ball_z;

	
	}//END SWAP BALL OBJECT FUNCTION

	void InstantiateNewBall (GameObject newBallType){
		GameObject temp = Instantiate(newBallType, currentBall.transform);	
		Destroy (currentBall.gameObject);
		currentBall = temp;
		Debug.Log ("Ball Swapped!" + temp.name);
		
	}

}// END SCRIPT "GOALSCRIPT"

