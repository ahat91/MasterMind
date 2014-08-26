using UnityEngine;
using System.Collections;

public class setAlphaStart : MonoBehaviour {

	public UIWidget objToAlpha;
	public float theAlpha =0F;

	// Use this for initialization
	void Start () {
		objToAlpha.alpha = theAlpha;
	}

}
