using UnityEngine;
using System;
using System.Collections;

public class MHTableView : MHScrollView {
	#region functions
	public MHTableView(){}
	
	public MHTableView(bool autoInitialize)
	{
		if(Application.isPlaying && autoInitialize)
			init();
	}
	
	public MHTableView(Rect aRect)
	{
		if(Application.isPlaying)
			initWithFrame(aRect);
	}
	
	public MHTableView(Rect frame, MHTableViewStyle style)
	{
		if(Application.isPlaying)
			initWithFrameAndStyle(frame, style);
	}
	
	new public MHTableView init()
	{
		return MHiOSManager.Instance.init_tableview(tag);
	}
	
	new public MHTableView initWithFrame(Rect aRect)
	{
		return MHiOSManager.Instance.initWithFrame_tableview(tag, aRect);
	}
	
	public MHTableView initWithFrameAndStyle(Rect frame, MHTableViewStyle style)
	{
		return MHiOSManager.Instance.initWithFrameAndStyle_tableview(tag, frame, style);
	}
	
	public MHTableViewStyle style {
		get {
			return MHiOSManager.Instance.style_tableview(tag);
		}
	}
	
	public int numberOfRowsInSection(int section)
	{
		return MHiOSManager.Instance.numberOfRowsInSection(tag, section);
	}
	
	public int numberOfSections()
	{
		return MHiOSManager.Instance.numberOfSections(tag);
	}
	
	public float rowHeight {
		get {
			return MHiOSManager.Instance.rowHeight(tag);
		} set {
			MHiOSManager.Instance.rowHeight(tag, value);
		}
	}
	
	public MHTableViewCellSeperatorStyle seperatorStyle {
		get {
			return MHiOSManager.Instance.seperatorStyle(tag);
		} set {
			MHiOSManager.Instance.seperatorStyle(tag, value);
		}
	}
	
	public Color seperatorColor {
		get {
			return MHiOSManager.Instance.seperatorColor(tag);
		} set {
			MHiOSManager.Instance.seperatorColor(tag, value);
		}
	}
	
	public MHView backgroundView {
		get {
			return MHiOSManager.Instance.backgroundView(tag);
		} set {
			MHiOSManager.Instance.backgroundView(tag, value);
		}
	}
	
	public Vector4 seperatorInset {
		get {
			return MHiOSManager.Instance.seperatorInset(tag);
		} set {
			MHiOSManager.Instance.seperatorInset(tag, value);
		}
	}
	
	public MHTableViewCell dequeueReusableCellWithIdentifierForIndexPath(string identifier, int[] indexPath)
	{
		return MHiOSManager.Instance.dequeueReusableCellWithIdentifierForIndexPath(tag, identifier, indexPath);
	}
	
	public MHTableViewCell dequeueReusableCellWithIdentifier(string identifier)
	{
		return MHiOSManager.Instance.dequeueReusableCellWithIdentifier(tag, identifier);
	}
	
	public MHTableViewHeaderFooterView dequeueReusableHeaderFooterViewWithIdentifier(string identifier)
	{
		return MHiOSManager.Instance.dequeueReusableHeaderFooterViewWithIdentifier(tag, identifier);
	}
	
	public MHView tableHeaderView {
		get {
			return MHiOSManager.Instance.tableHeaderView(tag);
		} set {
			MHiOSManager.Instance.tableHeaderView(tag, value);
		}
	}
	
	public MHView tableFooterView {
		get {
			return MHiOSManager.Instance.tableFooterView(tag);
		} set {
			MHiOSManager.Instance.tableFooterView(tag, value);
		}
	}
	
	public float sectionHeaderHeight {
		get {
			return MHiOSManager.Instance.sectionHeaderHeight(tag);
		} set {
			MHiOSManager.Instance.sectionHeaderHeight(tag, value);
		}
	}
	
	public float sectionFooterHeight {
		get {
			return MHiOSManager.Instance.sectionFooterHeight(tag);
		} set {
			MHiOSManager.Instance.sectionFooterHeight(tag, value);
		}
	}
	
	public MHTableViewHeaderFooterView headerViewForSection(int section)
	{
		return MHiOSManager.Instance.headerViewForSection(tag, section);
	}
	
	public MHTableViewHeaderFooterView footerViewForSection(int section)
	{
		return MHiOSManager.Instance.footerViewForSection(tag, section);
	}
	
	public MHTableViewCell cellForRowAtIndexPath(int[] indexPath)
	{
		return MHiOSManager.Instance.cellForRowAtIndexPath(tag, indexPath);
	}
	
	public int[] indexPathForCell(MHTableViewCell cell)
	{
		return MHiOSManager.Instance.indexPathForCell(tag, cell);
	}
	
	public int[] indexPathForRowAtPoint(Vector2 point)
	{
		return MHiOSManager.Instance.indexPathForRowAtPoint(tag, point);
	}
	
	public int[][] indexPathsForRowsInRect(Rect rect)
	{
		return MHiOSManager.Instance.indexPathsForRowsInRect(tag, rect);
	}
	
	public MHTableViewCell[] visibleCells()
	{
		return MHiOSManager.Instance.visibleCells(tag);
	}
	
	public int[][] indexPathsForVisibleRows()
	{
		return MHiOSManager.Instance.indexPathsForVisibleRows(tag);
	}
	
	public float estimatedRowHeight {
		get {
			return MHiOSManager.Instance.estimatedRowHeight(tag);
		} set {
			MHiOSManager.Instance.estimatedRowHeight(tag, value);
		}
	}
	
	public float estimatedSectionHeaderHeight {
		get {
			return MHiOSManager.Instance.estimatedSectionHeaderHeight(tag);
		} set {
			MHiOSManager.Instance.estimatedSectionHeaderHeight(tag, value);
		}
	}
	
	public float estimatedSectionFooterHeight {
		get {
			return MHiOSManager.Instance.estimatedSectionFooterHeight(tag);
		} set {
			MHiOSManager.Instance.estimatedSectionFooterHeight(tag, value);
		}
	}

	public void scrollToRowAtIndexPathAtScrollPosition(int[] indexPath, MHTableViewScrollPosition scrollPosition, bool animated)
	{
		MHiOSManager.Instance.scrollToRowAtIndexPathAtScrollPosition(tag, indexPath, scrollPosition, animated);
	}
	
	public void scrollToNearestSelectedRowAtScrollPosition(MHTableViewScrollPosition scrollPosition, bool animated)
	{
		MHiOSManager.Instance.scrollToNearestSelectedRowAtScrollPosition(tag, scrollPosition, animated);
	}
	
	public int[] indexPathForSelectedRow()
	{
		return MHiOSManager.Instance.indexPathForSelectedRow(tag);
	}
	
	public int[][] indexPathsForSelectedRows(Rect rect)
	{
		return MHiOSManager.Instance.indexPathsForSelectedRows(tag, rect);
	}
	
	public void selectRowAtIndexPath(int[] indexPath, bool animated, MHTableViewScrollPosition scrollPosition)
	{
		MHiOSManager.Instance.selectRowAtIndexPath(tag, indexPath, animated, scrollPosition);
	}
	
	public void deselectRowAtIndexPath(int[] indexPath, bool animated)
	{
		MHiOSManager.Instance.deselectRowAtIndexPath(tag, indexPath, animated);
	}
	
	public bool allowsSelection {
		get {
			return MHiOSManager.Instance.allowsSelection(tag);
		} set {
			MHiOSManager.Instance.allowsSelection(tag, value);
		}
	}
	
	public bool allowsMultipleSelection {
		get {
			return MHiOSManager.Instance.allowsMultipleSelection(tag);
		} set {
			MHiOSManager.Instance.allowsMultipleSelection(tag, value);
		}
	}
	
	public bool allowsSelectionDuringEditing {
		get {
			return MHiOSManager.Instance.allowsSelectionDuringEditing(tag);
		} set {
			MHiOSManager.Instance.allowsSelectionDuringEditing(tag, value);
		}
	}
	
	public bool allowsMultipleSelectionDuringEditing {
		get {
			return MHiOSManager.Instance.allowsMultipleSelectionDuringEditing(tag);
		} set {
			MHiOSManager.Instance.allowsMultipleSelectionDuringEditing(tag, value);
		}
	}
	
	public void beginUpdates()
	{
		MHiOSManager.Instance.beginUpdates(tag);
	}
	
	public void endUpdates()
	{
		MHiOSManager.Instance.endUpdates(tag);
	}
	
	public void insertRowsAtIndexPathsWithRowAnimation(int[][] indexPaths, MHTableViewRowAnimation animation)
	{
		MHiOSManager.Instance.insertRowsAtIndexPathsWithRowAnimation(tag, indexPaths, animation);
	}
	
	public void deleteRowsAtIndexPathsWithRowAnimation(int[][] indexPaths, MHTableViewRowAnimation animation)
	{
		MHiOSManager.Instance.deleteRowsAtIndexPathsWithRowAnimation(tag, indexPaths, animation);
	}
	
	public void moveRowAtIndexPathToIndexPath(int[] indexPath, int[] newIndexPath)
	{
		MHiOSManager.Instance.moveRowAtIndexPathToIndexPath(tag, indexPath, newIndexPath);
	}
	
	public void insertSectionsWithRowAnimation(int[] sections, MHTableViewRowAnimation animation)
	{
		MHiOSManager.Instance.insertSectionsWithRowAnimation(tag, sections, animation);
	}
	
	public void deleteSectionsWithRowAnimation(int[] sections, MHTableViewRowAnimation animation)
	{
		MHiOSManager.Instance.deleteSectionsWithRowAnimation(tag, sections, animation);
	}
	
	public void moveSectionToSection(int section, int newSection)
	{
		MHiOSManager.Instance.moveSectionToSection(tag, section, newSection);
	}
	
	public bool editing {
		get {
			return MHiOSManager.Instance.editing(tag);
		} set {
			MHiOSManager.Instance.editing(tag, value);
		}
	}

	public void setEditing(bool editing, bool animate)
	{
		MHiOSManager.Instance.setEditing(tag, editing, animate);
	}
	
	public void reloadData()
	{
		MHiOSManager.Instance.reloadData(tag);
	}
	
	public void reloadRowsAtIndexPathsWithRowAnimation(int[][] indexPaths, MHTableViewRowAnimation animation)
	{
		MHiOSManager.Instance.reloadRowsAtIndexPathsWithRowAnimation(tag, indexPaths, animation);
	}
	
	public void reloadSectionsWithRowAnimation(int[] sections, MHTableViewRowAnimation animation)
	{
		MHiOSManager.Instance.reloadSectionsWithRowAnimation(tag, sections, animation);
	}
	
	public void reloadSectionIndexTitles()
	{
		MHiOSManager.Instance.reloadSectionIndexTitles(tag);
	}
	
	public Rect rectForSection(int section)
	{
		return MHiOSManager.Instance.rectForSection(tag, section);
	}
	
	public Rect rectForRowAtIndexPath(int[] indexPath)
	{
		return MHiOSManager.Instance.rectForRowAtIndexPath(tag, indexPath);
	}
	
	public Rect rectForFooterInSection(int section)
	{
		return MHiOSManager.Instance.rectForFooterInSection(tag, section);
	}
	
	public Rect rectForHeaderInSection(int section)
	{
		return MHiOSManager.Instance.rectForHeaderInSection(tag, section);
	}
	
	public int sectionIndexMinimumDisplayRowCount {
		get {
			return MHiOSManager.Instance.sectionIndexMinimumDisplayRowCount(tag);
		} set {
			MHiOSManager.Instance.sectionIndexMinimumDisplayRowCount(tag, value);
		}
	}
	
	public Color sectionIndexColor {
		get {
			return MHiOSManager.Instance.sectionIndexColor(tag);
		} set {
			MHiOSManager.Instance.sectionIndexColor(tag, value);
		}
	}
	
	public Color sectionIndexBackgroundColor {
		get {
			return MHiOSManager.Instance.sectionIndexBackgroundColor(tag);
		} set {
			MHiOSManager.Instance.sectionIndexBackgroundColor(tag, value);
		}
	}
	
	public Color sectionIndexTrackingBackgroundColor {
		get {
			return MHiOSManager.Instance.sectionIndexTrackingBackgroundColor(tag);
		} set {
			MHiOSManager.Instance.sectionIndexTrackingBackgroundColor(tag, value);
		}
	}
	#endregion
	
	#region delegate
	public event Func<MHTableView, int[], float> tableViewHeightForRowAtIndexPath;
	public void _tableViewHeightForRowAtIndexPath(MHTableView tableView, int[] indexPath)
	{
		if(tableViewHeightForRowAtIndexPath != null)
			MHTools.ReturnResultToXCode((tableViewHeightForRowAtIndexPath(tableView, indexPath)).ToString());
		else
			MHTools.ReturnResultToXCode(rowHeight.ToString());
	}
	
	public event Func<MHTableView, int[], float> tableViewEstimatedHeightForRowAtIndexPath;
	public void _tableViewEstimatedHeightForRowAtIndexPath(MHTableView tableView, int[] indexPath)
	{
		if(tableViewEstimatedHeightForRowAtIndexPath != null)
			MHTools.ReturnResultToXCode((tableViewEstimatedHeightForRowAtIndexPath(tableView, indexPath)).ToString());
		else
			MHTools.ReturnResultToXCode(null); // UITableViewAutomaticDimension
	}
	
	public event Func<MHTableView, int[], int> tableViewIndentationLevelForRowAtIndexPath;
	public void _tableViewIndentationLevelForRowAtIndexPath(MHTableView tableView, int[] indexPath)
	{
		if(tableViewIndentationLevelForRowAtIndexPath != null)
			MHTools.ReturnResultToXCode((tableViewIndentationLevelForRowAtIndexPath(tableView, indexPath)).ToString());
		else
			MHTools.ReturnResultToXCode("0");
	}
	
	public event Action<MHTableView, MHTableViewCell, int[]> tableViewWillDisplayCellForRowAtIndexPath;
	public void _tableViewWillDisplayCellForRowAtIndexPath(MHTableView tableView, MHTableViewCell cell, int[] indexPath)
	{
		if(tableViewWillDisplayCellForRowAtIndexPath != null)
			tableViewWillDisplayCellForRowAtIndexPath(tableView, cell, indexPath);
	}

	public event Action<MHTableView, int[]> tableViewAccessoryButtonTappedForRowWithIndexPath;
	public void _tableViewAccessoryButtonTappedForRowWithIndexPath(MHTableView tableView, int[] indexPath)
	{
		if(tableViewAccessoryButtonTappedForRowWithIndexPath != null)
			tableViewAccessoryButtonTappedForRowWithIndexPath(tableView, indexPath);
	}
	
	public event Func<MHTableView, int[], int[]> tableViewWillSelectRowAtIndexPath;
	public void _tableViewWillSelectRowAtIndexPath(MHTableView tableView, int[] indexPath)
	{
		if(tableViewWillSelectRowAtIndexPath != null)
		{
			int[] returnPath = tableViewWillSelectRowAtIndexPath(tableView, indexPath);
			if(returnPath != null)
				MHTools.ReturnResultToXCode(MHTools.ConvertIntArrayToJson(returnPath));
			else
				MHTools.ReturnResultToXCode(null);
		}
		else
			MHTools.ReturnResultToXCode(MHTools.ConvertIntArrayToJson(indexPath));
	}
	
	public event Action<MHTableView, int[]> tableViewDidSelectRowAtIndexPath;
	public void _tableViewDidSelectRowAtIndexPath(MHTableView tableView, int[] indexPath)
	{
		if(tableViewDidSelectRowAtIndexPath != null)
			tableViewDidSelectRowAtIndexPath(tableView, indexPath);
	}
	
	public event Func<MHTableView, int[], int[]> tableViewWillDeselectRowAtIndexPath;
	public void _tableViewWillDeselectRowAtIndexPath(MHTableView tableView, int[] indexPath)
	{
		if(tableViewWillDeselectRowAtIndexPath != null)
		{
			int[] returnPath = tableViewWillSelectRowAtIndexPath(tableView, indexPath);
			if(returnPath != null)
				MHTools.ReturnResultToXCode(MHTools.ConvertIntArrayToJson(returnPath));
			else
				MHTools.ReturnResultToXCode(null);
		}
		else
			MHTools.ReturnResultToXCode(MHTools.ConvertIntArrayToJson(indexPath));
	}
	
	public event Action<MHTableView, int[]> tableViewDidDeselectRowAtIndexPath;
	public void _tableViewDidDeselectRowAtIndexPath(MHTableView tableView, int[] indexPath)
	{
		if(tableViewDidDeselectRowAtIndexPath != null)
			tableViewDidDeselectRowAtIndexPath(tableView, indexPath);
	}
	
	public event Func<MHTableView, int, MHView> tableViewViewForHeaderInSection;
	public void _tableViewViewForHeaderInSection(MHTableView tableView, int section)
	{
		if(tableViewViewForHeaderInSection != null)
			MHTools.ReturnResultToXCode((tableViewViewForHeaderInSection(tableView, section).tag).ToString());
		else
			MHTools.ReturnResultToXCode(null);
	}
	
	public event Func<MHTableView, int, MHView> tableViewViewForFooterInSection;
	public void _tableViewViewForFooterInSection(MHTableView tableView, int section)
	{
		if(tableViewViewForFooterInSection != null)
			MHTools.ReturnResultToXCode((tableViewViewForFooterInSection(tableView, section).tag).ToString());
		else
			MHTools.ReturnResultToXCode(null);
	}
	
	public event Func<MHTableView, int, float> tableViewHeightForHeaderInSection;
	public void _tableViewHeightForHeaderInSection(MHTableView tableView, int section)
	{
		if(tableViewHeightForHeaderInSection != null)
			MHTools.ReturnResultToXCode((tableViewHeightForHeaderInSection(tableView, section)).ToString());
		else
			MHTools.ReturnResultToXCode(sectionHeaderHeight.ToString());
	}
	
	public event Func<MHTableView, int, float> tableViewEstimatedHeightForHeaderInSection;
	public void _tableViewEstimatedHeightForHeaderInSection(MHTableView tableView, int section)
	{
		if(tableViewEstimatedHeightForHeaderInSection != null)
			MHTools.ReturnResultToXCode((tableViewEstimatedHeightForHeaderInSection(tableView, section)).ToString());
		else
			MHTools.ReturnResultToXCode(estimatedSectionHeaderHeight.ToString());
	}
	
	public event Func<MHTableView, int, float> tableViewHeightForFooterInSection;
	public void _tableViewHeightForFooterInSection(MHTableView tableView, int section)
	{
		if(tableViewHeightForFooterInSection != null)
			MHTools.ReturnResultToXCode((tableViewHeightForFooterInSection(tableView, section)).ToString());
		else
			MHTools.ReturnResultToXCode(sectionFooterHeight.ToString());
	}
	
	public event Func<MHTableView, int, float> tableViewEstimatedHeightForFooterInSection;
	public void _tableViewEstimatedHeightForFooterInSection(MHTableView tableView, int section)
	{
		if(tableViewEstimatedHeightForFooterInSection != null)
			MHTools.ReturnResultToXCode((tableViewEstimatedHeightForFooterInSection(tableView, section)).ToString());
		else
			MHTools.ReturnResultToXCode(estimatedSectionFooterHeight.ToString());
	}
	
	public event Action<MHTableView, MHView, int> tableViewWillDisplayHeaderViewForSection;
	public void _tableViewWillDisplayHeaderViewForSection(MHTableView tableView, MHView view, int section)
	{
		if(tableViewWillDisplayHeaderViewForSection != null)
			tableViewWillDisplayHeaderViewForSection(tableView, view, section);
	}
	
	public event Action<MHTableView, MHView, int> tableViewWillDisplayFooterViewForSection;
	public void _tableViewWillDisplayFooterViewForSection(MHTableView tableView, MHView view, int section)
	{
		if(tableViewWillDisplayFooterViewForSection != null)
			tableViewWillDisplayFooterViewForSection(tableView, view, section);
	}
	
	public event Action<MHTableView, int[]> tableViewWillBeginEditingRowAtIndexPath;
	public void _tableViewWillBeginEditingRowAtIndexPath(MHTableView tableView, int[] indexPath)
	{
		if(tableViewWillBeginEditingRowAtIndexPath != null)
			tableViewWillBeginEditingRowAtIndexPath(tableView, indexPath);
	}
	
	public event Action<MHTableView, int[]> tableViewDidEndEditingRowAtIndexPath;
	public void _tableViewDidEndEditingRowAtIndexPath(MHTableView tableView, int[] indexPath)
	{
		if(tableViewDidEndEditingRowAtIndexPath != null)
			tableViewDidEndEditingRowAtIndexPath(tableView, indexPath);
	}
	
	public event Func<MHTableView, int[], MHTableViewCellEditingStyle> tableViewEditingStyleForRowAtIndexPath;
	public void _tableViewEditingStyleForRowAtIndexPath(MHTableView tableView, int[] indexPath)
	{
		if(tableViewEditingStyleForRowAtIndexPath != null)
			MHTools.ReturnResultToXCode(((int)tableViewEditingStyleForRowAtIndexPath(tableView, indexPath)).ToString());
		else
			MHTools.ReturnResultToXCode(((int)MHTableViewCellEditingStyle.MHTableViewCellEditingStyleDelete).ToString());
	}
	
	public event Func<MHTableView, int[], string> tableViewTitleForDeleteConfirmationButtonForRowAtIndexPath;
	public void _tableViewTitleForDeleteConfirmationButtonForRowAtIndexPath(MHTableView tableView, int[] indexPath)
	{
		if(tableViewTitleForDeleteConfirmationButtonForRowAtIndexPath != null)
			MHTools.ReturnResultToXCode(tableViewTitleForDeleteConfirmationButtonForRowAtIndexPath(tableView, indexPath));
		else
			MHTools.ReturnResultToXCode("Delete");
	}
	
	public event Func<MHTableView, int[], string> tableViewShouldIndentWhileEditingRowAtIndexPath;
	public void _tableViewShouldIndentWhileEditingRowAtIndexPath(MHTableView tableView, int[] indexPath)
	{
		if(tableViewShouldIndentWhileEditingRowAtIndexPath != null)
			MHTools.ReturnResultToXCode((tableViewShouldIndentWhileEditingRowAtIndexPath(tableView, indexPath)).ToString());
		else
			MHTools.ReturnResultToXCode("true");
	}
	
	public event Func<MHTableView, int[], int[], int[]> tableViewTargetIndexPathForMoveFromRowAtIndexPathToProposedIndexPath;
	public void _tableViewTargetIndexPathForMoveFromRowAtIndexPathToProposedIndexPath(MHTableView tableView, int[] sourceIndexPath, int[] proposedDestinationIndexPath)
	{
		if(tableViewTargetIndexPathForMoveFromRowAtIndexPathToProposedIndexPath != null)
		{
			int[] returnPath = tableViewTargetIndexPathForMoveFromRowAtIndexPathToProposedIndexPath(tableView, sourceIndexPath, proposedDestinationIndexPath);
			if(returnPath != null)
				MHTools.ReturnResultToXCode(MHTools.ConvertIntArrayToJson(returnPath));
			else
				MHTools.ReturnResultToXCode(null);
		}
		else
			MHTools.ReturnResultToXCode(MHTools.ConvertIntArrayToJson(sourceIndexPath));
	}
	
	public event Action<MHTableView, MHTableViewCell, int[]> tableViewDidEndDisplayingCellForRowAtIndexPath;
	public void _tableViewDidEndDisplayingCellForRowAtIndexPath(MHTableView tableView, MHTableViewCell cell, int[] indexPath)
	{
		if(tableViewDidEndDisplayingCellForRowAtIndexPath != null)
			tableViewDidEndDisplayingCellForRowAtIndexPath(tableView, cell, indexPath);
	}
	
	public event Action<MHTableView, MHView, int> tableViewDidEndDisplayingHeaderViewForSection;
	public void _tableViewDidEndDisplayingHeaderViewForSection(MHTableView tableView, MHView view, int section)
	{
		if(tableViewDidEndDisplayingHeaderViewForSection != null)
			tableViewDidEndDisplayingHeaderViewForSection(tableView, view, section);
	}
	
	public event Action<MHTableView, MHView, int> tableViewDidEndDisplayingFooterViewForSection;
	public void _tableViewDidEndDisplayingFooterViewForSection(MHTableView tableView, MHView view, int section)
	{
		if(tableViewDidEndDisplayingFooterViewForSection != null)
			tableViewDidEndDisplayingFooterViewForSection(tableView, view, section);
	}
	
	public event Func<MHTableView, int[], bool> tableViewShouldShowMenuForRowAtIndexPath;
	public void _tableViewShouldShowMenuForRowAtIndexPath(MHTableView tableView, int[] indexPath)
	{
		if(tableViewShouldShowMenuForRowAtIndexPath != null)
			MHTools.ReturnResultToXCode((tableViewShouldShowMenuForRowAtIndexPath(tableView, indexPath)).ToString());
		else
			MHTools.ReturnResultToXCode("false");
	}
	
	public event Func<MHTableView, int[], bool> tableViewShouldHighlightRowAtIndexPath;
	public void _tableViewShouldHighlightRowAtIndexPath(MHTableView tableView, int[] indexPath)
	{
		if(tableViewShouldHighlightRowAtIndexPath != null)
			MHTools.ReturnResultToXCode((tableViewShouldHighlightRowAtIndexPath(tableView, indexPath)).ToString());
		else
			MHTools.ReturnResultToXCode("true");
	}
	
	public event Action<MHTableView, int[]> tableViewDidHighlightRowAtIndexPath;
	public void _tableViewDidHighlightRowAtIndexPath(MHTableView tableView, int[] indexPath)
	{
		if(tableViewDidHighlightRowAtIndexPath != null)
			tableViewDidHighlightRowAtIndexPath(tableView, indexPath);
	}
	
	public event Action<MHTableView, int[]> tableViewDidUnhighlightRowAtIndexPath;
	public void _tableViewDidUnhighlightRowAtIndexPath(MHTableView tableView, int[] indexPath)
	{
		if(tableViewDidUnhighlightRowAtIndexPath != null)
			tableViewDidUnhighlightRowAtIndexPath(tableView, indexPath);
	}
	#endregion
	
	#region datasource
	public event Func<MHTableView, int[], MHTableViewCell> tableViewCellForRowAtIndexPath;
	public void _tableViewCellForRowAtIndexPath(MHTableView tableView, int[] indexPath)
	{
		if(tableViewCellForRowAtIndexPath == null)
			Debug.LogError("ERROR!! Your TableView DataSource is not completely assigned! You must implement this function.");
		MHTools.ReturnResultToXCode(((tableViewCellForRowAtIndexPath(tableView, indexPath)).tag).ToString());
	}
	
	public event Func<MHTableView, int> numberOfSectionsInTableView;
	public void _numberOfSectionsInTableView(MHTableView tableView)
	{
		if(numberOfSectionsInTableView != null)
			MHTools.ReturnResultToXCode((numberOfSectionsInTableView(tableView)).ToString());
		else
			MHTools.ReturnResultToXCode("1");
	}
	
	public event Func<MHTableView, int, int> tableViewNumberOfRowsInSection;
	public void _tableViewNumberOfRowsInSection(MHTableView tableView, int section)
	{
		if(tableViewNumberOfRowsInSection == null)
			Debug.LogError("ERROR!! Your TableView DataSource is not completely assigned! You must implement this function.");
		MHTools.ReturnResultToXCode((tableViewNumberOfRowsInSection(tableView, section)).ToString());
	}
	
	public event Func<MHTableView, string[]> sectionIndexTitlesForTableView;
	public void _sectionIndexTitlesForTableView(MHTableView tableView)
	{
		if(sectionIndexTitlesForTableView != null)
		{
			string[] returnPath = sectionIndexTitlesForTableView(tableView);
			if(returnPath != null)
				MHTools.ReturnResultToXCode(MHTools.ConvertStringArrayToJson(returnPath));
			else
				MHTools.ReturnResultToXCode(null);
		}
		else
			MHTools.ReturnResultToXCode(null);
	}
	
	public event Func<MHTableView, string, int, int> tableViewSectionForSectionIndexTitleAtIndex;
	public void _tableViewSectionForSectionIndexTitleAtIndex(MHTableView tableView, string title, int index)
	{
		if(tableViewSectionForSectionIndexTitleAtIndex != null)
			MHTools.ReturnResultToXCode((tableViewSectionForSectionIndexTitleAtIndex(tableView, title, index)).ToString());
		else
			MHTools.ReturnResultToXCode(null);
	}
	
	public event Func<MHTableView, int, string> tableViewTitleForFooterInSection;
	public void _tableViewTitleForFooterInSection(MHTableView tableView, int section)
	{
		if(tableViewTitleForFooterInSection != null)
			MHTools.ReturnResultToXCode(tableViewTitleForFooterInSection(tableView, section));
		else
			MHTools.ReturnResultToXCode(null);
	}
	
	public event Func<MHTableView, int, string> tableViewTitleForHeaderInSection;
	public void _tableViewTitleForHeaderInSection(MHTableView tableView, int section)
	{
		if(tableViewTitleForHeaderInSection != null)
			MHTools.ReturnResultToXCode(tableViewTitleForHeaderInSection(tableView, section));
		else
			MHTools.ReturnResultToXCode(null);
	}
	
	public event Action<MHTableView, MHTableViewCellEditingStyle, int[]> tableViewCommitEditingStyleForRowAtIndexPath;
	public void _tableViewCommitEditingStyleForRowAtIndexPath(MHTableView tableView, MHTableViewCellEditingStyle editingStyle, int[] indexPath)
	{
		if(tableViewCommitEditingStyleForRowAtIndexPath != null)
			tableViewCommitEditingStyleForRowAtIndexPath(tableView, editingStyle, indexPath);
	}
	
	public event Func<MHTableView, int[], bool> tableViewCanEditRowAtIndexPath;
	public void _tableViewCanEditRowAtIndexPath(MHTableView tableView, int[] indexPath)
	{
		if(tableViewCanEditRowAtIndexPath != null)
			MHTools.ReturnResultToXCode(tableViewCanEditRowAtIndexPath(tableView, indexPath).ToString());
		else
			MHTools.ReturnResultToXCode("true");
	}
	
	public event Func<MHTableView, int[], bool> tableViewCanMoveRowAtIndexPath;
	public void _tableViewCanMoveRowAtIndexPath(MHTableView tableView, int[] indexPath)
	{
		if(tableViewCanMoveRowAtIndexPath != null)
			MHTools.ReturnResultToXCode(tableViewCanMoveRowAtIndexPath(tableView, indexPath).ToString());
		else
		{
			if(tableViewMoveRowAtIndexPathToIndexPath != null)
				MHTools.ReturnResultToXCode("true");
			else
				MHTools.ReturnResultToXCode("false");
		}
	}
	
	public event Action<MHTableView, int[], int[]> tableViewMoveRowAtIndexPathToIndexPath;
	public void _tableViewMoveRowAtIndexPathToIndexPath(MHTableView tableView, int[] fromIndexPath, int[] toIndexPath)
	{
		if(tableViewMoveRowAtIndexPathToIndexPath != null)
			tableViewMoveRowAtIndexPathToIndexPath(tableView, fromIndexPath, toIndexPath);
	}
	#endregion
}
