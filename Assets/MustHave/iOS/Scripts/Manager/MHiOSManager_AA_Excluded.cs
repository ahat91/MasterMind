using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial class MHiOSManager : Singleton<MHiOSManager> {
	//labels and imageviews are automatically created, so this just syncs the tag
	[DllImport("__Internal")]
    private static extern void _syncLabel(int tag, int button);
	public void syncLabel(int tag, MHButton button)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			int buttonTag = button.tag;
			
			_syncLabel(tag, buttonTag);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _syncImageView(int tag, int button);
	public void syncImageView(int tag, MHButton button)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			int buttonTag = button.tag;
			
			_syncImageView(tag, buttonTag);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _syncNavitem(int tag, int viewController);
	public void syncNavitem(int tag, MHViewController viewController)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			int viewTag = viewController.tag;
			
			_syncNavitem(tag, viewTag);
		}
	}
}
