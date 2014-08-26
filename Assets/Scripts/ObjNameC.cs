using UnityEngine;
using System.Collections;

public class ObjNameC : MonoBehaviour {

	public string currentLvl;
	//public string Dname;
	public UIWidget home;
	public UIWidget settings;
	public UIWidget data;
	public int looper = 1;

	// Use this for initialization
	void Update () {
		currentLvl = Application.loadedLevelName;
		//Debug.Log (currentLvl);
	

			if (currentLvl == "Scene01") 
			{
				home.color = new Color (.79F, .27F, .258F);

			}
			if (currentLvl == "Settings") 
			{
				settings.color = new Color (.79F, .27F, .258F);

			}
			if (currentLvl == "Data") {
				data.color = new Color (.79F, .27F, .258F);
				
			}
				
	



	}


}
