using UnityEngine;
using System.Collections;

public class SleepingMan : MonoBehaviour {

	//public UIWidget talk;
	public GameObject theTalkingPre;
	public GameObject startTalk;

	void OnClick()
	{
		startTalk = Instantiate(theTalkingPre, new Vector2(-0.06495774F, 0.7424343F), transform.rotation) as GameObject;
	}
}
