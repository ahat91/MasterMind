using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;

public partial class MHiOSManager : Singleton<MHiOSManager> {
	#region tableview
	[DllImport("__Internal")]
    private static extern int _init_tableview(int tag);
	public MHTableView init_tableview(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_init_tableview(tag)) as MHTableView;
		}
		else
			return new MHTableView();
	}
	
	[DllImport("__Internal")]
    private static extern int _initWithFrame_tableview(int tag, string aRect);
	public MHTableView initWithFrame_tableview(int tag, Rect aRect)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string rectJsonString = MHTools.ConvertRectToJSON(aRect);
			
			return GetObjectByUniqueTag(_initWithFrame_tableview(tag, rectJsonString)) as MHTableView;
		}
		else
			return new MHTableView();
	}
	
	[DllImport("__Internal")]
    private static extern int _initWithFrameAndStyle_tableview(int tag, string frame, int style);
	public MHTableView initWithFrameAndStyle_tableview(int tag, Rect frame, MHTableViewStyle style)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string rectJsonString = MHTools.ConvertRectToJSON(frame);
			
			return GetObjectByUniqueTag(_initWithFrameAndStyle_tableview(tag, rectJsonString, (int)style)) as MHTableView;
		}
		else
			return new MHTableView();
	}
	
	[DllImport("__Internal")]
    private static extern int _style_tableview(int tag);
	public MHTableViewStyle style_tableview(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return (MHTableViewStyle)_style_tableview(tag);
		}
		else
			return MHTableViewStyle.MHTableViewStylePlain;
	}
	
	[DllImport("__Internal")]
    private static extern int _numberOfRowsInSection(int tag, int section);
	public int numberOfRowsInSection(int tag, int section)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _numberOfRowsInSection(tag, section);
		}
		else
			return 0;
	}
	
	[DllImport("__Internal")]
    private static extern int _numberOfSections(int tag);
	public int numberOfSections(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _numberOfSections(tag);
		}
		else
			return 0;
	}
	
	[DllImport("__Internal")]
    private static extern float _rowHeight(int tag);
	public float rowHeight(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _rowHeight(tag);
		}
		else
			return 0f;
	}
	
	[DllImport("__Internal")]
    private static extern void _rowHeight_set(int tag, float height);
	public void rowHeight(int tag, float height) 
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_rowHeight_set(tag, height);
		}
	}
	
	[DllImport("__Internal")]
    private static extern int _seperatorStyle(int tag);
	public MHTableViewCellSeperatorStyle seperatorStyle(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return (MHTableViewCellSeperatorStyle)_seperatorStyle(tag);
		}
		else
			return MHTableViewCellSeperatorStyle.MHTableViewCellSeperatorStyleNone;
	}
	
	[DllImport("__Internal")]
    private static extern void _seperatorStyle_set(int tag, int sepStyle);
	public void seperatorStyle(int tag, MHTableViewCellSeperatorStyle sepStyle)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_seperatorStyle_set(tag, (int)sepStyle);
		}
	}
	
	[DllImport("__Internal")]
    private static extern string _seperatorColor(int tag);
	public Color seperatorColor(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string colorJsonString = _seperatorColor(tag);
			
			return MHTools.ConvertUIColorToColor(colorJsonString);
		}
		else
			return Color.black;
	}
	
	[DllImport("__Internal")]
    private static extern void _seperatorColor_set(int tag, string col);
	public void seperatorColor(int tag, Color col) 
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string colorJsonString = MHTools.ConvertColorToUIColor(col);
			
			_seperatorColor_set(tag, colorJsonString);
		}
	}
	
	[DllImport("__Internal")]
    private static extern string _seperatorInset(int tag);
	public Vector4 seperatorInset(int tag) 
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string vectorJsonString = _seperatorInset(tag);
			
			return MHTools.ConvertJSONToVector4(vectorJsonString);
		}
		else
			return Vector4.zero;
	}
	
	[DllImport("__Internal")]
    private static extern void _seperatorInset_set(int tag, string inset);
	public void seperatorInset(int tag, Vector4 inset)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string vectorJsonString = MHTools.ConvertVector4ToJSON(inset);
			
			_seperatorInset_set(tag, vectorJsonString);
		}
	}
	
	[DllImport("__Internal")]
    private static extern int _dequeueReusableCellWithIdentifierForIndexPath(int tag, string identifier, int[] indexPath);
	public MHTableViewCell dequeueReusableCellWithIdentifierForIndexPath(int tag, string identifier, int[] indexPath)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_dequeueReusableCellWithIdentifierForIndexPath(tag, identifier, indexPath)) as MHTableViewCell;
		}
		else
			return new MHTableViewCell();
	}
	
	[DllImport("__Internal")]
    private static extern int _dequeueReusableCellWithIdentifier(int tag, string identifier);
	public MHTableViewCell dequeueReusableCellWithIdentifier(int tag, string identifier)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_dequeueReusableCellWithIdentifier(tag, identifier)) as MHTableViewCell;
		}
		else
			return new MHTableViewCell();
	}
	
	[DllImport("__Internal")]
    private static extern int _dequeueReusableHeaderFooterViewWithIdentifier(int tag, string identifier);
	public MHTableViewHeaderFooterView dequeueReusableHeaderFooterViewWithIdentifier(int tag, string identifier)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_dequeueReusableHeaderFooterViewWithIdentifier(tag, identifier)) as MHTableViewHeaderFooterView;
		}
		else
			return new MHTableViewHeaderFooterView();
	}
	
	[DllImport("__Internal")]
    private static extern int _tableHeaderView(int tag);
	public MHView tableHeaderView(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_tableHeaderView(tag)) as MHView;
		}
		else
			return new MHView();
	}
	
	[DllImport("__Internal")]
    private static extern void _tableHeaderView_set(int tag, int vw);
	public void tableHeaderView(int tag, MHView vw)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_tableHeaderView_set(tag, vw.tag);
		}
	}
	
	[DllImport("__Internal")]
    private static extern int _tableFooterView(int tag);
	public MHView tableFooterView(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_tableFooterView(tag)) as MHView;
		}
		else
			return new MHView();
	}
	
	[DllImport("__Internal")]
    private static extern void _tableFooterView_set(int tag, int vw);
	public void tableFooterView(int tag, MHView vw)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_tableFooterView_set(tag, vw.tag);
		}
	}
	
	[DllImport("__Internal")]
    private static extern float _sectionHeaderHeight(int tag);
	public float sectionHeaderHeight(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _sectionHeaderHeight(tag);
		}
		else
			return 0f;
	}
	
	[DllImport("__Internal")]
    private static extern void _sectionHeaderHeight_set(int tag, float height);
	public void sectionHeaderHeight(int tag, float height)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_sectionHeaderHeight_set(tag, height);
		}
	}
	
	[DllImport("__Internal")]
    private static extern float _sectionFooterHeight(int tag);
	public float sectionFooterHeight(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _sectionFooterHeight(tag);
		}
		else
			return 0f;
	}
	
	[DllImport("__Internal")]
    private static extern void _sectionFooterHeight_set(int tag, float height);
	public void sectionFooterHeight(int tag, float height)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_sectionFooterHeight_set(tag, height);
		}
	}
	
	[DllImport("__Internal")]
    private static extern int _headerViewForSection(int tag, int section);
	public MHTableViewHeaderFooterView headerViewForSection(int tag, int section)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_headerViewForSection(tag, section)) as MHTableViewHeaderFooterView;
		}
		else
			return new MHTableViewHeaderFooterView();
	}
	
	[DllImport("__Internal")]
    private static extern int _footerViewForSection(int tag, int section);
	public MHTableViewHeaderFooterView footerViewForSection(int tag, int section)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_footerViewForSection(tag, section)) as MHTableViewHeaderFooterView;
		}
		else
			return new MHTableViewHeaderFooterView();
	}
	
	[DllImport("__Internal")]
    private static extern int _cellForRowAtIndexPath(int tag, int[] indexPath);
	public MHTableViewCell cellForRowAtIndexPath(int tag, int[] indexPath)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_cellForRowAtIndexPath(tag, indexPath)) as MHTableViewCell;
		}
		else
			return new MHTableViewCell();
	}
	
	[DllImport("__Internal")]
    private static extern string _indexPathForCell(int tag, int cell);
	public int[] indexPathForCell(int tag, MHTableViewCell cell)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string intJsonString = _indexPathForCell(tag, cell.tag);
			
			return MHTools.ConvertJSONToIntArray(intJsonString);
		}
		else
			return new int[0];
	}
	
	[DllImport("__Internal")]
    private static extern string _indexPathForRowAtPoint(int tag, string point);
	public int[] indexPathForRowAtPoint(int tag, Vector2 point)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string vectorJsonString = MHTools.ConvertVector2ToJSON(point);
			
			string intJsonString = _indexPathForRowAtPoint(tag, vectorJsonString);
			
			return MHTools.ConvertJSONToIntArray(intJsonString);
		}
		else
			return new int[0];
	}
	
	[DllImport("__Internal")]
    private static extern string _indexPathsForRowsInRect(int tag, string rect);
	public int[][] indexPathsForRowsInRect(int tag, Rect rect)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string rectJsonString = MHTools.ConvertRectToJSON(rect);
			
			string stringJsonString = _indexPathsForRowsInRect(tag, rectJsonString);
			
			string[] intJsonString = MHTools.ConvertJsonToStringArray(stringJsonString);
			
			int[][] result = new int[intJsonString.Length][];
			
			for(int i = 0; i < intJsonString.Length; i++)
				result[i] = MHTools.ConvertJSONToIntArray(intJsonString[i]);
			
			return result;
		}
		else
			return new int[0][];
	}
	
	[DllImport("__Internal")]
    private static extern string _visibleCells(int tag);
	public MHTableViewCell[] visibleCells(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectsByUniqueTags(MHTools.ConvertJSONToIntArray(_visibleCells(tag))) as MHTableViewCell[];
		}
		else
			return new MHTableViewCell[0];
	}
	
	[DllImport("__Internal")]
    private static extern string _indexPathsForVisibleRows(int tag);
	public int[][] indexPathsForVisibleRows(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string stringJsonString = _indexPathsForVisibleRows(tag);
			
			string[] intJsonString = MHTools.ConvertJsonToStringArray(stringJsonString);
			
			int[][] result = new int[intJsonString.Length][];
			
			for(int i = 0; i < intJsonString.Length; i++)
				result[i] = MHTools.ConvertJSONToIntArray(intJsonString[i]);
			
			return result;
		}
		else
			return new int[0][];
	}
	
	[DllImport("__Internal")]
    private static extern float _estimatedRowHeight(int tag);
	public float estimatedRowHeight(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _estimatedRowHeight(tag);
		}
		else
			return 0f;
	}
	
	[DllImport("__Internal")]
    private static extern void _estimatedRowHeight_set(int tag, float height);
	public void estimatedRowHeight(int tag, float height)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_estimatedRowHeight_set(tag, height);
		}
	}
	
	[DllImport("__Internal")]
    private static extern float _estimatedSectionHeaderHeight(int tag);
	public float estimatedSectionHeaderHeight(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _estimatedSectionHeaderHeight(tag);
		}
		else
			return 0f;
	}
	
	[DllImport("__Internal")]
    private static extern void _estimatedSectionHeaderHeight_set(int tag, float height);
	public void estimatedSectionHeaderHeight(int tag, float height)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_estimatedSectionHeaderHeight_set(tag, height);
		}
	}
	
	[DllImport("__Internal")]
    private static extern float _estimatedSectionFooterHeight(int tag);
	public float estimatedSectionFooterHeight(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _estimatedSectionFooterHeight(tag);
		}
		else
			return 0f;
	}
	
	[DllImport("__Internal")]
    private static extern void _estimatedSectionFooterHeight_set(int tag, float height);
	public void estimatedSectionFooterHeight(int tag, float height)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_estimatedSectionFooterHeight_set(tag, height);
		}
	}

	[DllImport("__Internal")]
    private static extern void _scrollToRowAtIndexPathAtScrollPosition(int tag, int[] indexPath, int scrollPosition, bool animated);
	public void scrollToRowAtIndexPathAtScrollPosition(int tag, int[] indexPath, MHTableViewScrollPosition scrollPosition, bool animated)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_scrollToRowAtIndexPathAtScrollPosition(tag, indexPath, (int)scrollPosition, animated);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _scrollToNearestSelectedRowAtScrollPosition(int tag, int scrollPosition, bool animated);
	public void scrollToNearestSelectedRowAtScrollPosition(int tag, MHTableViewScrollPosition scrollPosition, bool animated)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_scrollToNearestSelectedRowAtScrollPosition(tag, (int)scrollPosition, animated);
		}
	}
	
	[DllImport("__Internal")]
    private static extern string _indexPathForSelectedRow(int tag);
	public int[] indexPathForSelectedRow(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return MHTools.ConvertJSONToIntArray(_indexPathForSelectedRow(tag));
		}
		else
			return new int[0];
	}
	
	[DllImport("__Internal")]
    private static extern string _indexPathsForSelectedRows(int tag, string rect);
	public int[][] indexPathsForSelectedRows(int tag, Rect rect)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string rectJsonString = MHTools.ConvertRectToJSON(rect);
			
			string stringJsonString = _indexPathsForSelectedRows(tag, rectJsonString);
			
			string[] intJsonString = MHTools.ConvertJsonToStringArray(stringJsonString);
			
			int[][] result = new int[intJsonString.Length][];
			
			for(int i = 0; i < intJsonString.Length; i++)
				result[i] = MHTools.ConvertJSONToIntArray(intJsonString[i]);
			
			return result;
		}
		else
			return new int[0][];
	}
	
	[DllImport("__Internal")]
    private static extern void _selectRowAtIndexPath(int tag, int[] indexPath, bool animated, int scrollPosition);
	public void selectRowAtIndexPath(int tag, int[] indexPath, bool animated, MHTableViewScrollPosition scrollPosition)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_selectRowAtIndexPath(tag, indexPath, animated, (int)scrollPosition);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _deselectRowAtIndexPath(int tag, int[] indexPath, bool animated);
	public void deselectRowAtIndexPath(int tag, int[] indexPath, bool animated)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_deselectRowAtIndexPath(tag, indexPath, animated);
		}
	}
	
	[DllImport("__Internal")]
    private static extern bool _allowsSelection(int tag);
	public bool allowsSelection(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _allowsSelection(tag);
		}
		else
			return false;
	}
	
	[DllImport("__Internal")]
    private static extern void _allowsSelection_set(int tag, bool allows);
	public void allowsSelection(int tag, bool allows)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_allowsSelection_set(tag, allows);
		}
	}
	
	[DllImport("__Internal")]
    private static extern bool _allowsMultipleSelection(int tag);
	public bool allowsMultipleSelection(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _allowsMultipleSelection(tag);
		}
		else
			return false;
	}
	
	[DllImport("__Internal")]
    private static extern void _allowsMultipleSelection_set(int tag, bool allows);
	public void allowsMultipleSelection(int tag, bool allows)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_allowsMultipleSelection_set(tag, allows);
		}
	}
	
	[DllImport("__Internal")]
    private static extern bool _allowsSelectionDuringEditing(int tag);
	public bool allowsSelectionDuringEditing(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _allowsSelectionDuringEditing(tag);
		}
		else
			return false;
	}
	
	[DllImport("__Internal")]
    private static extern void _allowsSelectionDuringEditing_set(int tag, bool allows);
	public void allowsSelectionDuringEditing(int tag, bool allows)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_allowsSelectionDuringEditing_set(tag, allows);
		}
	}
	
	[DllImport("__Internal")]
    private static extern bool _allowsMultipleSelectionDuringEditing(int tag);
	public bool allowsMultipleSelectionDuringEditing(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _allowsMultipleSelectionDuringEditing(tag);
		}
		else
			return false;
	}
	
	[DllImport("__Internal")]
    private static extern void _allowsMultipleSelectionDuringEditing_set(int tag, bool allows);
	public void allowsMultipleSelectionDuringEditing(int tag, bool allows)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_allowsMultipleSelectionDuringEditing_set(tag, allows);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _beginUpdates(int tag);
	public void beginUpdates(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_beginUpdates(tag);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _endUpdates(int tag);
	public void endUpdates(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_endUpdates(tag);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _insertRowsAtIndexPathsWithRowAnimation(int tag, string indexPaths, int animation);
	public void insertRowsAtIndexPathsWithRowAnimation(int tag, int[][] indexPaths, MHTableViewRowAnimation animation)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_insertRowsAtIndexPathsWithRowAnimation(tag, MHTools.ConvertIntDoubleArrayToJson(indexPaths), (int)animation);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _deleteRowsAtIndexPathsWithRowAnimation(int tag, string indexPaths, int animation);
	public void deleteRowsAtIndexPathsWithRowAnimation(int tag, int[][] indexPaths, MHTableViewRowAnimation animation)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_deleteRowsAtIndexPathsWithRowAnimation(tag, MHTools.ConvertIntDoubleArrayToJson(indexPaths), (int)animation);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _moveRowAtIndexPathToIndexPath(int tag, int[] indexPath, int[] newIndexPath);
	public void moveRowAtIndexPathToIndexPath(int tag, int[] indexPath, int[] newIndexPath)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_moveRowAtIndexPathToIndexPath(tag, indexPath, newIndexPath);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _insertSectionsWithRowAnimation(int tag, int[] sections, int animation);
	public void insertSectionsWithRowAnimation(int tag, int[] sections, MHTableViewRowAnimation animation)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_insertSectionsWithRowAnimation(tag, sections, (int)animation);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _deleteSectionsWithRowAnimation(int tag, int[] sections, int animation);
	public void deleteSectionsWithRowAnimation(int tag, int[] sections, MHTableViewRowAnimation animation)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_deleteSectionsWithRowAnimation(tag, sections, (int)animation);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _moveSectionToSection(int tag, int section, int newSection);
	public void moveSectionToSection(int tag, int section, int newSection)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_moveSectionToSection(tag, section, newSection);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _reloadData(int tag);
	public void reloadData(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_reloadData(tag);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _reloadRowsAtIndexPathsWithRowAnimation(int tag, string indexPaths, int animation);
	public void reloadRowsAtIndexPathsWithRowAnimation(int tag, int[][] indexPaths, MHTableViewRowAnimation animation)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_reloadRowsAtIndexPathsWithRowAnimation(tag, MHTools.ConvertIntDoubleArrayToJson(indexPaths), (int)animation);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _reloadSectionsWithRowAnimation(int tag, int[] sections, int animation);
	public void reloadSectionsWithRowAnimation(int tag, int[] sections, MHTableViewRowAnimation animation)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_reloadSectionsWithRowAnimation(tag, sections, (int)animation);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _reloadSectionIndexTitles(int tag);
	public void reloadSectionIndexTitles(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_reloadSectionIndexTitles(tag);
		}
	}
	
	[DllImport("__Internal")]
    private static extern string _rectForSection(int tag, int section);
	public Rect rectForSection(int tag, int section)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return MHTools.ConvertJSONToRect(_rectForSection(tag, section));
		}
		else
			return MHTools.RectZero;
	}
	
	[DllImport("__Internal")]
    private static extern string _rectForRowAtIndexPath(int tag, int[] indexPath);
	public Rect rectForRowAtIndexPath(int tag, int[] indexPath)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return MHTools.ConvertJSONToRect(_rectForRowAtIndexPath(tag, indexPath));
		}
		else
			return MHTools.RectZero;
	}
	
	[DllImport("__Internal")]
    private static extern string _rectForFooterInSection(int tag, int section);
	public Rect rectForFooterInSection(int tag, int section)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return MHTools.ConvertJSONToRect(_rectForFooterInSection(tag, section));
		}
		else
			return MHTools.RectZero;
	}
	
	[DllImport("__Internal")]
    private static extern string _rectForHeaderInSection(int tag, int section);
	public Rect rectForHeaderInSection(int tag, int section)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return MHTools.ConvertJSONToRect(_rectForHeaderInSection(tag, section));
		}
		else
			return MHTools.RectZero;
	}
	
	[DllImport("__Internal")]
    private static extern int _sectionIndexMinimumDisplayRowCount(int tag);
	public int sectionIndexMinimumDisplayRowCount(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _sectionIndexMinimumDisplayRowCount(tag);
		}
		else
			return 0;
	}
	
	[DllImport("__Internal")]
    private static extern void _sectionIndexMinimumDisplayRowCount_set(int tag, int count);
	public void sectionIndexMinimumDisplayRowCount(int tag, int count)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_sectionIndexMinimumDisplayRowCount_set(tag, count);
		}
	}
	
	[DllImport("__Internal")]
    private static extern string _sectionIndexColor(int tag);
	public Color sectionIndexColor(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string colorJsonString = _sectionIndexColor(tag);
			
			return MHTools.ConvertUIColorToColor(colorJsonString);
		}
		else
			return Color.black;
	}
	
	[DllImport("__Internal")]
    private static extern void _sectionIndexColor_set(int tag, string col);
	public void sectionIndexColor(int tag, Color col)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_sectionIndexColor_set(tag, MHTools.ConvertColorToUIColor(col));
		}
	}
	
	[DllImport("__Internal")]
    private static extern string _sectionIndexBackgroundColor(int tag);
	public Color sectionIndexBackgroundColor(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string colorJsonString = _sectionIndexBackgroundColor(tag);
			
			return MHTools.ConvertUIColorToColor(colorJsonString);
		}
		else
			return Color.black;
	}
	
	[DllImport("__Internal")]
    private static extern void _sectionIndexBackgroundColor_set(int tag, string col);
	public void sectionIndexBackgroundColor(int tag, Color col)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_sectionIndexBackgroundColor_set(tag, MHTools.ConvertColorToUIColor(col));
		}
	}
	
	[DllImport("__Internal")]
    private static extern string _sectionIndexTrackingBackgroundColor(int tag);
	public Color sectionIndexTrackingBackgroundColor(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string colorJsonString = _sectionIndexTrackingBackgroundColor(tag);
			
			return MHTools.ConvertUIColorToColor(colorJsonString);
		}
		else
			return Color.black;
	}
	
	[DllImport("__Internal")]
    private static extern void _sectionIndexTrackingBackgroundColor_set(int tag, string col);
	public void sectionIndexTrackingBackgroundColor(int tag, Color col)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_sectionIndexTrackingBackgroundColor_set(tag, MHTools.ConvertColorToUIColor(col));
		}
	}
	#endregion
	
	#region delegate
	void tableViewHeightForRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewHeightForRowAtIndexPath(tableView, indexPath);
		}
	}
	
	void tableViewEstimatedHeightForRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewEstimatedHeightForRowAtIndexPath(tableView, indexPath);
		}
	}
	
	void tableViewIndentationLevelForRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewIndentationLevelForRowAtIndexPath(tableView, indexPath);
		}
	}
	
	void tableViewWillDisplayCellForRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		MHTableViewCell cell;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			cell = GetObjectByUniqueTag(Convert.ToInt32(result["cell"])) as MHTableViewCell;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewWillDisplayCellForRowAtIndexPath(tableView, cell, indexPath);
		}
	}

	void tableViewAccessoryButtonTappedForRowWithIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewAccessoryButtonTappedForRowWithIndexPath(tableView, indexPath);
		}
	}
	
	void tableViewWillSelectRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewWillSelectRowAtIndexPath(tableView, indexPath);
		}
	}
	
	void tableViewDidSelectRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewDidSelectRowAtIndexPath(tableView, indexPath);
		}
	}
	
	void tableViewWillDeselectRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewWillDeselectRowAtIndexPath(tableView, indexPath);
		}
	}
	
	void tableViewDidDeselectRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewDidDeselectRowAtIndexPath(tableView, indexPath);
		}
	}
	
	void tableViewViewForHeaderInSection(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int section;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			section = Convert.ToInt32(result["section"]);
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewViewForHeaderInSection(tableView, section);
		}
	}
	
	void tableViewViewForFooterInSection(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int section;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			section = Convert.ToInt32(result["section"]);
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewViewForFooterInSection(tableView, section);
		}
	}
	
	void tableViewHeightForHeaderInSection(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int section;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			section = Convert.ToInt32(result["section"]);
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewHeightForHeaderInSection(tableView, section);
		}
	}
	
	void tableViewEstimatedHeightForHeaderInSection(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int section;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			section = Convert.ToInt32(result["section"]);
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewEstimatedHeightForHeaderInSection(tableView, section);
		}
	}
	
	void tableViewHeightForFooterInSection(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int section;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			section = Convert.ToInt32(result["section"]);
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewHeightForFooterInSection(tableView, section);
		}
	}
	
	void tableViewEstimatedHeightForFooterInSection(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int section;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			section = Convert.ToInt32(result["section"]);
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewEstimatedHeightForFooterInSection(tableView, section);
		}
	}
	
	void tableViewWillDisplayHeaderViewForSection(string jsonString)
	{
		int tag;
		MHTableView tableView;
		MHView view;
		int section;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			view = GetObjectByUniqueTag(Convert.ToInt32(result["view"])) as MHView;
			section = Convert.ToInt32(result["section"]);
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewWillDisplayHeaderViewForSection(tableView, view, section);
		}
	}
	
	void tableViewWillDisplayFooterViewForSection(string jsonString)
	{
		int tag;
		MHTableView tableView;
		MHView view;
		int section;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			view = GetObjectByUniqueTag(Convert.ToInt32(result["view"])) as MHView;
			section = Convert.ToInt32(result["section"]);
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewWillDisplayFooterViewForSection(tableView, view, section);
		}
	}
	
	void tableViewWillBeginEditingRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewWillBeginEditingRowAtIndexPath(tableView, indexPath);
		}
	}
	
	void tableViewDidEndEditingRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewDidEndEditingRowAtIndexPath(tableView, indexPath);
		}
	}
	
	void tableViewEditingStyleForRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewEditingStyleForRowAtIndexPath(tableView, indexPath);
		}
	}
	
	void tableViewTitleForDeleteConfirmationButtonForRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewTitleForDeleteConfirmationButtonForRowAtIndexPath(tableView, indexPath);
		}
	}
	
	void tableViewShouldIndentWhileEditingRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewShouldIndentWhileEditingRowAtIndexPath(tableView, indexPath);
		}
	}
	
	void tableViewTargetIndexPathForMoveFromRowAtIndexPathToProposedIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] sourceIndexPath;
		int[] proposedDestinationIndexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			sourceIndexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["sourceIndexPath"]));
			proposedDestinationIndexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["proposedDestinationIndexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewTargetIndexPathForMoveFromRowAtIndexPathToProposedIndexPath(tableView, sourceIndexPath, proposedDestinationIndexPath);
		}
	}
	
	void tableViewDidEndDisplayingCellForRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		MHTableViewCell cell;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			cell = GetObjectByUniqueTag(Convert.ToInt32(result["cell"])) as MHTableViewCell;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewDidEndDisplayingCellForRowAtIndexPath(tableView, cell, indexPath);
		}
	}
	
	void tableViewDidEndDisplayingHeaderViewForSection(string jsonString)
	{
		int tag;
		MHTableView tableView;
		MHView view;
		int section;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			view = GetObjectByUniqueTag(Convert.ToInt32(result["view"])) as MHView;
			section = Convert.ToInt32(result["section"]);
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewDidEndDisplayingHeaderViewForSection(tableView, view, section);
		}
	}
	
	void tableViewDidEndDisplayingFooterViewForSection(string jsonString)
	{
		int tag;
		MHTableView tableView;
		MHView view;
		int section;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			view = GetObjectByUniqueTag(Convert.ToInt32(result["view"])) as MHView;
			section = Convert.ToInt32(result["section"]);
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewDidEndDisplayingFooterViewForSection(tableView, view, section);
		}
	}
	
	void tableViewShouldShowMenuForRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewShouldShowMenuForRowAtIndexPath(tableView, indexPath);
		}
	}
	
	void tableViewShouldHighlightRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewShouldHighlightRowAtIndexPath(tableView, indexPath);
		}
	}
	
	void tableViewDidHighlightRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewDidHighlightRowAtIndexPath(tableView, indexPath);
		}
	}
	
	void tableViewDidUnhighlightRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewDidUnhighlightRowAtIndexPath(tableView, indexPath);
		}
	}
	#endregion
	
	#region datasource
	void tableViewCellForRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewCellForRowAtIndexPath(tableView, indexPath);
		}
	}
	
	void numberOfSectionsInTableView(string jsonString)
	{
		int tag;
		MHTableView tableView;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._numberOfSectionsInTableView(tableView);
		}
	}
	
	void tableViewNumberOfRowsInSection(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int section;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			section = Convert.ToInt32(result["section"]);
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewNumberOfRowsInSection(tableView, section);
		}
	}
	
	void sectionIndexTitlesForTableView(string jsonString)
	{
		int tag;
		MHTableView tableView;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._sectionIndexTitlesForTableView(tableView);
		}
	}
	
	void tableViewSectionForSectionIndexTitleAtIndex(string jsonString)
	{
		int tag;
		MHTableView tableView;
		string title;
		int index;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			title = Convert.ToString(result["title"]);
			index = Convert.ToInt32(result["index"]);
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewSectionForSectionIndexTitleAtIndex(tableView, title, index);
		}
	}
	
	void tableViewTitleForFooterInSection(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int section;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			section = Convert.ToInt32(result["section"]);
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewTitleForFooterInSection(tableView, section);
		}
	}
	
	void tableViewTitleForHeaderInSection(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int section;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			section = Convert.ToInt32(result["section"]);
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewTitleForHeaderInSection(tableView, section);
		}
	}
	
	void tableViewCommitEditingStyleForRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		MHTableViewCellEditingStyle editingStyle;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			editingStyle = (MHTableViewCellEditingStyle)Convert.ToInt32(result["editingStyle"]);
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewCommitEditingStyleForRowAtIndexPath(tableView, editingStyle, indexPath);
		}
	}
	
	void tableViewCanEditRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewCanEditRowAtIndexPath(tableView, indexPath);
		}
	}
	
	void tableViewCanMoveRowAtIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] indexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			indexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["indexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewCanMoveRowAtIndexPath(tableView, indexPath);
		}
	}
	
	void tableViewMoveRowAtIndexPathToIndexPath(string jsonString)
	{
		int tag;
		MHTableView tableView;
		int[] fromIndexPath;
		int[] toIndexPath;
		
		Hashtable result = jsonString.hashtableFromJson();
		if(result != null)
		{
			tag = Convert.ToInt32(result["tag"]);
			tableView = GetObjectByUniqueTag(Convert.ToInt32(result["tableView"])) as MHTableView;
			fromIndexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["fromIndexPath"]));
			toIndexPath = MHTools.ConvertJSONToIntArray(Convert.ToString(result["toIndexPath"]));
			
			MHObject obj = GetObjectByUniqueTag(tag);
			if(obj is MHTableView)
				(obj as MHTableView)._tableViewMoveRowAtIndexPathToIndexPath(tableView, fromIndexPath, toIndexPath);
		}
	}
	#endregion
}