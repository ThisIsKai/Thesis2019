using UnityEngine;
using System.Collections;

public class GridScript : MonoBehaviour {

//----------------------------------------------------------------------


	public int squareGridWidth;
	public int squareGridHeight;
	public float squareGridSpacing;

	public int bumpGridWidth;
	public int bumpGridHeight;
	public float bumpGridSpacing;
	
	public GameObject[] squareGridObjectType;
	public GameObject[] bumpGridObjectType;

	GameObject[,] squareGridArray;
	GameObject[,] bumpGridArray;


	public bool generateGridOnStart = true;



//----------------------------------------------------------------------


	void Start () {
		if (generateGridOnStart) {
			GetSquareGrid ();
			GetBumpGrid ();
		}//END GENERATE GRID ON START
	}//END START FUNCTION



//----------------------------------------------------------------------


	public virtual GameObject[,] GetSquareGrid(){	// SQUARE GRID 

		if(squareGridArray == null){

			squareGridArray = new GameObject[squareGridWidth, squareGridHeight];

			//Debug.Log (squareGridWidth);

			float offsetX = (squareGridWidth  * -squareGridSpacing)/2f;
			float offsetY = (squareGridHeight * squareGridSpacing)/2f;

			for(int x = 0; x < squareGridWidth; x++){
				for(int y = 0; y < squareGridHeight; y++){
					GameObject quad = MakeSquareGridObject(x,y);
					quad.transform.position = new Vector3
						(offsetX + x * squareGridSpacing, 
					     offsetY - y * squareGridSpacing, 0);

					quad.transform.parent = transform;
					squareGridArray[x, y] = quad;
					

				}//END FOR SQUARE GRID HEIGHT LOOP
			} // END FOR SQUARE GRID WIDTH LOOP
		}//END IF SQUARE GRID ARRAY = NULL

		return squareGridArray;
	
	}//END GAME OBJECT GET SQUARE GRID
		

//----------------------------------------------------------------------



	public virtual GameObject[,] GetBumpGrid(){ // BUMP GRID 

		if(bumpGridArray == null){
			bumpGridArray = new GameObject[bumpGridWidth, bumpGridHeight];

			float offsetX = (bumpGridWidth  * -bumpGridSpacing)/2f;
			float offsetY = (bumpGridHeight * bumpGridSpacing)/ 2f;

			for(int x = 0; x < bumpGridWidth; x++){
				for(int y = 0; y < bumpGridHeight; y++){
					GameObject quad = MakeBumpGridObject(x,y);
					quad.transform.position = new Vector3
						(offsetX + x * bumpGridSpacing, 
						 offsetY - y * bumpGridSpacing, 0);

					quad.transform.parent = transform;

					bumpGridArray[x, y] = quad;

				}//END FOR BUMP GRID HEIGHT LOOP
			}//END FOR BUMP GRID WIDTH LOOP
		}// END IF BUMP GRID ARRAY = NULL

		return bumpGridArray;
	
	} //END GAME OBJECT GET BUMP GRID



//----------------------------------------------------------------------


	public virtual GameObject MakeSquareGridObject(int x, int y) {
		GameObject quad = GameObject.CreatePrimitive(PrimitiveType.Quad);
		return quad;
	}//END GET SQUARE GRID OBJECT


//----------------------------------------------------------------------


	public virtual GameObject MakeBumpGridObject(int x, int y) {
		GameObject quad = GameObject.CreatePrimitive(PrimitiveType.Quad);
		return quad;
	}//END GET BUMP GRID OBJECT


//----------------------------------------------------------------------

}//END GRID SCRIPT 
