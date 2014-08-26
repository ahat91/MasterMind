using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Creator4 : MonoBehaviour {

	//these three are just for SignSelect
	public static bool signIsClicked = true;
	public static int clickNum;
	public static int correctNum;

	public  int posDice;
	public List<float> arrayOfYPos = new List<float>();
	public List<float> arrayOfXPos = new List<float>();
	public  List<GameObject> signList = new List<GameObject>();
	public List<GameObject> signListRand = new List<GameObject>();
	//public List<float> randomX = new List<float>();
	public float[] randomX;
	public int theNum;
	public GameObject[] pos;

	public static int numZeros;
	public static int numTwos;
	public static int numOnes;

	public int theNumDice;
	public int theSecNumDice;
	public int theThirdNumDice;
	public int theFourthNumDice;
	public int uniqueNum;
	public int[] uniqueRandNums;


	public int numRandXcol1;
	public int numRandXcol2;

	public float randomY1;
	public  float randomY2;
	public  float randomY3;
	public  float randomY1Bot;
	public  float randomY2Bot;
	public  float randomY3Bot;

	public static GameObject[] instanceSign;

	public GameObject thePreSign1;
	public GameObject thePreSign2;
	public GameObject thePreSign3;
	public GameObject thePreSign4;
	public GameObject thePreSign5;
	public GameObject thePreSign6;

	public UIWidget bgAlpha1;



	public int [] nums;

	public List<GameObject> theSigns = new List<GameObject>();

	public static bool isSignCreated;
	

	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("HowTo") == null && !isSignCreated)
		{
			GenerateSign();
		}
	
	}

	public void GenerateSign()
	{
		randomX = new float[6];
		nums = new int[6];
		pos = new GameObject[6];
		instanceSign = new GameObject[6];



		//add 3 random signs
		signListRand.Add (thePreSign1);
		signListRand.Add (thePreSign2); 
		signListRand.Add (thePreSign3);   
		signListRand.Add (thePreSign4);  
		signListRand.Add (thePreSign5);
		signListRand.Add (thePreSign6);

		signList.Add(signListRand[Random.Range(0,2)]);
		signList.Add(signListRand[Random.Range(2,4)]);
		signList.Add(signListRand[Random.Range(4,6)]);

		
		// we need to place those three random signs in 6 random spots

		// the array of nums is going to give me 3 random numbers all different from one another
		nums[0] = Random.Range (0, 3);
		do {
			nums[1] = Random.Range (0, 3);
		} while (nums[1] == nums[0]);
		do {
			nums[2] = Random.Range (0,3);
		} while (nums[2] == nums[0] || nums[2] == nums[1]);


		pos[0] = signList [nums[GetUnique()]];
		pos[1] = signList [nums[GetUnique()]];
		pos[2] = signList [nums[GetUnique()]];
		pos[3] = signList [nums[GetUnique()]];
		pos[4] = signList [nums[GetUnique()]];
		pos[5] = signList [nums[GetUnique()]];

		/*TweenAlpha tween0 = TweenAlpha.Begin (GameObject.Find (pos [0] + "/Background"), .25f, 0f);
		tween0.from = 0f; 
		tween0.to = 0f;*/
	


		instanceSign[0] = Instantiate(pos[0], new Vector2(0.2324344F, -0.4034991F), transform.rotation) as GameObject;
		instanceSign[1] = Instantiate(pos[1], new Vector2(0.2324344F, 0.4254876F), transform.rotation) as GameObject;
		instanceSign[2] = Instantiate(pos[2], new Vector2(0.2324344F, 0.01103461F), transform.rotation) as GameObject;
		instanceSign[3] = Instantiate(pos[3], new Vector2(-0.282172F, -0.4034991F), transform.rotation) as GameObject;
		instanceSign[4] = Instantiate(pos[4], new Vector2(-0.282172F, 0.4254876F), transform.rotation) as GameObject;
		instanceSign[5] = Instantiate(pos[5], new Vector2(-0.282172F, 0.01103461F), transform.rotation) as GameObject;


	
		instanceSign[0].name = "btn1";
		instanceSign[1].name = "btn2";
		instanceSign[2].name = "btn3";
		instanceSign[3].name = "btn4";
		instanceSign[4].name = "btn5";
		instanceSign[5].name = "btn6";

		isSignCreated = true;

	}


public int GetUnique() //craziest ish ever
	{
				theNumDice = Random.Range (0, 3); //will equal 0,1,2
				theSecNumDice = Random.Range (1, 3); // will equal 1 or 2
				theThirdNumDice = Random.Range (0, 2); // will equal 0 or 1
				uniqueRandNums = new int[2];
		uniqueRandNums [0] = 0;
		uniqueRandNums [1] = 2;
				theFourthNumDice = uniqueRandNums[Random.Range (0, 2)]; // will equal 0 or 2

				if (numZeros != 2 && numOnes != 2 && numTwos != 2) {
						Debug.Log ("if1");
						if (theNumDice == 0) {
								numZeros += 1;
								return theNumDice;
						}
						else if (theNumDice == 1) {
								numOnes += 1;
								return theNumDice;
						}
						else if (theNumDice == 2) {
								numTwos += 1;
								return theNumDice;
						}
						else {
				Debug.Log("fd up hurr");
				return 9;
						}
						

				}
				else if (numZeros == 2 && numOnes == 2 && numTwos != 2) {// there are already 2 zeros and ones so lets return 2
						Debug.Log ("if2");
						numTwos += 1;
						return 2;

				}  else if (numOnes == 2 && numTwos == 2 && numZeros != 2) {// there are already 2 ones and twos so lets return 0
						Debug.Log ("if3");
						numZeros += 1;			
						return 0;
				
				}  else if (numZeros == 2 && numTwos == 2 && numOnes != 2) {// there are already 2 zeros and twos so lets return 1
						Debug.Log ("if4");			
						numOnes += 1;
						return 1;
				}  else if (numZeros == 2 && numTwos != 2 && numOnes != 2) {// there are two zeros so we need either a one or a two
						Debug.Log ("if5");
						if (theSecNumDice == 1) {
								numOnes += 1; 
								return theSecNumDice;
						} else { // the dice equals 2
								numTwos += 1;
								return theSecNumDice;
						}
				}  else if (numTwos == 2 && numZeros != 2 && numOnes != 2) {// there are two twos so we need either a one or a zero
						Debug.Log ("if6");
						if (theThirdNumDice == 1) {
								numOnes += 1; 
								return theThirdNumDice;
						} else { // the dice equals 0
								numZeros += 1;
								return theThirdNumDice;
						}
				} else if(numOnes == 2 && numZeros != 2 && numTwos != 2) { // there are two ones so we need either a two or a zero
						Debug.Log ("if7");
						if (theFourthNumDice == 0) {
							numZeros += 1;  
							return theFourthNumDice;
						} else { // the dice equals 2
							numTwos += 1;
							return theFourthNumDice;
						}
				}
				else {
				Debug.Log("Suttin fd up");
				return 7;
			}
	
	
	
}
	



}
