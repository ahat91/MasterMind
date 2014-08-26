using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial class MHiOSManager : Singleton<MHiOSManager> {
	#region responder
	[DllImport("__Internal")]
    private static extern int _nextResponder(int tag);
	public MHResponder nextResponder(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_nextResponder(tag)) as MHResponder;
		}
		else
			return new MHResponder();
	}
	
	[DllImport("__Internal")]
    private static extern bool _isFirstResponder(int tag);
	public bool isFirstResponder(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _isFirstResponder(tag);
		}
		else
			return false;
	}
	
	[DllImport("__Internal")]
    private static extern bool _canBecomeFirstResponder(int tag);
	public bool canBecomeFirstResponder(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _canBecomeFirstResponder(tag);
		}
		else
			return false;
	}
	
	[DllImport("__Internal")]
    private static extern bool _becomeFirstResponder(int tag);
	public bool becomeFirstResponder(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _becomeFirstResponder(tag);
		}
		else
			return false;
	}
	
	[DllImport("__Internal")]
    private static extern bool _canResignFirstResponder(int tag);
	public bool canResignFirstResponder(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _canResignFirstResponder(tag);
		}
		else
			return false;
	}
	
	[DllImport("__Internal")]
    private static extern bool _resignFirstResponder(int tag);
	public bool resignFirstResponder(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _resignFirstResponder(tag);
		}
		else
			return false;
	}
	
	[DllImport("__Internal")]
    private static extern void _reloadInputViews(int tag);
	public void reloadInputViews(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_reloadInputViews(tag);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _refreshResponder(int tag, bool began, bool moved, bool ended, bool cancelled);
	public void refreshResponder(int tag, bool began, bool moved, bool ended, bool cancelled)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_refreshResponder(tag, began, moved, ended, cancelled);
		}
	}
	#endregion
	
	#region delegate
	void touchesBeganWithEvent(string jsonString)
	{
		int tag;
		MHTouch[] touches;
		MHEvent evt;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			MHObject obj = GetObjectByUniqueTag(tag);
			if(!(obj is MHResponder) || !(obj as MHResponder).touchesBeganIsValid)
				return;
			touches = MHTools.ConvertJsonToTouches(Convert.ToString(result["touches"]));
			evt = MHTools.ConvertJsonToEvent(Convert.ToString(result["evt"]));
			
			(obj as MHResponder)._touchesMovedWithEvent(touches, evt);
		}
	}
	
	void touchesMovedWithEvent(string jsonString)
	{
		int tag;
		MHTouch[] touches;
		MHEvent evt;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			MHObject obj = GetObjectByUniqueTag(tag);
			if(!(obj is MHResponder) || !(obj as MHResponder).touchesMovedIsValid)
				return;
			touches = MHTools.ConvertJsonToTouches(Convert.ToString(result["touches"]));
			evt = MHTools.ConvertJsonToEvent(Convert.ToString(result["evt"]));
			
			(obj as MHResponder)._touchesMovedWithEvent(touches, evt);
		}
	}
	
	void touchesEndedWithEvent(string jsonString)
	{
		int tag;
		MHTouch[] touches;
		MHEvent evt;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			MHObject obj = GetObjectByUniqueTag(tag);
			if(!(obj is MHResponder) || !(obj as MHResponder).touchesEndedIsValid)
				return;
			touches = MHTools.ConvertJsonToTouches(Convert.ToString(result["touches"]));
			evt = MHTools.ConvertJsonToEvent(Convert.ToString(result["evt"]));
			
			(obj as MHResponder)._touchesEndedWithEvent(touches, evt);
		}
	}
	
	void touchesCancelledWithEvent(string jsonString)
	{
		int tag;
		MHTouch[] touches;
		MHEvent evt;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			MHObject obj = GetObjectByUniqueTag(tag);
			if(!(obj is MHResponder) || !(obj as MHResponder).touchesCancelledIsValid)
				return;
			touches = MHTools.ConvertJsonToTouches(Convert.ToString(result["touches"]));
			evt = MHTools.ConvertJsonToEvent(Convert.ToString(result["evt"]));
			
			(obj as MHResponder)._touchesCancelledWithEvent(touches, evt);
		}
	}
	
	void motionBeganWithEvent(string jsonString)
	{
		int tag;
		MHEventSubtype motion;
		MHEvent evt;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			motion = (MHEventSubtype)Convert.ToInt32(result["motion"]);
			evt = MHTools.ConvertJsonToEvent(Convert.ToString(result["evt"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHResponder)
				(obj as MHResponder)._motionBeganWithEvent(motion, evt);
		}
	}
	
	void motionEndedWithEvent(string jsonString)
	{
		int tag;
		MHEventSubtype motion;
		MHEvent evt;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			motion = (MHEventSubtype)Convert.ToInt32(result["motion"]);
			evt = MHTools.ConvertJsonToEvent(Convert.ToString(result["evt"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHResponder)
				(obj as MHResponder)._motionEndedWithEvent(motion, evt);
		}
	}
	
	void motionCancelledWithEvent(string jsonString)
	{
		int tag;
		MHEventSubtype motion;
		MHEvent evt;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			motion = (MHEventSubtype)Convert.ToInt32(result["motion"]);
			evt = MHTools.ConvertJsonToEvent(Convert.ToString(result["evt"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHResponder)
				(obj as MHResponder)._motionCancelledWithEvent(motion, evt);
		}
	}
	
	void remoteControlReceivedWithEvent(string jsonString)
	{
		int tag;
		MHEvent evt;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			evt = MHTools.ConvertJsonToEvent(Convert.ToString(result["evt"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHResponder)
				(obj as MHResponder)._remoteControlReceivedWithEvent(evt);
		}
	}
	#endregion
}
