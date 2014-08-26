using UnityEngine;
using System.Collections;

public class FadeIn : MonoBehaviour {
	
	public GameObject obj;
	public float alphaFrom = 0f;
	public float alphaTo = 0f;
	public float time = 5f;

	void Start () 
	{	
		TweenAlpha tween = TweenAlpha.Begin (obj, time, alphaTo);
		tween.from = alphaFrom; 
		tween.to = alphaTo;
	}
}
