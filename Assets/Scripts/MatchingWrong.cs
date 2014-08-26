using UnityEngine;
using System.Collections;

public class MatchingWrong : MonoBehaviour {
	
	public Creator3 targetWrong;
	public GameObject targetCube;
	public Color wrongColor = new Color();


	
	void OnClick()
	{


		TweenColor tweenCol = TweenColor.Begin (targetCube, .25f, wrongColor);

		Creator3.correctNum = 0;
		Creator3.clickNumMatching = 0;
		Creator3.firstMatchingClick = "";
		Creator3.secondMatchingClick = "";
		StartCoroutine(MyMethod());


	}

	IEnumerator MyMethod() {
		yield return new WaitForSeconds(.5F);
		Destroy(Creator3.instanceNum1);
		Destroy(Creator3.instanceNum2);
		Destroy(Creator3.instanceNum3);
		Destroy(Creator3.instanceNum4);
		Destroy(Creator3.instanceNum5);
		Destroy(Creator3.instanceNum6);
		targetWrong.GenerateMath();
	}
}
