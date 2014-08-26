using UnityEngine;
using System.Collections;

public class RandomColorHowTo : MonoBehaviour {

	public UIWidget bgColor;
	public UIWidget buttonColor;
	public Color sanguine = new Color(.247F, .043F, .105F);
	public Color darkRed = new Color(.478F, .086F, .192F);
	public Color darkOrance = new Color(.811F, .258F, .235F);
	public Color oran = new Color(.988F, .490F, .286F);
	public Color yel = new Color(1.0F, .831F, .384F);
	public int btnDice; 
	public int bgDice;

	// Use this for initialization
	void Start () {
		bgColor.color = sanguine;

		btnDice = Random.Range (0, 2);
		if (btnDice == 0) 
		{
			buttonColor.color = yel;
		}
		if (btnDice == 1)
		{
			buttonColor.color = oran;
		}

		bgDice = Random.Range (0, 3);
		if (bgDice == 0) 
		{
			bgColor.color = sanguine;
		}
		if (bgDice == 1)
		{
			bgColor.color = darkRed;
		}
		if (bgDice == 2)
		{
			bgColor.color = darkOrance;
		}
	
	}

}
