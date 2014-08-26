using UnityEngine;
using System.Collections;

public class MatchingCorrect : MonoBehaviour {
	
	public Creator3 target;
	public GameObject targetCube;
	public Color correctColor = new Color();

	public Vector3 sign1Pos;
	public Vector3 sign2Pos;

	public int brainScore;

	 

	
	void OnClick()
	{
	
		brainScore = PlayerPrefs.GetInt("S3brainScore");

		TweenColor tweenCol = TweenColor.Begin (targetCube, .25f, correctColor);
		
		if (Creator3.clickNumMatching == 0)
		{
			Creator3.firstMatchingClick = this.gameObject.name;
			sign1Pos = GameObject.Find (Creator3.firstMatchingClick).transform.position; // get pos of first click button
			
			Creator3.clickNumMatching += 1;
			Creator3.correctNum += 1;
		}
		if (Creator3.clickNumMatching == 1)
		{
			Creator3.secondMatchingClick = this.gameObject.name;
			sign2Pos = GameObject.Find (Creator3.secondMatchingClick).transform.position; // get pos of second click button
			if (sign1Pos != sign2Pos){
				Creator3.correctNum += 1;
			}
			else
			{
				Creator3.secondMatchingClick = "";
				sign2Pos = Vector3.zero;
			}
		
		
		if (Creator3.correctNum == 2)//if they hit two right
		{
		//do this for proper reset

		brainScore += 1;
		PlayerPrefs.SetInt("S3brainScore", brainScore);
		StartCoroutine(MyMethod());
		
		}
		}

	

		
	}

	IEnumerator MyMethod() {
		yield return new WaitForSeconds(.5F);
		Destroy(Creator3.instanceNum1);
		Destroy(Creator3.instanceNum2);
		Destroy(Creator3.instanceNum3);
		Destroy(Creator3.instanceNum4);
		Destroy(Creator3.instanceNum5);
		Destroy(Creator3.instanceNum6);
		Creator3.correctNum = 0;
		Creator3.clickNumMatching = 0;
		Creator3.firstMatchingClick = "";
		Creator3.secondMatchingClick = "";
		target.GenerateMath();
	}
}
