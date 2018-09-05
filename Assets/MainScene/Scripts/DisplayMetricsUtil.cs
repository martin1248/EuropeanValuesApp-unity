using UnityEngine;
using System.Collections;

public static class DisplayMetricsUtil
{
	private const float DEFAULT_DPI = 160.0f;
	private const float PC_DPI = 104.0f; // Usually between 95(Work PC) and 101(My laptop)
	private static ScreenSize screenSize;
	private static bool screenSizeInitialised = false;

	public enum ResolutionType
	{
		ldpi,
		mdpi,
		hdpi,
		xhdpi
	}

	/**
	 * 1) Basically everything is designed for "smartphone"
	 * 2) In case of "tablet" some things are bigger.(Like text)
	 * 3) And for the small smartphones (and there are not many and support is not so important) some things are smaller.
	 */
	public enum ScreenSize
	{
		smartphoneSmall,
		smartphone,
		tablet
	}

	
	public static Vector2 DpToPixel(this Vector2 vector)
	{
		return new Vector2(vector.x.DpToPixel(), vector.y.DpToPixel());
	}
	
	public static Vector3 DpToPixel(this Vector3 vector)
	{
		return new Vector3(vector.x.DpToPixel(), vector.y.DpToPixel(), vector.z.DpToPixel());
	}
	
	public static Rect DpToPixel(this Rect rect)
	{
		return new Rect(rect.x.DpToPixel(), rect.y.DpToPixel(), rect.width.DpToPixel(), rect.height.DpToPixel());
	}
	
	public static int DpToPixel(this int dp)
	{
		// Convert the dps to pixels
		return (int) (dp * GetScale() + 0.5f);
	}
	
	public static int DpToPixel(this float dp)
	{
		// Convert the dps to pixels
		return (int) (dp * GetScale() + 0.5f);
	}
	
	public static int PixelToDp(this int px)
	{
		// Convert the pxs to dps
		return (int) (px / GetScale() - 0.5f);
	}
	
	public static int PixelToDp(this float px)
	{
		// Convert the pxs to dps
		return (int) (px / GetScale() - 0.5f);
	}
	
	
	public static GUIStyle DpToPixel(this GUIStyle style)
	{
		GUIStyle stylePx = new GUIStyle(style);
		stylePx.border = stylePx.border.DpToPixel();
		stylePx.padding = stylePx.padding.DpToPixel();
		stylePx.margin = stylePx.margin.DpToPixel();
		stylePx.overflow = stylePx.overflow.DpToPixel();
		stylePx.contentOffset = stylePx.contentOffset.DpToPixel();
		stylePx.fixedWidth = stylePx.fixedWidth.DpToPixel();
		stylePx.fixedHeight = stylePx.fixedHeight.DpToPixel();
		stylePx.fontSize = stylePx.fontSize.DpToPixel();
		
		return stylePx;
	}
	
	
	public static RectOffset DpToPixel(this RectOffset rectOffset)
	{
		return new RectOffset(
			rectOffset.left.DpToPixel(),
			rectOffset.right.DpToPixel(),
			rectOffset.top.DpToPixel(),
			rectOffset.bottom.DpToPixel());
	}
	
	public static ResolutionType GetResolutionType()
	{	
		float scale = GetDPI() / DEFAULT_DPI;

		ResolutionType res;
		//http://developer.android.com/guide/practices/screens_support.html
		if(scale > 1.5f)
		{
			res = DisplayMetricsUtil.ResolutionType.xhdpi;
		}
		else if(scale > 1f)
		{
			res = DisplayMetricsUtil.ResolutionType.hdpi;
		}
		else if(scale > 0.75f)
		{
			res = DisplayMetricsUtil.ResolutionType.mdpi;
		}
		else
		{
			res = DisplayMetricsUtil.ResolutionType.ldpi;
		}
		
		return res;
	}

	private static ScreenSize GetScreenSize()
	{
		if (screenSizeInitialised) {
			return screenSize;
		}

		float shortSideDP = PixelToDp (GetShortSide());

		ScreenSize size;

		if (shortSideDP > 500) {
			size = DisplayMetricsUtil.ScreenSize.tablet;
		} else if (shortSideDP < 300) {
			size = DisplayMetricsUtil.ScreenSize.smartphoneSmall;
		} else {
			size = DisplayMetricsUtil.ScreenSize.smartphone;
		}

		screenSize = size;
		screenSizeInitialised = true;
		return size;
	}

	public static bool IsScreenSizeSmartphoneSmall () {
		return GetScreenSize() == ScreenSize.smartphoneSmall;
	}
	
	public static bool IsScreenSizeSmartphone () {
		return GetScreenSize() == ScreenSize.smartphone;
	}

	public static bool IsScreenSizeTablet () {
		return GetScreenSize() == ScreenSize.tablet;
	}
	
	public static float GetDPI_Debug(){
		return GetDPI();
	}

	private static float GetDPI() {
		float dpi = Screen.dpi <= 0 ? DEFAULT_DPI : Screen.dpi;

		if (DisplayMetricsAndroid.IsAndroid) {
			if (DisplayMetricsAndroid.DensityDPI > 0 ) {
				dpi = DisplayMetricsAndroid.DensityDPI;
			}
		}

		// CASE: EDITOR / PC
		#if UNITY_EDITOR
		        dpi = PC_DPI;
        #endif
        #if UNITY_STANDALONE
		        dpi = PC_DPI;
        #endif

        return dpi;
	}

	private static float GetScale()
	{
		return GetDPI() / DEFAULT_DPI;
	}

	public static ScreenSize GetScreenSize_DEBUG(){
		return screenSize;
	}

	public static float GetScale_DEBUG(){
		return GetScale();
	}
	
	public static int GetLongSide(){
		if (Screen.width >= Screen.height) {
			return Screen.width;
		}
		return Screen.height;
	}

	public static int GetShortSide(){
		if (Screen.width < Screen.height) {
			return Screen.width;
		}
		return Screen.height;
	}

	public static bool isScreenPortrait() {
		return Screen.height > Screen.width;
	}

	public static float GetShortSideInInch() {
		return (float) System.Math.Round(GetShortSide() / GetDPI(), 1);
	}

	public static float GetShortSideInCentimeters() {
		return (float) System.Math.Round (GetShortSide () / GetDPI () * 2.54f, 1);
	}

	public static int GetShortSideInDP() {
		return DisplayMetricsUtil.PixelToDp (DisplayMetricsUtil.GetShortSide ());
	}

	public static float GetLongSideInInch() {
		return (float) System.Math.Round(GetLongSide() / GetDPI(), 1);
	}
	
	public static float GetLongSideInCentimeters() {
		return (float) System.Math.Round (GetLongSide () / GetDPI () * 2.54f, 1);
	}

	public static int GetLongSideInDP() {
		return DisplayMetricsUtil.PixelToDp (DisplayMetricsUtil.GetLongSide ());
	}
}
