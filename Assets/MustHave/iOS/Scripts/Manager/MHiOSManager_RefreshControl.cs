using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial class MHiOSManager : Singleton<MHiOSManager> {
	#region refresh_control
	[DllImport("__Internal")]
    private static extern int _init_refreshcontrol(int tag);
	public MHRefreshControl init_refreshcontrol(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_init_refreshcontrol(tag)) as MHRefreshControl;
		}
		else
			return new MHRefreshControl();
	}
	
	[DllImport("__Internal")]
    private static extern int _initWithFrame_refreshcontrol(int tag, string aRect);
	public MHRefreshControl initWithFrame_refreshcontrol(int tag, Rect aRect)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string rectJsonString = MHTools.ConvertRectToJSON(aRect);
			
			return GetObjectByUniqueTag(_initWithFrame_refreshcontrol(tag, rectJsonString)) as MHRefreshControl;
		}
		else
			return new MHRefreshControl();
	}
	
	[DllImport("__Internal")]
    private static extern void _beginRefreshing(int tag);
	public void beginRefreshing(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_beginRefreshing(tag);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _endRefreshing(int tag);
	public void endRefreshing(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_endRefreshing(tag);
		}
	}
	
	[DllImport("__Internal")]
    private static extern bool _refreshing(int tag);
	public bool refreshing(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _refreshing(tag);
		}
		else
			return false;
	}
	#endregion
}
