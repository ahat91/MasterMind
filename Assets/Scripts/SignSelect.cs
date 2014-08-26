using UnityEngine;
using System.Collections;

public class SignSelect : MonoBehaviour {

	public GameObject changeSpriAlph; 
	public bool goAway;
	public static string firstClick;
	public static string secondClick;
	public GameObject test1;
	public GameObject test2;

	public string testCompStr1;
	public UISprite testComp1;
	public string testCompStr2;
	public UISprite testComp2;

	public GameObject btnClick1;
	public GameObject btnClick2;

	public GameObject bg1;
	public GameObject bg2;
	public UISprite bgChange1;
	public UISprite bgChange2;

	public Vector3 sign1Pos;
	public Vector3 sign2Pos;
	public float sign1Sum;
	public float sign2Sum;

	public static int completionAmt;

	public Creator4 Creator4Target;

	public int brainScore;

	public Color darkOrance = new Color(.811F, .258F, .235F);


	void OnClick(){

		brainScore = PlayerPrefs.GetInt("S4brainScore");


		if (Creator4.clickNum == 0) //this is so their first click is not null
		{
		firstClick = this.gameObject.name;
		}


		if (Creator4.signIsClicked == true) //this if statement makes sure user cannot mash buttons
		{
			Creator4.clickNum += 1; // increment clickNum
			Creator4.signIsClicked = false; // setting this to false means they cannot click another button until this is true
			TweenAlpha tween = TweenAlpha.Begin (changeSpriAlph, .5f, 1f);// lets fade in a sign
			tween.from = 0f; 
			tween.to = 1f;
			if (Creator4.clickNum == 1) // if this is their first click
			{
				firstClick = this.gameObject.name; //assign this variable the name of the object they clicked
				StartCoroutine (StartWait1 ()); //this StartCoroutine() is for the yielfForSeconds function
			}
			if (Creator4.clickNum == 2)
			{
				secondClick = this.gameObject.name;

				sign1Pos = GameObject.Find (firstClick).transform.position; // get pos of first click
				sign2Pos = GameObject.Find (secondClick).transform.position; // get pos of second click
				sign1Sum = sign1Pos.y+sign1Pos.x; // make the pos into numbers so we can compare them
				sign2Sum = sign2Pos.y+sign2Pos.x;

				if (sign1Sum != sign2Sum ) // this makes sure they cant click the same position
				{
				
				test1 = GameObject.Find(firstClick+"/Sprite");
				test2 = GameObject.Find(secondClick+"/Sprite");
				StartCoroutine (StartWait2 ());
				}
				else
				{
					Creator4.clickNum = 1;
					secondClick = "";
					Creator4.signIsClicked = true;
				}
			}

		}
		else
		{
			Debug.Log("sign is not clicked yo");
		}
	


	}

	/*void Update()
	{
		if (firstClick == "null") 
		{
			TweenAlpha tween2 = TweenAlpha.Begin (changeSpriAlph, .5f, 0f);
			tween2.from = 1f; 
			tween2.to = 0f;
		}
		}*/

	IEnumerator StartWait1() {
		Creator4.signIsClicked = true; // they can now click again
		yield return new WaitForSeconds (1F); 

	}

	IEnumerator StartWait2() {

		Debug.Log(sign1Sum);
		Debug.Log (sign2Sum);

		bg1 = GameObject.Find(firstClick+"/Background");
		bg2 = GameObject.Find(secondClick+"/Background");

		btnClick1 = GameObject.Find(firstClick);
		btnClick2 = GameObject.Find(secondClick);

		bgChange1 = bg1.GetComponent<UISprite> ();
		bgChange2 = bg2.GetComponent<UISprite> ();
		

		testComp1 = test1.GetComponent<UISprite> ();
		testCompStr1 = testComp1.spriteName;

		testComp2 = test2.GetComponent<UISprite> ();
		testCompStr2 = testComp2.spriteName;

		if (testCompStr1 == testCompStr2 ) //if we have a match and it is correct we should change color of bg and increase player score
		{
	
			brainScore += 1;

			PlayerPrefs.SetInt("S4brainScore", brainScore);

			bgChange1.color = darkOrance;
			bgChange2.color = darkOrance;
			completionAmt = completionAmt+1;

			yield return new WaitForSeconds (.5F);

			TweenAlpha tween0 = TweenAlpha.Begin (GameObject.Find(firstClick), .25f, 0f);
			tween0.from = 1f; 
			tween0.to = 0f;
			TweenAlpha tween1 = TweenAlpha.Begin (GameObject.Find(secondClick), .25f, 0f);
			tween1.from = 1f; 
			tween1.to = 0f;

		} 
		else {// if they selected wrong then we will fade away the images 
			yield return new WaitForSeconds (.5F);
			TweenAlpha tween2 = TweenAlpha.Begin (test1, .25f, 0f);
			tween2.from = 1f; 
			tween2.to = 0f;
			TweenAlpha tween3 = TweenAlpha.Begin (test2, .25f, 0f);
			tween3.from = 1f; 
			tween3.to = 0f;
		}
		Creator4.clickNum = 0;
		Creator4.signIsClicked = true;
		Debug.Log(completionAmt);

		if (completionAmt == 3 ){
			completionAmt = 0;
			firstClick = "";
			secondClick = "";
			//yield return new WaitForSeconds (1F);
			EndSignGame();
		}
		
	}

	public void EndSignGame()
	{
		Debug.Log("Destroyed");
		Destroy(Creator4.instanceSign[0]);
		Destroy(Creator4.instanceSign[1]);
		Destroy(Creator4.instanceSign[2]);
		Destroy(Creator4.instanceSign[3]);
		Destroy(Creator4.instanceSign[4]);
		Destroy(Creator4.instanceSign[5]);
		Creator4.numZeros = 0;
		Creator4.numOnes = 0;
		Creator4.numTwos = 0;
		Creator4Target.GenerateSign ();

	}

}
