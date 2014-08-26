using UnityEngine;
using System.Collections;


public class StartGameC : MonoBehaviour {

	public int sceneDice;
	public int brainScore;
	public static ArrayList levelList = new ArrayList();

	void OnClick()
	{
		if(levelList.Count == 0)
		{
		//lets add the levels
		levelList.Add("Scene02");
		levelList.Add("Scene03");
		levelList.Add("Scene04");
		levelList.Add("Scene05");
		}


		//lets set the amount of time
		PlayerPrefs.SetFloat("currentTime", 60.0F);

		//lets get the score and set it to zero so the score resets on each play
		brainScore = PlayerPrefs.GetInt("S2brainScore");
		brainScore = 0;
		PlayerPrefs.SetInt("S2brainScore", brainScore);

		brainScore = PlayerPrefs.GetInt("S3brainScore");
		brainScore = 0;
		PlayerPrefs.SetInt("S3brainScore", brainScore);

		brainScore = PlayerPrefs.GetInt("S4brainScore");
		brainScore = 0;
		PlayerPrefs.SetInt("S4brainScore", brainScore);

		brainScore = PlayerPrefs.GetInt("S5brainScore");
		brainScore = 0;
		PlayerPrefs.SetInt("S5brainScore", brainScore);



		//lets reset some of these variables so the game works properly
		CreatorC.isCreated = false;

		Creator3.isNumCreated = false;

		Creator4.isSignCreated = false;
		Creator4.numZeros = 0;
		Creator4.numOnes = 0;
		Creator4.numTwos = 0;
		Creator4.clickNum = 0;
		Creator4.signIsClicked = true;

		SignSelect.completionAmt = 0 ;
		SignSelect.firstClick = null;
		SignSelect.secondClick = null;

		cubeHighLow.exiting = false;

	


		sceneDice = Random.Range (0, 4); 
		if(sceneDice == 0)
			Application.LoadLevel("Scene02");
		if(sceneDice == 1)
			Application.LoadLevel("Scene03");
		if(sceneDice == 2)
			Application.LoadLevel("Scene04");
		if(sceneDice == 3)
			Application.LoadLevel("Scene05");


	}
}
