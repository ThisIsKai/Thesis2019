using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarLengthScript2D : MonoBehaviour {
	public GameObject barObject;
	public GameObject leftControl;
	public GameObject rightControl;
	List <BoxCollider2D> barBits;

//	public Vector3 barSize;
//

	// Use this for initialization
	void Start () {
		barBits = new List<BoxCollider2D>();
		GetComponentsInChildren<BoxCollider2D>(barBits);
		Debug.Log ("barBits?" + barBits.Count);

	}
	
	// Update is called once per frame
	void Update () {


		//float controlsDistance = Vector3.Distance(leftControl.transform.position, rightControl.transform.position);
	//	Debug.Log ("distance"+  controlsDistance);



		
	}
}
