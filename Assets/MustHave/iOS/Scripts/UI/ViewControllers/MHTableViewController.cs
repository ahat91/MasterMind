using UnityEngine;
using System;
using System.Collections;

public class MHTableViewController : MHViewController {
	#region functions
	public MHTableViewController(){}
	
	public MHTableViewController(bool autoInitialize)
	{
		if(Application.isPlaying && autoInitialize)
			init();
	}
	
	public MHTableViewController(MHTableViewStyle style)
	{
		if(Application.isPlaying)
			initWithStyle(style);
	}
	
	new public MHTableViewController init()
	{
		return MHiOSManager.Instance.init_tableviewcontroller(tag);
	}
	
	public MHTableViewController initWithStyle(MHTableViewStyle style)
	{
		return MHiOSManager.Instance.initWithStyle_tableviewcontroller(tag, style);
	}
	
	public MHTableView tableView {
		get {
			return MHiOSManager.Instance.tableView(tag);
		} set {
			MHiOSManager.Instance.tableView(tag, value);
		}
	}
	
	public bool clearsSelectionOnViewWillAppear {
		get {
			return MHiOSManager.Instance.clearsSelectionOnViewWillAppear(tag);
		} set {
			MHiOSManager.Instance.clearsSelectionOnViewWillAppear(tag, value);
		}
	}
	
	public MHRefreshControl refreshControl {
		get {
			return MHiOSManager.Instance.refreshControl(tag);
		} set {
			MHiOSManager.Instance.refreshControl(tag, value);
		}
	}
	#endregion
}
