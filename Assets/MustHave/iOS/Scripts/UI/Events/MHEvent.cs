using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class MHEvent : MHObject {
	#region functions
	public MHEvent(){MHiOSManager.RemoveUniqueTagForObject(tag);}
	
	/// <summary>
	/// PRIVATE CONSTRUCTOR. Syncs an instance of the <see cref="MHEvent"/> class for MHResponder.
	/// </summary>
	public MHEvent(MHTouch[] allTouches, float timestamp, MHEventType type, MHEventType subtype)
	{
		if(Application.isPlaying)
		{
			this.allTouches = allTouches;
			this.timestamp = timestamp;
			this.type = type;
			this.subtype = subtype;
		}
		MHiOSManager.RemoveUniqueTagForObject(tag);
	}

	public MHTouch[] allTouches;
	
	public MHTouch[] touchesForView(MHView view)
	{
		return System.Array.FindAll<MHTouch>(allTouches, delegate(MHTouch obj) {
			return obj.view == view;
		});
	}
	
	public float timestamp;
	
	public MHEventType type;
	
	public MHEventType subtype;
	/*
	public MHTouch[] touchesForGestureRecognizer(MHGestureRecognizer gesture)
	{
		return MHiOSManager.Instance.touchesForGestureRecognizer(tag, gesture);
	}
	*/
	#endregion
}
