using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Creator3 : MonoBehaviour {

	public static int correctNum;
	public static string firstMatchingClick;
	public static string secondMatchingClick;
	public static int clickNumMatching;

	public static GameObject instanceNum1;
	public static GameObject instanceNum2;
	public static GameObject instanceNum3;
	public static GameObject instanceNum4;
	public static GameObject instanceNum5;
	public static GameObject instanceNum6;

	public GameObject thePreNum1;
	public GameObject thePreNum2;
	public GameObject thePreNum3;
	public GameObject thePreNum4;
	public GameObject thePreNum5;
	public GameObject thePreNum6;

	public GameObject pos1;
	public GameObject pos2;
	public GameObject pos3;
	public GameObject pos4;
	public GameObject pos5;
	public GameObject pos6;

	public List<GameObject> iList = new List<GameObject>();
	



	public UILabel thePreNumText1;
	public UILabel thePreNumText2;
	public UILabel thePreNumText3;
	public UILabel thePreNumText4;
	public UILabel thePreNumText5;
	public UILabel thePreNumText6;

	public int num1;
	public int num2;
	public int num3;
	public int num4;
	public int num5;
	public int num6;

	public static bool isNumCreated;

	public int randDice;
	public string randDiceText;
	public int[] myNumbers = new int[6]; 
	public int[] choices = new int[10];
	public int firstChoice;
	public int secondChoice;
	public int thirdChoice;
	public int fourthChoice;
	public int correctChoice;

	void Start (){
		correctNum = 0;
		clickNumMatching = 0;
		firstMatchingClick = "";
		secondMatchingClick = "";
	}
	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("HowTo") == null && !isNumCreated)
		{
			GenerateMath();
		}
	
	}

	public void GenerateMath()
	{
		isNumCreated = true;

	
		firstChoice = Random.Range(1,10);
		choices [0] = firstChoice;
		do {
			secondChoice = Random.Range (1, 10);
		} while (secondChoice == firstChoice);
		choices [1] = secondChoice;
		do {
			thirdChoice = Random.Range (1, 10);
		} while (thirdChoice == firstChoice || thirdChoice == secondChoice);
		choices [2] = thirdChoice;
		do {
			fourthChoice = Random.Range (1, 10);
		} while (fourthChoice == firstChoice || fourthChoice == secondChoice || fourthChoice == thirdChoice);
		choices [3] = fourthChoice;
		do {
			correctChoice = Random.Range (1, 10);
		} while (correctChoice == firstChoice || correctChoice == secondChoice || correctChoice == thirdChoice || correctChoice == fourthChoice);
		choices [4] = correctChoice;
		choices [5] = correctChoice;




		thePreNumText1.text = choices[0].ToString("#");
		thePreNumText2.text = choices[1].ToString("#");
		thePreNumText3.text = choices[2].ToString("#");
		thePreNumText4.text = choices[3].ToString("#");
		thePreNumText5.text = choices[4].ToString("#");
		thePreNumText6.text = choices[5].ToString("#");

		iList.Add(thePreNum1);
		iList.Add(thePreNum2);
		iList.Add(thePreNum3);
		iList.Add(thePreNum4);
		iList.Add(thePreNum5);
		iList.Add(thePreNum6);

		num1 = Random.Range (0, 6);
		do {
			num2 = Random.Range (0, 6);
		} while (num2 == num1);
		do {
			num3 = Random.Range (0, 6);
		} while (num3 == num1 || num3 == num2);
		do {
			num4 = Random.Range (0, 6);
		} while (num4 == num1 || num4 == num2 || num4 == num3);
		do {
			num5 = Random.Range (0, 6);
		} while (num5 == num1 || num5 == num2 || num5 == num3 || num5 == num4);
		do {
			num6 = Random.Range (0, 6);
		} while (num6 == num1 || num6 == num2 || num6 == num3 || num6 == num4 || num6 == num5);


		pos1 = iList [num1];
		pos2 = iList [num2];
		pos3 = iList [num3];
		pos4 = iList [num4];
		pos5 = iList [num5];
		pos6 = iList [num6];


		instanceNum1 = Instantiate(pos1, new Vector2(-0.282172F, -0.1616472F), transform.rotation) as GameObject;
		instanceNum2 = Instantiate(pos2, new Vector2(-0.282172F, 0.2528058F), transform.rotation) as GameObject;
		instanceNum3 = Instantiate(pos3, new Vector2(-0.282172F, -0.5761809F), transform.rotation) as GameObject;
		instanceNum4 = Instantiate(pos4, new Vector2(0.2324344F, -0.1616472F), transform.rotation) as GameObject;
		instanceNum5 = Instantiate(pos5, new Vector2(0.2324344F, 0.2528058F), transform.rotation) as GameObject;
		instanceNum6 = Instantiate(pos6, new Vector2(0.2324344F, -0.5761809F), transform.rotation) as GameObject;



	}



}
