using UnityEngine;
using System.Collections;

public class ButtonLowClick : MonoBehaviour {


	public GameObject correctPre;
	public GameObject wrongPre; 
	public GameObject hiX;

	public int brainScore;
	
	
	void OnClick(){

		if (cubeHighLow.exiting == false)
		{
		
		if(CreatorHighLow.currentNum < CreatorHighLow.prevNum)
		{
			brainScore += 1;
			PlayerPrefs.SetInt("S5brainScore", brainScore);
			Debug.Log("Correct");
			hiX = Instantiate(correctPre, new Vector2(-0.7143013F, 528.4414F), transform.rotation) as GameObject;
		}
		
		else
		{
			Debug.Log("Wrong");
			hiX = Instantiate(wrongPre, new Vector2(-0.7143013F, 528.4414F), transform.rotation) as GameObject;
		}
		
		//lets put a little checkmark to initiate that they were wrong
		TweenAlpha tweenEnter = TweenAlpha.Begin (hiX, 1.5f, 1f);
		tweenEnter.from = 0f; 
		tweenEnter.to = 1f;
		TweenAlpha tweenExit = TweenAlpha.Begin (hiX, 1f, 0f);
		tweenExit.from = 1f; 
		tweenExit.to = 0f;
		

			cubeHighLow.exitVar = true;
			cubeHighLow.exiting = true;
			StartCoroutine (ExitWait ());
			
		}
		
		
		
	}
	
	
	IEnumerator ExitWait(){
		yield return new WaitForSeconds (1F); 
		cubeHighLow.exiting = false;
	}
}
