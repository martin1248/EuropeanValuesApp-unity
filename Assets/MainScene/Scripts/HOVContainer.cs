using UnityEngine;
using System.Collections;

public class HOVContainer {
	public static HOVComponent[] hovComponents = new HOVComponent[19];
	public static int spaceBetweenTitlebarAndHistoryTexture = DisplayMetricsUtil.DpToPixel (1);
	public static Color colorYellow 		= new Color(254/255.0f, 204/255.0f, 0);
	public static Color colorOrange 		= new Color(254/255.0f, 102/255.0f, 0);
	public static Color colorRed 			= new Color(254/255.0f, 0,0);
	public static Color colorViolet 		= new Color(117/255.0f, 72/255.0f, 254/255.0f);
	public static Color colorBlueDark 		= new Color(0, 64/255.0f, 254/255.0f);
	public static Color colorBlueBright 	= new Color(105/255.0f, 180/255.0f, 235/255.0f);
	public const float scale1750To1024 = 1024.0f / 1750.0f;
	public static Vector2 valuePos1 = new Vector2 (130, 162);
	public static Vector2 valuePos2 = new Vector2 (760, 162);
	public static Vector2 valuePos3 = new Vector2 (1634, 270);
	public static Vector2 valuePos4 = new Vector2 (1380, 400);

	public static float textureHistoryWidth;
	public static float textureHistoryHeight;
	public static float textureHistoryScale;

	public static int textureAdditionalWidth;
	public static int textureAdditionalHeight;

	public static int textureValuesWidth;

	public static int timeAgeTextY = 89;
	public static int timeAgeTextX1 = 50;
	public static int timeAgeTextX2 = 595;
	public static int timeAgeTextX3 = 965;
	public static int timeAgeTextX4 = 1495;
	public static int timeAgeTextX5 = 1700;
	public static Rect timeAgeTextRect1;
	public static Rect timeAgeTextRect2;
	public static Rect timeAgeTextRect3;
	public static Rect timeAgeTextRect4;

	public static void init(int textureHistoryOrigWidth, int textureHistoryOrigHeight){
		float percentWidthOfScreen = 0.97f; 

		textureHistoryWidth = DisplayMetricsUtil.GetLongSide () * percentWidthOfScreen;
		textureHistoryHeight = textureHistoryWidth * textureHistoryOrigHeight / textureHistoryOrigWidth;
		textureHistoryScale = textureHistoryWidth / textureHistoryOrigWidth;

		valuePos1 = new Vector2(valuePos1.x*scale1750To1024*textureHistoryScale, valuePos1.y*scale1750To1024*textureHistoryScale);
		valuePos2 = new Vector2(valuePos2.x*scale1750To1024*textureHistoryScale, valuePos2.y*scale1750To1024*textureHistoryScale);
		valuePos3 = new Vector2(valuePos3.x*scale1750To1024*textureHistoryScale, valuePos3.y*scale1750To1024*textureHistoryScale);
		valuePos4 = new Vector2(valuePos4.x*scale1750To1024*textureHistoryScale, valuePos4.y*scale1750To1024*textureHistoryScale);

		timeAgeTextY = Mathf.RoundToInt(timeAgeTextY * scale1750To1024 * textureHistoryScale);
		timeAgeTextX1 = Mathf.RoundToInt(timeAgeTextX1 * scale1750To1024 * textureHistoryScale);
		timeAgeTextX2 = Mathf.RoundToInt(timeAgeTextX2 * scale1750To1024 * textureHistoryScale);
		timeAgeTextX3 = Mathf.RoundToInt(timeAgeTextX3 * scale1750To1024 * textureHistoryScale);
		timeAgeTextX4 = Mathf.RoundToInt(timeAgeTextX4 * scale1750To1024 * textureHistoryScale);
		timeAgeTextX5 = Mathf.RoundToInt(timeAgeTextX5 * scale1750To1024 * textureHistoryScale);

		Vector2 size = Master.styleTextDefault.CalcSize (new GUIContent ("Altertum"));
		timeAgeTextRect1 = calcTimeAgeTextRect (timeAgeTextX2, timeAgeTextX1, size.y);
		timeAgeTextRect2 = calcTimeAgeTextRect (timeAgeTextX3, timeAgeTextX2, size.y);
		timeAgeTextRect3 = calcTimeAgeTextRect (timeAgeTextX4, timeAgeTextX3, size.y);
		timeAgeTextRect4 = calcTimeAgeTextRect (timeAgeTextX5, timeAgeTextX4, size.y);

		float tmp = DisplayMetricsUtil.GetLongSideInDP()/8f;
		if (tmp >= 100) {
			textureValuesWidth = Mathf.RoundToInt(DisplayMetricsUtil.DpToPixel (100));
		}
		else 
		{
			textureValuesWidth = Mathf.RoundToInt(DisplayMetricsUtil.DpToPixel (tmp));
		}

		textureAdditionalHeight = Mathf.RoundToInt(DisplayMetricsUtil.DpToPixel (100));
		textureAdditionalWidth = Mathf.RoundToInt(DisplayMetricsUtil.DpToPixel (80));
	}

	private static Rect calcTimeAgeTextRect(int timeAgeTextXb, int timeAgeTextXa, float timeAgeTextHeigth){
		int addY = Mathf.RoundToInt(timeAgeTextY / 2 - timeAgeTextHeigth / 2);
		return new Rect (Master.globalContentPadding + timeAgeTextXa + Master.globalContentPadding, Master.titleBarHeightInCaseOfLandscape + spaceBetweenTitlebarAndHistoryTexture + addY, 0, HOVContainer.timeAgeTextY);
	}
}
