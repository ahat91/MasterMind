using UnityEngine;
using System.Collections;

public class cubeHighLow : MonoBehaviour {
	
	public static bool exitVar = false;
	public static bool exiting;
	public UILabel labelNum; 
	public int numDice;
	public CreatorHighLow scriptINeed;
	
	
	void Start () {


		do
		{
			numDice = Random.Range (0, 100);
		}
		while (numDice == CreatorHighLow.currentNum);

		CreatorHighLow.prevNum = CreatorHighLow.currentNum;

		labelNum.text = numDice.ToString();

		CreatorHighLow.currentNum = numDice;

		animation.Play("cubeSlide3");
		scriptINeed = GameObject.Find("CubeCreatorHighLow").GetComponent<CreatorHighLow>();
		
	}
	
	void Update(){
		if (exitVar == true) 
		{

			animation.Play ("cubeSlideExit");
			exitVar = false;
			StartCoroutine (StartWaitHighLow ());

			
			
		}
		
	}

	IEnumerator StartWaitHighLow(){
		yield return new WaitForSeconds (.5F); 
		Destroy(gameObject);
		scriptINeed.GenerateHighLow();
	}

	
	

}
