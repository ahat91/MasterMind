using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public partial class MHViewController : MHResponder {
	public static MHViewController unityViewController
	{
		get {
			MHViewController unityvc = new MHViewController();
			unityvc.tag = 0;
			return unityvc;
		}
	}
}
