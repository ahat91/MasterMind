using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial class MHiOSManager : Singleton<MHiOSManager> {
	#region tableviewcontroller
	[DllImport("__Internal")]
    private static extern int _init_tableviewcontroller(int tag);
	public MHTableViewController init_tableviewcontroller(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_init_tableviewcontroller(tag)) as MHTableViewController;
		}
		else
			return new MHTableViewController();
	}

	[DllImport("__Internal")]
    private static extern int _initWithStyle_tableviewcontroller(int tag, int style);
	public MHTableViewController initWithStyle_tableviewcontroller(int tag, MHTableViewStyle style)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_initWithStyle_tableviewcontroller(tag, (int)style)) as MHTableViewController;
		}
		else
			return new MHTableViewController();
	}
	
	[DllImport("__Internal")]
    private static extern int _tableView(int tag);
	public MHTableView tableView(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_tableView(tag)) as MHTableView;
		}
		else
			return new MHTableView();
	}
	
	[DllImport("__Internal")]
    private static extern void _tableView_set(int tag, int tView);
	public void tableView(int tag, MHTableView tView)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_tableView_set(tag, tView.tag);
		}
	}
	
	[DllImport("__Internal")]
    private static extern bool _clearsSelectionOnViewWillAppear(int tag);
	public bool clearsSelectionOnViewWillAppear(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _clearsSelectionOnViewWillAppear(tag);
		}
		else
			return false;
	}
	
	[DllImport("__Internal")]
    private static extern void _clearsSelectionOnViewWillAppear_set(int tag, bool clears);
	public void clearsSelectionOnViewWillAppear(int tag, bool clears)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_clearsSelectionOnViewWillAppear_set(tag, clears);
		}
	}
	
	[DllImport("__Internal")]
    private static extern int _refreshControl(int tag);
	public MHRefreshControl refreshControl(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_refreshControl(tag)) as MHRefreshControl;
		}
		else
			return new MHRefreshControl();
	}
	
	[DllImport("__Internal")]
    private static extern void _refreshControl_set(int tag, int rControl);
	public void refreshControl(int tag, MHRefreshControl rControl)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_refreshControl_set(tag, rControl.tag);
		}
	}
	#endregion
}
