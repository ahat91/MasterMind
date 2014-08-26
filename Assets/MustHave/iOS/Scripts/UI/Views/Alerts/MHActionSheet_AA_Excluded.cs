using UnityEngine;
using System;
using System.Collections;

public partial class MHActionSheet : MHView {
	public void showFromToolbar(MHToolbar view)
	{
		MHiOSManager.Instance.showFromToolbar(tag, view);
	}
	
	public void showFromBarButtonItem(MHBarButtonItem item, bool animated)
	{
		MHiOSManager.Instance.showFromBarButtonItem(tag, item, animated);
	}
}
