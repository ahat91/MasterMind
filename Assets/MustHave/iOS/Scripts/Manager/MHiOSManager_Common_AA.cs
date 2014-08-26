using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial class MHiOSManager : Singleton<MHiOSManager> {
	#region textfield_textview_responder
	[DllImport("__Internal")]
    private static extern int _inputView(int tag);
	public MHView inputView(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			int viewTag = _inputView(tag);
			
			return GetObjectByUniqueTag(viewTag) as MHView;
		}
		else
			return new MHView();
	}
	
	[DllImport("__Internal")]
    private static extern int _inputAccessoryView(int tag);
	public MHView inputAccessoryView(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			int viewTag = _inputAccessoryView(tag);
			
			return GetObjectByUniqueTag(viewTag) as MHView;
		}
		else
			return new MHView();
	}
	#endregion
	
	#region alertview_actionsheet_
	[DllImport("__Internal")]
    private static extern bool _visible(int tag);
	public bool visible(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _visible(tag);
		}
		else
			return false;
	}
	
	[DllImport("__Internal")]
    private static extern int _numberOfButtons(int tag);
	public int numberOfButtons(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _numberOfButtons(tag);
		}
		else
			return 0;
	}
	
	[DllImport("__Internal")]
    private static extern int _cancelButtonIndex(int tag);
	public int cancelButtonIndex(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _cancelButtonIndex(tag);
		}
		else
			return 0;
	}
	
	[DllImport("__Internal")]
    private static extern void _cancelButtonIndex_set(int tag, int index);
	public void cancelButtonIndex(int tag, int index)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_cancelButtonIndex_set(tag, index);
		}
	}
	
	[DllImport("__Internal")]
    private static extern int _firstOtherButtonIndex(int tag);
	public int firstOtherButtonIndex(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _firstOtherButtonIndex(tag);
		}
		else
			return 0;
	}
	#endregion
	
	#region navigationitem_viewcontroller_alertview_
	[DllImport("__Internal")]
    private static extern string _title(int tag);
	public string title(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _title(tag);
		}
		else
			return "";
	}
	
	[DllImport("__Internal")]
    private static extern void _title_set(int tag, string newTitle);
	public void title(int tag, string newTitle)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_title_set(tag, newTitle);
		}
	}
	#endregion
}
