using UnityEngine;
using System.Collections;
using System;

public class MHResponder : MHObject {
	#region functions
	public MHResponder(){}
	
	public MHResponder nextResponder()
	{
		return MHiOSManager.Instance.nextResponder(tag);
	}
	
	public bool isFirstResponder()
	{
		return MHiOSManager.Instance.isFirstResponder(tag);
	}
	
	public bool canBecomeFirstResponder()
	{
		return MHiOSManager.Instance.canBecomeFirstResponder(tag);
	}
	
	public bool becomeFirstResponder()
	{
		return MHiOSManager.Instance.becomeFirstResponder(tag);
	}
	
	public bool canResignFirstResponder()
	{
		return MHiOSManager.Instance.canResignFirstResponder(tag);
	}
	
	public bool resignFirstResponder()
	{
		return MHiOSManager.Instance.resignFirstResponder(tag);
	}
	
	public MHView inputView {
		get {
			return MHiOSManager.Instance.inputView(tag);
		}
	}
   
	public MHView inputAccessoryView {
		get {
			return MHiOSManager.Instance.inputAccessoryView(tag);
		}
	}
	
	public void reloadInputViews()
	{
		MHiOSManager.Instance.reloadInputViews(tag);
	}
	
	/// <summary>
	/// Refreshs the responder's touch events. Use after subscribing or unsubscribing to touch events. This increases performance when touches aren't tracked.
	/// </summary>
	public void refreshResponder()
	{
		MHiOSManager.Instance.refreshResponder(tag, touchesBeganIsValid, touchesMovedIsValid, touchesEndedIsValid, touchesCancelledIsValid);
	}
	#endregion
	
	#region delegate
	public bool touchesBeganIsValid {
		get {
			return touchesBeganWithEvent != null;
		}
	}
	public event Action<MHTouch[], MHEvent> touchesBeganWithEvent;
	public void _touchesBeganWithEvent(MHTouch[] touches, MHEvent evt)
	{
		if(touchesBeganWithEvent != null)
			touchesBeganWithEvent(touches, evt);
	}
	
	public bool touchesMovedIsValid {
		get {
			return touchesMovedWithEvent != null;
		}
	}
	public event Action<MHTouch[], MHEvent> touchesMovedWithEvent;
	public void _touchesMovedWithEvent(MHTouch[] touches, MHEvent evt)
	{
		if(touchesMovedWithEvent != null)
			touchesMovedWithEvent(touches, evt);
	}
	
	public bool touchesEndedIsValid {
		get {
			return touchesEndedWithEvent != null;
		}
	}
	public event Action<MHTouch[], MHEvent> touchesEndedWithEvent;
	public void _touchesEndedWithEvent(MHTouch[] touches, MHEvent evt)
	{
		if(touchesEndedWithEvent != null)
			touchesEndedWithEvent(touches, evt);
	}
	
	public bool touchesCancelledIsValid {
		get {
			return touchesCancelledWithEvent != null;
		}
	}
	public event Action<MHTouch[], MHEvent> touchesCancelledWithEvent;
	public void _touchesCancelledWithEvent(MHTouch[] touches, MHEvent evt)
	{
		if(touchesCancelledWithEvent != null)
			touchesCancelledWithEvent(touches, evt);
	}
	
	public event Action<MHEventSubtype, MHEvent> motionBeganWithEvent;
	public void _motionBeganWithEvent(MHEventSubtype motion, MHEvent evt)
	{
		if(motionBeganWithEvent != null)
			motionBeganWithEvent(motion, evt);
	}
	
	public event Action<MHEventSubtype, MHEvent> motionEndedWithEvent;
	public void _motionEndedWithEvent(MHEventSubtype motion, MHEvent evt)
	{
		if(motionEndedWithEvent != null)
			motionEndedWithEvent(motion, evt);
	}
	
	public event Action<MHEventSubtype, MHEvent> motionCancelledWithEvent;
	public void _motionCancelledWithEvent(MHEventSubtype motion, MHEvent evt)
	{
		if(motionCancelledWithEvent != null)
			motionCancelledWithEvent(motion, evt);
	}
	
	public event Action<MHEvent> remoteControlReceivedWithEvent;
	public void _remoteControlReceivedWithEvent(MHEvent evt)
	{
		if(remoteControlReceivedWithEvent != null)
			remoteControlReceivedWithEvent(evt);
	}
	#endregion
}
