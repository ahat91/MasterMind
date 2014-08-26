using UnityEngine;
using System;
using System.Collections;

public partial class MHAlertView : MHView {
	public MHTextField textFieldAtIndex(int textFieldIndex)
	{
		return MHiOSManager.Instance.textFieldAtIndex(tag, textFieldIndex);
	}
}
