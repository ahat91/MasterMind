using UnityEngine;
using System.Collections;

public class MHRefreshControl : MHControl {
	#region functions
	public MHRefreshControl(){}
	
	public MHRefreshControl(bool autoInitialize)
	{
		if(Application.isPlaying && autoInitialize)
			init();
	}
	
	public MHRefreshControl(Rect aRect)
	{
		if(Application.isPlaying)
			initWithFrame(aRect);
	}
	
	new public MHRefreshControl init()
	{
		return MHiOSManager.Instance.init_refreshcontrol(tag);
	}
	
	new public MHRefreshControl initWithFrame(Rect aRect)
	{
		return MHiOSManager.Instance.initWithFrame_refreshcontrol(tag, aRect);
	}
	
	public Color tintColor {
		get {
			return MHiOSManager.Instance.tintColor(tag);
		} set {
			MHiOSManager.Instance.tintColor(tag, value);
		}
	}
	
	public void beginRefreshing()
	{
		MHiOSManager.Instance.beginRefreshing(tag);
	}
	
	public void endRefreshing()
	{
		MHiOSManager.Instance.endRefreshing(tag);
	}
	
	public bool refreshing {
		get {
			return MHiOSManager.Instance.refreshing(tag);
		}
	}
	#endregion
}
