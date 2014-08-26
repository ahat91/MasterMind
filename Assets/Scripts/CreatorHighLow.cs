using UnityEngine;
using System.Collections;

public class CreatorHighLow : MonoBehaviour {

	public GameObject thePre;
	public GameObject instanceHighLow;

	public bool isHighLowCreated = false;

	public GameObject instanceHighFind; 
	public GameObject instanceLowFind;
	
	public GameObject instanceHigh; 
	public GameObject instanceLow;

	public static int currentNum = 0;
	public static int prevNum = 100;



	void Update ()
	{
		if (GameObject.Find ("HowTo") == null && !isHighLowCreated)
		{
			FirstGenerateHighLow();
			//GenerateHighLowButtons();

		}
	}



	public void GenerateHighLow() {


		instanceHighLow = Instantiate(thePre, new Vector2(transform.position.x, transform.position.y), transform.rotation) as GameObject;



	}

	public void FirstGenerateHighLow() {
		
		
		instanceHighLow = Instantiate(thePre, new Vector2(transform.position.x, transform.position.y), transform.rotation) as GameObject;
		StartCoroutine (WaitFirst ());

		
		
	}



	public void GenerateHighLowButtons(){
		instanceHigh = Instantiate(instanceHighFind, new Vector2(transform.position.x, transform.position.y), transform.rotation) as GameObject;
		instanceLow = Instantiate(instanceLowFind, new Vector2(transform.position.x , transform.position.y), transform.rotation) as GameObject;
		isHighLowCreated = true;

	}
	
	IEnumerator WaitFirst(){
		isHighLowCreated = true;
		yield return new WaitForSeconds (1.3F); 
		instanceHigh = Instantiate(instanceHighFind, new Vector2(transform.position.x, transform.position.y), transform.rotation) as GameObject;
		instanceLow = Instantiate(instanceLowFind, new Vector2(transform.position.x , transform.position.y), transform.rotation) as GameObject;


		cubeHighLow.exitVar = true;
	}


}
