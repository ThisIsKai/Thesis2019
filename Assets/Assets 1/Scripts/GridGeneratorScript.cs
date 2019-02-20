using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GridGeneratorScript: GridScript {

//----------------------------------------------------------------------

	string[] squareGridString = new string[]{
		
		"B|R|W|W|B|",
		"|3|3|3|2|3",
		"B|W|W|W|R|",
		"|1|2|1|1|3",
		"R|R|B|B|R|",
		"|1|2|1|1|3",
		"R|W|B|R|B|",
		"|3|2|3|3|1",
		"R|B|B|W|R|",
		"|3|1|2|1|3",
		"B|R|W|W|B|",
		"|3|3|3|2|3",
		"B|W|W|W|R|",
		"|1|2|1|1|3",
		"R|R|B|B|R|",

	};//END SQUARE GRID STRING



//----------------------------------------------------------------------



	string[] bumpGridString = new string[]{
		
		"a|h|j|c|k|",
		"|g|k|i|a|f",
		"b|i|g|h|k|",
		"|h|f|e|j|g",
		"g|p|c|h|i|",
		"|c|f|a|h|f",
		"d|g|e|f|g|",
		"|h|d|c|b|k",
		"b|i|a|a|a|",
		"|a|j|k|a|k",
		"|g|c|a|d|f",
		"b|f|h|b|k|",
		"|h|f|a|j|g",
		"g|p|c|h|i|",
		"|c|f|i|b|f",

	};//END BUMP GRID STRING



//----------------------------------------------------------------------


	void Start () {
		squareGridWidth = squareGridString[0].Length;
		squareGridHeight = squareGridString.Length;
		bumpGridWidth = bumpGridString[0].Length;
		bumpGridHeight = bumpGridString.Length;
		if (generateGridOnStart) {
			GetSquareGrid ();
			GetBumpGrid ();
		}//END GENERATE GRID ON START
	}//END START


    //----------------------------------------------------------------------
    // ***************SQUARE*SWITCH****************


    public override GameObject MakeSquareGridObject (int x, int y) {


		char s = squareGridString[y].ToCharArray()[x];
		GameObject squareTileType;

	
		switch(s){ // SQUARE GRID
		case 'W': //White
			squareTileType = squareGridObjectType[0];
			break;
		case 'R': //Red
			squareTileType = squareGridObjectType[1];
			break;
		case 'B': //Black
			squareTileType = squareGridObjectType[2];
			break;

		case '1': //50% White 50% Red
			if (Random.value <= .50f) {									//give it 75% chances of being type 3
				squareTileType = squareGridObjectType[0]; 
			} else {
				squareTileType = squareGridObjectType[1]; 				//and 25% chance of being type 1
			}
			break;
	
		case '2': // 50% Red 50% Black
			if (Random.value >= .50f) {									//give it 75% chances of being type 2
				squareTileType = squareGridObjectType[1]; 
			} else {
				squareTileType = squareGridObjectType[2]; 				//and 25% chance of being type 3
			}
			break;

		case '3':  //50% Black 50% White
			if (Random.value <= .50f) {									//give it 75% chances of being type 3
				squareTileType = squareGridObjectType[0]; 
			} else {
				squareTileType = squareGridObjectType[2]; 				//and 25% chance of being type 1
			}
			break;

		case '-':  //65% Red 35% White
			if (Random.value <= .65f) {									//give it 75% chances of being type 3
				squareTileType = squareGridObjectType[0]; 
			} else {
				squareTileType = squareGridObjectType[0]; 				//and 25% chance of being type 1
			}
			break;


		default:  // // DEFAULT to 75% White 25% Red
			if (Random.value <= .75) { 									// give it 50/50 chances
				squareTileType = squareGridObjectType[0];				//of being ----
			} else {
				squareTileType = squareGridObjectType[1];				//and if not, it's ----
			}
			break;

		}//END SQUARE GRID SWITCH STATEMENT
	
		var toReturn = Instantiate (squareTileType);

		return toReturn;

	}//END GET SQUARE GRID OBJECT



//----------------------------------------------------------------------
   // ***************BUMP*SWITCH****************

	public override GameObject MakeBumpGridObject (int x, int y){


		char b = bumpGridString[y].ToCharArray()[x];
		GameObject bumpTileType;

	
		switch(b){ //BUMP GRID
		case 'a': 
			if (Random.value <= .01f) {										//give it 75% chances
				bumpTileType = bumpGridObjectType[11]; 
			} else {
				bumpTileType = bumpGridObjectType[11];						//and 25% 
			}
			break;
		case 'b': 
			if (Random.value <= .25f) {										//give it 75% chances
				bumpTileType = bumpGridObjectType[2]; 
			} else {
				bumpTileType = bumpGridObjectType[3];						//and 25% 
			}
			break;
		case 'c': 
			if (Random.value <= .25f) {										//give it 75% chances
				bumpTileType = bumpGridObjectType[4]; 
			} else {
				bumpTileType = bumpGridObjectType[0];						//and 25% 
			}
			break;
		case 'd': 
			if (Random.value <= .25f) {										//give it 75% chances
				bumpTileType = bumpGridObjectType[13]; 
			} else {
				bumpTileType = bumpGridObjectType[13];						//and 25% 
			}
			break;
		case 'e': 
			if (Random.value <= .25f) {										//give it 75% chances
				bumpTileType = bumpGridObjectType[3]; 
			} else {
				bumpTileType = bumpGridObjectType[4];						//and 25% 
			}
			break;
		case 'f': 
			if (Random.value <= .25f) {										//give it 75% chances
				bumpTileType = bumpGridObjectType[0]; 
			} else {
				bumpTileType = bumpGridObjectType[1];						//and 25% 
			}
			break;
		case 'g': 
			if (Random.value <= .5f) {										//give it 75% chances
				bumpTileType = bumpGridObjectType[2]; 
			} else {
				bumpTileType = bumpGridObjectType[3];						//and 25% 
			}
			break;
		case 'h': 
			if (Random.value <= .5f) {										//give it 75% chances
				bumpTileType = bumpGridObjectType[4]; 
			} else {
				bumpTileType = bumpGridObjectType[5];						//and 25% 
			}
			break;
		case 'i': 
			if (Random.value <= .5f) {										//give it 75% chances
				bumpTileType = bumpGridObjectType[6]; 
			} else {
				bumpTileType = bumpGridObjectType[7];						//and 25% 
			}
			break;
		case 'j': 
			if (Random.value <= .5f) {										//give it 75% chances
				bumpTileType = bumpGridObjectType[8]; 
			} else {
				bumpTileType = bumpGridObjectType[9];						//and 25% 
			}
			break;
		case 'k': 
			if (Random.value <= .25f) {										//give it 75% chances 
				bumpTileType= bumpGridObjectType[11]; 
			} else {
				bumpTileType = bumpGridObjectType[10];						//and 25% chance 
			}
			break;

		default:  // DEFAULT to ---
			if (Random.value >= .6) { 										// give if 2/3 chances
				bumpTileType = bumpGridObjectType[6];						//of being ----
			} else {
				bumpTileType = bumpGridObjectType[5];						//and if not, it's ----
			}
			break;


		}//END BUMP GRID SWITCH STATEMENT

		var toReturn = Instantiate (bumpTileType);

		return toReturn;

	}//END GET BUMP GRID OBJECT

//----------------------------------------------------------------------

}//END GRID GENERATOR SCRIPT








//COLORED SQUARE GRID
// ***	-	DEFAULT RANDOM 0/1/2
// ***	0 	WHITE MAT 0
// ***	1 	BLACK MAT 1
// ***	2 	RED MAT 2
// ***	
// * 
// * BUMP GRID
// * 
// *  a WHITE RANDOM   3/4/5/6
// *  b WHITE RIGHT 3
// *  c WHITE LEFT 4
// *  d WHITE UP 5
// *  e WHITE DOWN 6
// * 
// * R
// *  f RED RANDOM  7/8/9/10
// *  g RED RIGHT 7
// *  h RED LEFT 8
// *  i RED UP 9
// *  j RED DOWN 10
// * 
// * B
// *  k BLACK RANDOM 11/12/13/14
// *  l BLACK RIGHT 11
// *  m BLACK LEFT 12
// *  m BLACK UP 13
// *  o BLACK DOWN 14
// 