using UnityEngine;
using System.Collections;

public class theWrongSelection : MonoBehaviour {

	public CreatorC target;
	private int brainScore;
	public GameObject xPre;
	public GameObject wrongX;


	void OnClick()
	{

		//lets put a little checkmark to initiate that they were wrong
		wrongX = Instantiate(xPre, new Vector2(-0.7143013F, 528.4414F), transform.rotation) as GameObject;
		TweenAlpha tweenEnter = TweenAlpha.Begin (wrongX, 1.5f, 1f);
		tweenEnter.from = 0f; 
		tweenEnter.to = 1f;
		TweenAlpha tweenExit = TweenAlpha.Begin (wrongX, 1f, 0f);
		tweenExit.from = 1f; 
		tweenExit.to = 0f;

		brainScore = PlayerPrefs.GetInt("S2brainScore");
		Debug.Log("Wrong!");
		Destroy(CreatorC.instanceRight);
		Destroy(CreatorC.instanceWrong);
		brainScore -= 1;
		PlayerPrefs.SetInt("S2brainScore", brainScore);
		Debug.Log(brainScore);
		target.GenerateCubes();

		
		
	}
}
