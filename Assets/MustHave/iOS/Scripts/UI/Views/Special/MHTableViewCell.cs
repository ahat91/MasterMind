using UnityEngine;
using System;
using System.Collections;

public class MHTableViewCell : MHView {
	#region functions
	public MHTableViewCell(){}
	
	public MHTableViewCell(bool autoInitialize)
	{
		if(Application.isPlaying && autoInitialize)
			init();
	}
	
	public MHTableViewCell(Rect aRect)
	{
		if(Application.isPlaying)
			initWithFrame(aRect);
	}
	
	public MHTableViewCell(MHTableViewCellStyle style, string reuseIdentifier)
	{
		if(Application.isPlaying)
			initWithStyleReuseIdentifier(style, reuseIdentifier);
	}
	
	new public MHTableViewCell init()
	{
		return MHiOSManager.Instance.init_tableviewcell(tag);
	}
	
	new public MHTableViewCell initWithFrame(Rect aRect)
	{
		return MHiOSManager.Instance.initWithFrame_tableviewcell(tag, aRect);
	}
	
	public MHTableViewCell initWithStyleReuseIdentifier(MHTableViewCellStyle style, string reuseIdentifier)
	{
		return MHiOSManager.Instance.initWithStyleReuseIdentifier_tableviewcell(tag, style, reuseIdentifier);
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
	
	public MHImageView imageView {
		get {
			return MHiOSManager.Instance.imageView(tag);
		}
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
	
	public MHView selectedBackgroundView {
		get {
			return MHiOSManager.Instance.selectedBackgroundView(tag);
		} set {
			MHiOSManager.Instance.selectedBackgroundView(tag, value);
		}
	}
	
	public MHView multipleSelectionBackgroundView {
		get {
			return MHiOSManager.Instance.multipleSelectionBackgroundView(tag);
		} set {
			MHiOSManager.Instance.multipleSelectionBackgroundView(tag, value);
		}
	}
	
	public MHTableViewCellAccessoryType accessoryType {
		get {
			return MHiOSManager.Instance.accessoryType(tag);
		} set {
			MHiOSManager.Instance.accessoryType(tag, value);
		}
	}
	
	public MHView accessoryView {
		get {
			return MHiOSManager.Instance.accessoryView(tag);
		} set {
			MHiOSManager.Instance.accessoryView(tag, value);
		}
	}
	
	public MHTableViewCellAccessoryType editingAccessoryType {
		get {
			return MHiOSManager.Instance.editingAccessoryType(tag);
		} set {
			MHiOSManager.Instance.editingAccessoryType(tag, value);
		}
	}
	
	public MHView editingAccessoryView {
		get {
			return MHiOSManager.Instance.editingAccessoryView(tag);
		} set {
			MHiOSManager.Instance.editingAccessoryView(tag, value);
		}
	}
	
	public bool selected {
		get {
			return MHiOSManager.Instance.selected(tag);
		} set {
			MHiOSManager.Instance.selected(tag, value);
		}
	}
	
	public MHTableViewCellSelectionStyle selectionStyle {
		get {
			return MHiOSManager.Instance.selectionStyle(tag);
		} set {
			MHiOSManager.Instance.selectionStyle(tag, value);
		}
	}
	
	public void setSelected(bool selected, bool animated)
	{
		MHiOSManager.Instance.setSelected(tag, selected, animated);
	}
	
	public bool highlighted {
		get {
			return MHiOSManager.Instance.highlighted(tag);
		} set {
			MHiOSManager.Instance.highlighted(tag, value);
		}
	}
	
	public void setHighlighted(bool highlighted, bool animated)
	{
		MHiOSManager.Instance.setHighlighted(tag, highlighted, animated);
	}
	
	public bool editing {
		get {
			return MHiOSManager.Instance.editing(tag);
		} set {
			MHiOSManager.Instance.editing(tag, value);
		}
	}
	
	public void setEditing(bool editing, bool animated)
	{
		MHiOSManager.Instance.setEditing(tag, editing, animated);
	}
	
	public MHTableViewCellEditingStyle editingStyle {
		get {
			return MHiOSManager.Instance.editingStyle(tag);
		}
	}
	
	public bool showingDeleteConfirmation {
		get {
			return MHiOSManager.Instance.showingDeleteConfirmation(tag);
		}
	}
	
	public bool showsReorderControl {
		get {
			return MHiOSManager.Instance.showsReorderControl(tag);
		} set {
			MHiOSManager.Instance.showsReorderControl(tag, value);
		}
	}
	
	public int indentationLevel {
		get {
			return MHiOSManager.Instance.indentationLevel(tag);
		} set {
			MHiOSManager.Instance.indentationLevel(tag, value);
		}
	}
	
	public float indentationWidth {
		get {
			return MHiOSManager.Instance.indentationWidth(tag);
		} set {
			MHiOSManager.Instance.indentationWidth(tag, value);
		}
	}
	
	public bool shouldIndentWhileEditing {
		get {
			return MHiOSManager.Instance.shouldIndentWhileEditing(tag);
		} set {
			MHiOSManager.Instance.shouldIndentWhileEditing(tag, value);
		}
	}
	
	public Vector4 separatorInset {
		get {
			return MHiOSManager.Instance.separatorInset(tag);
		} set {
			MHiOSManager.Instance.separatorInset(tag, value);
		}
	}
	#endregion
	
	#region state transitions
	public event Action<MHTableViewCellStateMask> willTransitionToState;
	public void _willTransitionToState(MHTableViewCellStateMask state)
	{
		if(willTransitionToState != null)
			willTransitionToState(state);
	}
	
	public event Action<MHTableViewCellStateMask> didTransitionToState;
	public void _didTransitionToState(MHTableViewCellStateMask state)
	{
		if(didTransitionToState != null)
			didTransitionToState(state);
	}
	#endregion
}
