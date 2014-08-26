using UnityEngine;
using System.Collections;

public class setAlpha : MonoBehaviour {

	public UIWidget objToAlpha;
	public float theAlpha =.5F;

	// Use this for initialization
	void Update () {
	
		objToAlpha.alpha = theAlpha;
	}

}
