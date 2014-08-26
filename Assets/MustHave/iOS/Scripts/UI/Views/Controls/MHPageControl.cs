using UnityEngine;
using System.Collections;

public class MHPageControl : MHControl {

	#region functions
	public MHPageControl(){}
	
	public MHPageControl(bool autoInitialize)
	{
		if(Application.isPlaying && autoInitialize)
			init();
	}
	
	public MHPageControl(Rect aRect)
	{
		if(Application.isPlaying)
			initWithFrame(aRect);
	}
	
	new public MHPageControl init()
	{
		return MHiOSManager.Instance.init_pagecontrol(tag);
	}
	
	new public MHPageControl initWithFrame(Rect aRect)
	{
		return MHiOSManager.Instance.initWithFrame_pagecontrol(tag, aRect);
	}
	
	public int currentPage {
		get {
			return MHiOSManager.Instance.currentPage(tag);
		} set {
			MHiOSManager.Instance.currentPage(tag, value);
		}
	}
	
	public int numberOfPages {
		get {
			return MHiOSManager.Instance.numberOfPages(tag);
		} set {
			MHiOSManager.Instance.numberOfPages(tag, value);
		}
	}
	
	public bool hidesForSinglePage {
		get {
			return MHiOSManager.Instance.hidesForSinglePage(tag);
		} set {
			MHiOSManager.Instance.hidesForSinglePage(tag, value);
		}
	}
	
	public Color pageIndicatorTintColor {
		get {
			return MHiOSManager.Instance.pageIndicatorTintColor(tag);
		} set {
			MHiOSManager.Instance.pageIndicatorTintColor(tag, value);
		}
	}
	
	public Color currentPageIndicatorTintColor {
		get {
			return MHiOSManager.Instance.currentPageIndicatorTintColor(tag);
		} set {
			MHiOSManager.Instance.currentPageIndicatorTintColor(tag, value);
		}
	}
	
	public bool defersCurrentPageDisplay {
		get {
			return MHiOSManager.Instance.defersCurrentPageDisplay(tag);
		} set {
			MHiOSManager.Instance.defersCurrentPageDisplay(tag, value);
		}
	}
	
	public void updateCurrentPageDisplay()
	{
		MHiOSManager.Instance.updateCurrentPageDisplay(tag);
	}
	
	public Vector2 sizeForNumberOfPages(int pageCount)
	{
		return MHiOSManager.Instance.sizeForNumberOfPages(tag, pageCount);
	}
	#endregion
}
