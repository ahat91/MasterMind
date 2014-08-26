using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public partial class MHiOSManager : Singleton<MHiOSManager> {
	#region slider
	[DllImport("__Internal")]
    private static extern int _init_pagecontrol(int tag);
	public MHPageControl init_pagecontrol(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return GetObjectByUniqueTag(_init_pagecontrol(tag)) as MHPageControl;
		}
		else
			return new MHPageControl();
	}
	
	[DllImport("__Internal")]
    private static extern int _initWithFrame_pagecontrol(int tag, string aRect);
	public MHPageControl initWithFrame_pagecontrol(int tag, Rect aRect)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string rectJsonString = MHTools.ConvertRectToJSON(aRect);
			
			return GetObjectByUniqueTag(_initWithFrame_pagecontrol(tag, rectJsonString)) as MHPageControl;
		}
		else
			return new MHPageControl();
	}
	
	[DllImport("__Internal")]
    private static extern int _currentPage(int tag);
	public int currentPage(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _currentPage(tag);
		}
		else
			return 0;
	}
	
	[DllImport("__Internal")]
    private static extern void _currentPage_set(int tag, int page);
	public void currentPage(int tag, int page)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_currentPage_set(tag, page);
		}
	}
	
	[DllImport("__Internal")]
    private static extern int _numberOfPages(int tag);
	public int numberOfPages(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _numberOfPages(tag);
		}
		else
			return 0;
	}
	
	[DllImport("__Internal")]
    private static extern void _numberOfPages_set(int tag, int num);
	public void numberOfPages(int tag, int num)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_numberOfPages_set(tag, num);
		}
	}
	
	[DllImport("__Internal")]
    private static extern bool _hidesForSinglePage(int tag);
	public bool hidesForSinglePage(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _hidesForSinglePage(tag);
		}
		else
			return false;
	}
	
	[DllImport("__Internal")]
    private static extern void _hidesForSinglePage_set(int tag, bool hides);
	public void hidesForSinglePage(int tag, bool hides)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_hidesForSinglePage_set(tag, hides);
		}
	}
	
	[DllImport("__Internal")]
    private static extern string _pageIndicatorTintColor(int tag);
	public Color pageIndicatorTintColor(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string colorJsonString = _pageIndicatorTintColor(tag);
			
			return MHTools.ConvertUIColorToColor(colorJsonString);
		}
		else
			return Color.black;
	}
	
	[DllImport("__Internal")]
    private static extern void _pageIndicatorTintColor_set(int tag, string col);
	public void pageIndicatorTintColor(int tag, Color col)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string colorJsonString = MHTools.ConvertColorToUIColor(col);
			
			_pageIndicatorTintColor_set(tag, colorJsonString);
		}
	}
	
	[DllImport("__Internal")]
    private static extern string _currentPageIndicatorTintColor(int tag);
	public Color currentPageIndicatorTintColor(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string colorJsonString = _currentPageIndicatorTintColor(tag);
			
			return MHTools.ConvertUIColorToColor(colorJsonString);
		}
		else
			return Color.black;
	}
	
	[DllImport("__Internal")]
    private static extern void _currentPageIndicatorTintColor_set(int tag, string col);
	public void currentPageIndicatorTintColor(int tag, Color col)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string colorJsonString = MHTools.ConvertColorToUIColor(col);
			
			_currentPageIndicatorTintColor_set(tag, colorJsonString);
		}
	}
	
	[DllImport("__Internal")]
    private static extern bool _defersCurrentPageDisplay(int tag);
	public bool defersCurrentPageDisplay(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			return _defersCurrentPageDisplay(tag);
		}
		else
			return false;
	}
	
	[DllImport("__Internal")]
    private static extern void _defersCurrentPageDisplay_set(int tag, bool defer);
	public void defersCurrentPageDisplay(int tag, bool defer)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_defersCurrentPageDisplay_set(tag, defer);
		}
	}
	
	[DllImport("__Internal")]
    private static extern void _updateCurrentPageDisplay(int tag);
	public void updateCurrentPageDisplay(int tag)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			_updateCurrentPageDisplay(tag);
		}
	}
	
	[DllImport("__Internal")]
    private static extern string _sizeForNumberOfPages(int tag, int pageCount);
	public Vector2 sizeForNumberOfPages(int tag, int pageCount)
	{
		if( Application.platform == RuntimePlatform.IPhonePlayer )
        {
			string vectorJsonString = _sizeForNumberOfPages(tag, pageCount);
			
			return MHTools.ConvertJSONToVector2(vectorJsonString);
		}
		else 
			return Vector2.zero;
	}
	#endregion
}
