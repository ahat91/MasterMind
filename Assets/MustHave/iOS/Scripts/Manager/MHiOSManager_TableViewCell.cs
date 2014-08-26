using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial class MHiOSManager : Singleton<MHiOSManager> {
	#region refresh_control
	[DllImport("__Internal")]
    private static extern int _init_tableviewcell(int tag);
	public MHTableViewCell init_tableviewcell(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_init_tableviewcell(tag)) as MHTableViewCell;
		}
		else
			return new MHTableViewCell();
	}
	
	[DllImport("__Internal")]
    private static extern int _initWithFrame_tableviewcell(int tag, string aRect);
	public MHTableViewCell initWithFrame_tableviewcell(int tag, Rect aRect)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string rectJsonString = MHTools.ConvertRectToJSON(aRect);
			
			return GetObjectByUniqueTag(_initWithFrame_tableviewcell(tag, rectJsonString)) as MHTableViewCell;
		}
		else
			return new MHTableViewCell();
	}
	
	[DllImport("__Internal")]
    private static extern int _initWithStyleReuseIdentifier_tableviewcell(int tag, int style, string reuseIdentifier);
	public MHTableViewCell initWithStyleReuseIdentifier_tableviewcell(int tag, MHTableViewCellStyle style, string reuseIdentifier)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_initWithStyleReuseIdentifier_tableviewcell(tag, (int)style, reuseIdentifier)) as MHTableViewCell;
		}
		else
			return new MHTableViewCell();
	}
	
	[DllImport("__Internal")]
    private static extern int _selectedBackgroundView(int tag);
	public MHView selectedBackgroundView(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_selectedBackgroundView(tag)) as MHView;
		}
		else
			return new MHView();
	}
	
	[DllImport("__Internal")]
    private static extern void _selectedBackgroundView_set(int tag, int view);
	public void selectedBackgroundView(int tag, MHView view)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_selectedBackgroundView_set(tag, view.tag);
		}
	}
	
	[DllImport("__Internal")]
    private static extern int _multipleSelectionBackgroundView(int tag);
	public MHView multipleSelectionBackgroundView(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_multipleSelectionBackgroundView(tag)) as MHView;
		}
		else
			return new MHView();
	}
	
	[DllImport("__Internal")]
    private static extern void _multipleSelectionBackgroundView_set(int tag, int view);
	public void multipleSelectionBackgroundView(int tag, MHView view)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_multipleSelectionBackgroundView_set(tag, view.tag);
		}
	}
	
	[DllImport("__Internal")]
    private static extern int _accessoryType(int tag);
	public MHTableViewCellAccessoryType accessoryType(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return (MHTableViewCellAccessoryType)_accessoryType(tag);
		}
		else
			return MHTableViewCellAccessoryType.MHTableViewCellAccessoryNone;
	}
	
	[DllImport("__Internal")]
    private static extern void _accessoryType_set(int tag, int type);
	public void accessoryType(int tag, MHTableViewCellAccessoryType type)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_accessoryType_set(tag, (int)type);
		}
	}
	
	[DllImport("__Internal")]
    private static extern int _accessoryView(int tag);
	public MHView accessoryView(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_accessoryView(tag)) as MHView;
		}
		else
			return new MHView();
	}
	
	[DllImport("__Internal")]
    private static extern void _accessoryView_set(int tag, int view);
	public void accessoryView(int tag, MHView view)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_accessoryView_set(tag, view.tag);
		}
	}
	
	[DllImport("__Internal")]
    private static extern int _editingAccessoryType(int tag);
	public MHTableViewCellAccessoryType editingAccessoryType(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return (MHTableViewCellAccessoryType)_editingAccessoryType(tag);
		}
		else
			return MHTableViewCellAccessoryType.MHTableViewCellAccessoryNone;
	}
	
	[DllImport("__Internal")]
    private static extern void _editingAccessoryType_set(int tag, int type);
	public void editingAccessoryType(int tag, MHTableViewCellAccessoryType type)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_editingAccessoryType_set(tag, (int)type);
		}
	}
	
	[DllImport("__Internal")]
    private static extern int _editingAccessoryView(int tag);
	public MHView editingAccessoryView(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_editingAccessoryView(tag)) as MHView;
		}
		else
			return new MHView();
	}
	
	[DllImport("__Internal")]
    private static extern void _editingAccessoryView_set(int tag, int view);
	public void editingAccessoryView(int tag, MHView view)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_editingAccessoryView_set(tag, view.tag);
		}
	}
	
	[DllImport("__Internal")]
    private static extern int _selectionStyle(int tag);
	public MHTableViewCellSelectionStyle selectionStyle(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return (MHTableViewCellSelectionStyle)_selectionStyle(tag);
		}
		else
			return MHTableViewCellSelectionStyle.MHTableViewCellSelectionStyleDefault;
	}
	
	[DllImport("__Internal")]
    private static extern void _selectionStyle_set(int tag, int style);
	public void selectionStyle(int tag, MHTableViewCellSelectionStyle style)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_selectionStyle_set(tag, (int)style);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _setSelected(int tag, bool selected, bool animated);
	public void setSelected(int tag, bool selected, bool animated)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_setSelected(tag, selected, animated);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _setHighlighted(int tag, bool highlighted, bool animated);
	public void setHighlighted(int tag, bool highlighted, bool animated)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_setHighlighted(tag, highlighted, animated);
		}
	}
	
	[DllImport("__Internal")]
    private static extern int _editingStyle(int tag);
	public MHTableViewCellEditingStyle editingStyle(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return (MHTableViewCellEditingStyle)_editingStyle(tag);
		}
		else
			return MHTableViewCellEditingStyle.MHTableViewCellEditingStyleNone;
	}
	
	[DllImport("__Internal")]
    private static extern bool _showingDeleteConfirmation(int tag);
	public bool showingDeleteConfirmation(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _showingDeleteConfirmation(tag);
		}
		else
			return false;
	}
	
	[DllImport("__Internal")]
    private static extern bool _showsReorderControl(int tag);
	public bool showsReorderControl(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _showsReorderControl(tag);
		}
		else
			return false;
	}
	
	[DllImport("__Internal")]
    private static extern void _showsReorderControl_set(int tag, bool shows);
	public void showsReorderControl(int tag, bool shows)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_showsReorderControl_set(tag, shows);
		}
	}
	
	[DllImport("__Internal")]
    private static extern int _indentationLevel(int tag);
	public int indentationLevel(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _indentationLevel(tag);
		}
		else
			return 0;
	}
	
	[DllImport("__Internal")]
    private static extern void _indentationLevel_set(int tag, int level);
	public void indentationLevel(int tag, int level)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_indentationLevel_set(tag, level);
		}
	}
	
	[DllImport("__Internal")]
    private static extern float _indentationWidth(int tag);
	public float indentationWidth(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _indentationWidth(tag);
		}
		else
			return 0f;
	}
	
	[DllImport("__Internal")]
    private static extern void _indentationWidth_set(int tag, float width);
	public void indentationWidth(int tag, float width)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_indentationWidth_set(tag, width);
		}
	}
	
	[DllImport("__Internal")]
    private static extern bool _shouldIndentWhileEditing(int tag);
	public bool shouldIndentWhileEditing(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _shouldIndentWhileEditing(tag);
		}
		else
			return false;
	}
	
	[DllImport("__Internal")]
    private static extern void _shouldIndentWhileEditing_set(int tag, bool should);
	public void shouldIndentWhileEditing(int tag, bool should)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_shouldIndentWhileEditing_set(tag, should);
		}
	}
	
	[DllImport("__Internal")]
    private static extern string _separatorInset(int tag);
	public Vector4 separatorInset(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string vectorJsonString = _separatorInset(tag);
			
			return MHTools.ConvertJSONToVector4(vectorJsonString);
		}
		else
			return Vector4.zero;
	}
	
	[DllImport("__Internal")]
    private static extern void _separatorInset_set(int tag, string inset);
	public void separatorInset(int tag, Vector4 inset)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string vectorJsonString = MHTools.ConvertVector4ToJSON(inset);
			
			_separatorInset_set(tag, vectorJsonString);
		}
	}
	#endregion
	
	#region state transitions
	void willTransitionToState(string jsonString)
	{
		int tag;
		MHTableViewCellStateMask state;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			state = (MHTableViewCellStateMask)Convert.ToInt32(Convert.ToInt32(result["state"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableViewCell)
				(obj as MHTableViewCell)._willTransitionToState(state);
		}
	}
	
	void didTransitionToState(string jsonString)
	{
		int tag;
		MHTableViewCellStateMask state;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			state = (MHTableViewCellStateMask)Convert.ToInt32(Convert.ToInt32(result["state"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableViewCell)
				(obj as MHTableViewCell)._didTransitionToState(state);
		}
	}
	#endregion
}
