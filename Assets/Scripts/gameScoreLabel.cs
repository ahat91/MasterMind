using UnityEngine;
using System.Collections;

public class gameScoreLabel : MonoBehaviour {

	public float myTimer; // this is what will display the time the player has been playing
	public float mySceneTimer = 20.0F; //this will time the scene out to only exist for 20 seconds
	public UILabel timeLabel;
	public string myTimerString; 
	public string currentScene;
	public string loadLevel;
	public int sceneDice;



	//public static Stack theLevels = new Stack();





	void Start (){
		if(StartGameC.levelList.Count ==0)
		{
			StartGameC.levelList.Add("Scene02");
			StartGameC.levelList.Add("Scene03");
			StartGameC.levelList.Add("Scene04");
			StartGameC.levelList.Add("Scene05");
		}
		myTimer = PlayerPrefs.GetFloat ("currentTime");
	}

	// Update is called once per frame
	void Update () {

		//A simple countdown timer for the label
		if(GameObject.Find ("HowTo") == null)
		{
			myTimer -=Time.deltaTime;

			if(myTimer > .1F){
			myTimerString = myTimer.ToString("#,#"); // we have to go from a float to a string
			timeLabel.text = myTimerString;
			}

		

		if(myTimer <= .1F)
		{
			Debug.Log("Game Over");
			Application.LoadLevel("PostData");
		}
		}

		//this will control the scene timer to only play for 20 seconds
		if(mySceneTimer > 0 && GameObject.Find ("HowTo") == null)
		{
			mySceneTimer -=Time.deltaTime;

			if(mySceneTimer <= 0)
			{
				GetScene();
				PlayerPrefs.SetFloat("currentTime", myTimer);

				Application.LoadLevel(loadLevel);
			}
			
		}


	
	}

	void GetScene() 
	{
		currentScene = Application.loadedLevelName;
		
		
			do {

			sceneDice = Random.Range(0,StartGameC.levelList.Count);

			if(sceneDice == 0)
			{
				StartGameC.levelList.Remove("Scene02");
				loadLevel = "Scene02";
			}

			if(sceneDice == 1)
			{
				StartGameC.levelList.Remove("Scene03");
				loadLevel = "Scene03";
			}
			
			if(sceneDice == 2)
			{
				StartGameC.levelList.Remove("Scene04");
				loadLevel = "Scene04";
			}
			if(sceneDice == 3)
			{
				StartGameC.levelList.Remove("Scene05");
				loadLevel = "Scene05";
			}
			
		} while (loadLevel == currentScene);
	}
}
