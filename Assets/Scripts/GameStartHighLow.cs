using UnityEngine;
using System.Collections;

public class GameStartHighLow : MonoBehaviour {

	public GameObject howToPre;
	void OnClick()
	{
		
		CreatorHighLow.prevNum = 0;
		CreatorHighLow.currentNum = 0;

		Destroy (howToPre);
		
	}
}
