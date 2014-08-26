using UnityEngine;
using System.Collections;

public class AlterAlpha : MonoBehaviour {
	
	public UIWidget objToAlpha;
	public float theAlpha = 1.0F;
	
	// Use this for initialization
	void Update () {
		
		objToAlpha.alpha = theAlpha;
	}
	
}
