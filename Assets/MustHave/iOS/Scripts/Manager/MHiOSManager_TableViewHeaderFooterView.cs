using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;

public partial class MHiOSManager : Singleton<MHiOSManager> {
	#region tableviewheaderfooterview
	[DllImport("__Internal")]
    private static extern int _init_tableviewheaderfooterview(int tag);
	public MHTableViewHeaderFooterView init_tableviewheaderfooterview(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_init_tableviewheaderfooterview(tag)) as MHTableViewHeaderFooterView;
		}
		else
			return new MHTableViewHeaderFooterView();
	}
	
	[DllImport("__Internal")]
    private static extern int _initWithFrame_tableviewheaderfooterview(int tag, string aRect);
	public MHTableViewHeaderFooterView initWithFrame_tableviewheaderfooterview(int tag, Rect aRect)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string rectJsonString = MHTools.ConvertRectToJSON(aRect);
			
			return GetObjectByUniqueTag(_initWithFrame_tableviewheaderfooterview(tag, rectJsonString)) as MHTableViewHeaderFooterView;
		}
		else
			return new MHTableViewHeaderFooterView();
	}
	
	[DllImport("__Internal")]
    private static extern int _initWithReuseIdentifier_tableviewheaderfooterview(int tag, string reuseIdentifier);
	public MHTableViewHeaderFooterView initWithReuseIdentifier_tableviewheaderfooterview(int tag, string reuseIdentifier)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_initWithReuseIdentifier_tableviewheaderfooterview(tag, reuseIdentifier)) as MHTableViewHeaderFooterView;
		}
		else
			return new MHTableViewHeaderFooterView();
	}
	#endregion
}
