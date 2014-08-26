using UnityEngine;
using System.Collections;

public class CreatorC : MonoBehaviour {
	
	public GameObject thePreRight;
	public GameObject thePreWrong;
	public static bool isCreated;
	public static GameObject instanceRight;
	public static GameObject instanceWrong;
	public int positionDice;

	public Color customRed = new Color(.247F, .043F, .105F);
	public Color customGreen = new Color(.478F, .086F, .192F);
	public Color customBlue = new Color(.811F, .258F, .235F);
	public Color customYellow = new Color(1F, .831F, .384F);
	public Color customPurple = new Color(.506F, .035F, .580F);

	// Update is called once per frame
	void Update () {

		if (GameObject.Find ("HowTo") == null && !isCreated)
			{
			GenerateCubes();
			}
		}

	public UIWidget backgroundRight;
	public UILabel labelRight;
	public UIWidget backgroundWrong;
	public UILabel labelWrong;
	public int colorDiceRight;
	public int colorDiceRand;
	public Color wrongColor;
	public int textDiceRand;
	

	public void GenerateCubes()
	{

		colorDiceRight = Random.Range(0, 5);
		colorDiceRand = Random.Range(0, 5);
		//Debug.Log (colorDice);
		//this will decide the buttons color
		
		switch (colorDiceRand) {
		case 0:
			wrongColor = customRed;
			textDiceRand = Random.Range(0, 4);
			if(textDiceRand == 0)
			{
				labelWrong.text = "Green";
			}
			else if (textDiceRand == 1 )
				labelWrong.text = "Blue";
			else if (textDiceRand == 2)
				labelWrong.text = "Yellow";
			else  
				labelWrong.text = "Purple";
			break;
		case 1:
			wrongColor = customGreen;
			textDiceRand = Random.Range(0, 4);
			if(textDiceRand == 0)
			{
				labelWrong.text = "Red";
			}
			else if (textDiceRand == 1 )
				labelWrong.text = "Blue";
			else if (textDiceRand == 2)
				labelWrong.text = "Yellow";
			else  
				labelWrong.text = "Purple";
			break;
		case 2:
			wrongColor = customBlue;
			textDiceRand = Random.Range(0, 4);
			if(textDiceRand == 0)
			{
				labelWrong.text = "Green";
			}
			else if (textDiceRand == 1 )
				labelWrong.text = "Red";
			else if (textDiceRand == 2)
				labelWrong.text = "Yellow";
			else  
				labelWrong.text = "Purple";
			break;
		case 3:
			wrongColor = customYellow;
			textDiceRand = Random.Range(0, 4);
			if(textDiceRand == 0)
			{
				labelWrong.text = "Green";
			}
			else if (textDiceRand == 1 )
				labelWrong.text = "Red";
			else if (textDiceRand == 2)
				labelWrong.text = "Blue";
			else  
				labelWrong.text = "Purple";
			break;
		case 4:
			wrongColor = customPurple;
			textDiceRand = Random.Range(0, 4);
			if(textDiceRand == 0)
			{
				labelWrong.text = "Green";
			}
			else if (textDiceRand == 1 )
				labelWrong.text = "Red";
			else if (textDiceRand == 2)
				labelWrong.text = "Blue";
			else  
				labelWrong.text = "Yellow";
			break;
		}



		
		switch (colorDiceRight) {
		case 0:
			backgroundRight.color = customRed;
			labelRight.text = "Red";
			backgroundWrong.color = wrongColor;
			
			break;
		case 1:
			backgroundRight.color = customGreen;
			labelRight.text = "Green";
			backgroundWrong.color = wrongColor;
			break;
		case 2:
			backgroundRight.color = customBlue;
			labelRight.text = "Blue";
			backgroundWrong.color = wrongColor;
			break;
		case 3:
			backgroundRight.color = customYellow;
			labelRight.text = "Yellow";
			backgroundWrong.color = wrongColor;
			break;
		case 4:
			backgroundRight.color = customPurple; 
			labelRight.text = "Purple";
			backgroundWrong.color = wrongColor;
			break;
			
		}

		positionDice = Random.Range(0, 2);
		
		if(positionDice == 0)
		{
			instanceRight = Instantiate(thePreRight, new Vector2(transform.position.x, -0.4506091F), transform.rotation) as GameObject;
			instanceWrong = Instantiate(thePreWrong,  new Vector2(transform.position.x, transform.position.y), transform.rotation) as GameObject;
			isCreated = true;
		}
		else
		{
			instanceRight = Instantiate(thePreRight, new Vector2(transform.position.x, transform.position.y), transform.rotation) as GameObject;
			instanceWrong = Instantiate(thePreWrong,  new Vector2(transform.position.x, -0.4506091F), transform.rotation) as GameObject;
			isCreated = true;
		}
		
	}
	
	}

