using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial class MHiOSManager : Singleton<MHiOSManager> {
	[DllImport("__Internal")]
    private static extern void _showFromToolbar(int tag, int view);
	public void showFromToolbar(int tag, MHToolbar view)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			int viewTag = view.tag;
			
			_showFromToolbar(tag, viewTag);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _showFromBarButtonItem(int tag, int item, bool animated);
	public void showFromBarButtonItem(int tag, MHBarButtonItem item, bool animated)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			int itemTag = item.tag;
			
			_showFromBarButtonItem(tag, itemTag, animated);
		}
	}
}
