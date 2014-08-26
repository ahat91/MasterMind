using UnityEngine;
using System.Collections;

public class theCorrectSelection : MonoBehaviour {

	public CreatorC target;
	private int brainScore;
	public GameObject checkPre;
	public GameObject correctCheck;


	void OnClick()
	{
		//lets put a little checkmark to initiate that they were correct
		correctCheck = Instantiate(checkPre, new Vector2(-0.7143013F, 528.4414F), transform.rotation) as GameObject;
		TweenAlpha tweenEnter = TweenAlpha.Begin (correctCheck, 1.5f, 1f);
		tweenEnter.from = 0f; 
		tweenEnter.to = 1f;
		TweenAlpha tweenExit = TweenAlpha.Begin (correctCheck, 1f, 0f);
		tweenExit.from = 1f; 
		tweenExit.to = 0f;
		
		brainScore = PlayerPrefs.GetInt("S2brainScore");
		Debug.Log("Correct!");
		Destroy(CreatorC.instanceRight);
		Destroy(CreatorC.instanceWrong);
		brainScore += 1;
		PlayerPrefs.SetInt("S2brainScore", brainScore);
		Debug.Log(brainScore);
		target.GenerateCubes();
		
		
	}
}
