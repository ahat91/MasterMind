using UnityEngine;
using System;
using System.Collections;

public class MHTableViewHeaderFooterView : MHView {
	#region functions
	public MHTableViewHeaderFooterView(){}
	
	public MHTableViewHeaderFooterView(bool autoInitialize)
	{
		if(Application.isPlaying && autoInitialize)
			init();
	}
	
	public MHTableViewHeaderFooterView(Rect aRect)
	{
		if(Application.isPlaying)
			initWithFrame(aRect);
	}
	
	public MHTableViewHeaderFooterView(string reuseIdentifier)
	{
		if(Application.isPlaying)
			initWithReuseIdentifier(reuseIdentifier);
	}
	
	new public MHTableViewHeaderFooterView init()
	{
		return MHiOSManager.Instance.init_tableviewheaderfooterview(tag);
	}
	
	new public MHTableViewHeaderFooterView initWithFrame(Rect aRect)
	{
		return MHiOSManager.Instance.initWithFrame_tableviewheaderfooterview(tag, aRect);
	}
	
	public MHTableViewHeaderFooterView initWithReuseIdentifier(string reuseIdentifier)
	{
		return MHiOSManager.Instance.initWithReuseIdentifier_tableviewheaderfooterview(tag, reuseIdentifier);
	}
	
	public MHView contentView {
		get {
			return MHiOSManager.Instance.contentView(tag);
		}
	}
	
	public MHView backgroundView {
		get {
			return MHiOSManager.Instance.backgroundView(tag);
		} set {
			MHiOSManager.Instance.backgroundView(tag, value);
		}
	}
	
	public string reuseIdentifier {
		get {
			return MHiOSManager.Instance.reuseIdentifier(tag);
		}
	}
	
	public void prepareForReuse()
	{
		MHiOSManager.Instance.prepareForReuse(tag);
	}
	
	public MHLabel textLabel {
		get {
			return MHiOSManager.Instance.textLabel(tag);
		}
	}
	
	public MHLabel detailTextLabel {
		get {
			return MHiOSManager.Instance.detailTextLabel(tag);
		}
	}
	
	public Color tintColor {
		get {
			return MHiOSManager.Instance.tintColor(tag);
		} set {
			MHiOSManager.Instance.tintColor(tag, value);
		}
	}
	#endregion
}
