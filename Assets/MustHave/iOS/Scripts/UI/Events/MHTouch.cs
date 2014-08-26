using UnityEngine;
using System.Collections;
using System;

public class MHTouch : MHObject {
	#region functions
	public MHTouch(){MHiOSManager.RemoveUniqueTagForObject(tag);}
	
	/// <summary>
	/// PRIVATE CONSTRUCTOR. Syncs an instance of the <see cref="MHTouch"/> class for MHEvent.
	/// </summary>
	public MHTouch(Vector2 locationInView, Vector2 previousLocationInView, MHView view, int tapCount, float timestamp, MHTouchPhase phase)
	{
		if(Application.isPlaying)
		{
			this.locationInView = locationInView;
			this.previousLocationInView = previousLocationInView;
			this.view = view;
			this.tapCount = tapCount;
			this.timestamp = timestamp;
			this.phase = phase;
		}
		MHiOSManager.RemoveUniqueTagForObject(tag);
	}
	
	public Vector2 locationInView;
	
	public Vector2 previousLocationInView;
	
	public MHView view;
	
	public int tapCount;
	
	public float timestamp;
	
	public MHTouchPhase phase;
	
	/*
	public MHGestureRecognizer[] gestureRecognizers;
	*/
	#endregion
}
