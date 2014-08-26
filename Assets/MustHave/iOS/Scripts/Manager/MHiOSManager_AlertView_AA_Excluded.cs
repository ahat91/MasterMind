using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial class MHiOSManager : Singleton<MHiOSManager> {
	[DllImport("__Internal")]
    private static extern int _textFieldAtIndex(int tag, int textFieldIndex);
	public MHTextField textFieldAtIndex(int tag, int textFieldIndex)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			int fieldTag = _textFieldAtIndex(tag, textFieldIndex);
			
			return GetObjectByUniqueTag(fieldTag) as MHTextField;
		}
		else
			return new MHTextField();
	}
}
