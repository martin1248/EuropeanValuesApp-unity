using UnityEngine;
using System.Collections;

/**
 * !!!!! See all fields as "STATIC FINAL" = CONSTANTS
 * 			- Fields are only set in Master.Start()
 * 			- Do not set from outside.
 * !!!!!  All fields in "dp" not in "pixels"
 */
public class Master : MyMonoBehaviour {
	public static bool initialized = false;
	//
	// These are passed from Editor
	//
	public Texture2D backgroundTextureX;
	//public Texture2D blackTransparentTextureX;
	public Texture2D titleBarTextureX;
	public Texture2D whiteToAlphaTextureX;
	public Texture2D alphaToWhiteTextureX;
	public Texture2D mainMenuButtonTextureX;
	public Texture2D boxRedX;
	public Texture2D boxTorquiseX;
	//public Texture2D boxGreyWhiteX;
	//public Texture2D boxWhiteGreyX;
	public Texture2D boxGreyLineOnTopX;
	public Texture2D buttonTorquiseX;
	//public Texture2D lightGreyPointX;
	public GUISkin menuSkinX;
	public Font fontRegularX;
	public Font fontBoldX;
	public Font fontBoldItalicX;
	public Font fontItalicX;
	//Image-Textures
	public Texture2D h1X;
	public Texture2D h2X;
	public Texture2D h3X;
	public Texture2D h4X;
	public Texture2D h5X;
	public Texture2D v1X;
	public Texture2D v2X;
	public Texture2D v3X;
	public Texture2D v4X;
	public Texture2D v5X;
	public Texture2D v6X;
	public Texture2D v1lX;
	public Texture2D v2lX;
	public Texture2D v3lX;
	public Texture2D v4lX;
	public Texture2D v5lX;
	public Texture2D v6lX;
	public Texture2D p1X;
	public Texture2D p2X;
	public Texture2D p3aX;
	public Texture2D p3bX;
	public Texture2D p4aX;
	public Texture2D p4bX;
	public Texture2D p5X;
	public Texture2D p6X;
	public Texture2D circle1X;
	public Texture2D circle2X;
	public Texture2D circle3X;
	public Texture2D circle3aX;
	public Texture2D circle4X;
	public Texture2D circle5X;
	public Texture2D circle5aX;
	public Texture2D circle6X;
	public Texture2D circle6aX;
	public Texture2D circle7X;
	public Texture2D circle7aX;
	//public Texture2D churchTextureX;
	//public Texture2D emperorTextureX;
	public Texture2D questionMarkTextureX;
	public Texture2D arrowLeftX;
	public Texture2D arrowRightX;
	public Texture2D infoTextureX;
	public Texture2D facebookTextureX;
	public Texture2D menuIconDefaultX;
	//
	// STATIC fields - Copies from above
	//
	public static Texture2D backgroundTexture;
	//public static Texture2D blackTransparentTexture;
	public static Texture2D titleBarTexture;
	public static Texture2D whiteToAlphaTexture;
	public static Texture2D alphaToWhiteTexture;
	public static Texture2D mainMenuButtonTextureBASE;
	public static Texture2D buttonDefaultTexture;
	public static Texture2D boxRed;
	public static Texture2D boxTorquise;
	//public static Texture2D boxGreyWhite;
	//public static Texture2D boxWhiteGrey;
	public static Texture2D boxGreyLineOnTop;
	public static Texture2D buttonTorquise;
	//public static Texture2D lightGreyPoint;
	public static GUISkin menuSkin;
	public static Font fontRegular;
	public static Font fontBold;
	public static Font fontBoldItalic;
	public static Font fontItalic;
	public static Texture2D arrowLeftI;
	public static Texture2D arrowRightI;
	public static Texture2D infoTextureI;
	public static Texture2D facebookI;
	public static Texture2D listI;
	public static Texture2D facebookTexture;
	public static Texture2D menuIconDefault;
	public static Texture2D menuIconQuestionMark;
	
	//
	// STATIC fields - assigned in Start() method
	//
	// BASE VALUES
	private static int baseFontSizeInDP;
	private static int baseGuiElementHeightInDP;
	private static int baseGuiElementPaddingInDP;
	private static int baseGlobalContentPadding;
	private static int baseTitleBarHeightInCaseOfPortrait;
	private static int baseTitleBarHeightInCaseOfLandscape;
	private static int baseTitleBarButtonHeight;
	public static int fontSizeDefault;
	public static int guiElementHeightDefault;
	public static int guiElementPaddingDefault;
	public static int buttonHeightDefault;
	public static int titleBarHeightInCaseOfPortrait;
	public static int titleBarHeightInCaseOfLandscape;
	public static int titleBarButtonHeight;
	// --------------------
	public static Texture2D mainMenuButtonTexture;
	public static int globalContentPadding;
	public static GUIStyle styleTextDefault;
	public static GUIStyle styleTextDefaultBold;
	public static GUIStyle styleTextDefaultBoldItalic;
	public static GUIStyle styleTextDefaultBoldPadding;
	public static GUIStyle styleTextDefaultItalic;
	public static GUIStyle styleTextDefaultPadding;
	public static GUIStyle styleTextDefaultCenter;
	public static GUIStyle styleTextDefaultCenterItalic;
	public static GUIStyle styleTextDefaultTorquise;
	public static GUIStyle styleTextDefaultRed;
	public static GUIStyle styleTextBigYellow;
	public static GUIStyle styleTextSmall;
	public static GUIStyle styleTextSmallPadding;
	public static GUIStyle styleTextSmallItalic;
	public static GUIStyle styleTextSmallCenter;
	public static GUIStyle styleTextSmallCenterItalic;
	public static GUIStyle styleTextBig;
	public static GUIStyle styleTextBigBold;
	public static GUIStyle styleTextBigBoldPadding;
	public static GUIStyle styleTextHeader;
	public static GUIStyle styleTextHeaderCenter;
	public static GUIStyle styleTextHeaderPadding;
	public static GUIStyle styleTextTitleBar;
	public static GUIStyle styleTextStartSceneBig;
	public static GUIStyle styleTextStartSceneSmall;
	public static GUIStyle styleTextMenu;
	public static GUIStyle styleTextAppCode;
	public static GUIStyle styleButtonNoStyle;
	public static GUIStyle styleButtonNoStyleCentered;
	public static GUIStyle styleButtonNoStyleCenteredPadding;
	public static GUIStyle styleButtonDefault;
	public static GUIStyle styleButtonTorquise;
	public static GUIStyle styleButtonFacebook;
	public static GUIStyle styleBoxRed;
	public static GUIStyle styleBoxTorquise;
	//public static GUIStyle styleBoxGreyWhite;
	public static GUIStyle styleBoxGreyLineOnTop;
	//public static GUIStyle styleBoxWhiteGrey;

	public static Texture2D v1p;
	public static Texture2D v2p;
	public static Texture2D v3p;
	public static Texture2D v4p;
	public static Texture2D v5p;
	public static Texture2D v6p;
	public static Texture2D v1b;
	public static Texture2D v2b;
	public static Texture2D v3b;
	public static Texture2D v4b;
	public static Texture2D v5b;
	public static Texture2D v6b;

	public static Texture2D p1;
	public static Texture2D p2;
	public static Texture2D p3a;
	public static Texture2D p3b;
	public static Texture2D p4a;
	public static Texture2D p4b;
	public static Texture2D p5;
	public static Texture2D p6;

	public static Texture2D circle1;
	public static Texture2D circle2;
	public static Texture2D circle3;
	public static Texture2D circle3a;
	public static Texture2D circle4;
	public static Texture2D circle5;
	public static Texture2D circle5a;
	public static Texture2D circle6;
	public static Texture2D circle6a;
	public static Texture2D circle7;
	public static Texture2D circle7a;

	// Use this for initialization
	void Start () {
		if (initialized) {
			return;
		}

		provideStaticTextures ();

		initBaseValuesInDP ();
		initBaseValues ();

		// Depends on base values
		textStyles ();
		guiSkins ();
		buttonStyles ();
		boxStyles ();
		// Depends on text styles
		initTextures ();

		initialized = true;
	}

	/**
	 * Copy non-static to static in Start(). 
	 * Call static only from OnGUI() from any script but NOT from Start()
	 */
	private void provideStaticTextures(){
		backgroundTexture = backgroundTextureX;
		//blackTransparentTexture = blackTransparentTextureX;
		titleBarTexture = titleBarTextureX;
		whiteToAlphaTexture = whiteToAlphaTextureX;
		alphaToWhiteTexture = alphaToWhiteTextureX;
		mainMenuButtonTextureBASE = mainMenuButtonTextureX;
		menuSkin = menuSkinX;
		boxRed = boxRedX;
		boxTorquise = boxTorquiseX;
		buttonTorquise = buttonTorquiseX;
		fontRegular = fontRegularX;
		fontBold = fontBoldX;
		fontBoldItalic= fontBoldItalicX;
		fontItalic = fontItalicX;
		//boxGreyWhite = boxGreyWhiteX;	
		//boxWhiteGrey = boxWhiteGreyX;
		boxGreyLineOnTop = boxGreyLineOnTopX;
		//lightGreyPoint = lightGreyPointX;
		facebookTexture = facebookTextureX;
		menuIconDefault = menuIconDefaultX;
	}

	private static void initBaseValuesInDP(){
		// See https://www.google.com/design/spec/layout/structure.html#structure-app-bar
		// Mobile Landscape: 48dp
		// Mobile Portrait: 56dp
		// Tablet/Desktop: 64dp
		if (DisplayMetricsUtil.IsScreenSizeTablet ()) {
			baseTitleBarHeightInCaseOfPortrait = 64;
			baseTitleBarHeightInCaseOfLandscape = 64;
			baseTitleBarButtonHeight = 64;
			baseGlobalContentPadding = 20;
			baseFontSizeInDP = 20;
			baseGuiElementHeightInDP = 52;
			baseGuiElementPaddingInDP = 52;
		} else {
			baseTitleBarHeightInCaseOfPortrait = 56;
			baseTitleBarHeightInCaseOfLandscape = 48;
			baseTitleBarButtonHeight = 48;
			baseGlobalContentPadding = 16;
			baseFontSizeInDP = 16;
			baseGuiElementHeightInDP = 45;
			baseGuiElementPaddingInDP = 45;
			if(DisplayMetricsUtil.IsScreenSizeSmartphoneSmall()){
				baseGlobalContentPadding = 8;
			}
		}
	}

	private static void initBaseValues(){
		fontSizeDefault = DisplayMetricsUtil.DpToPixel(baseFontSizeInDP);
		guiElementHeightDefault = DisplayMetricsUtil.DpToPixel(baseGuiElementHeightInDP); 
		guiElementPaddingDefault = DisplayMetricsUtil.DpToPixel(baseGuiElementPaddingInDP); 
		buttonHeightDefault = guiElementHeightDefault;
		globalContentPadding = DisplayMetricsUtil.DpToPixel (baseGlobalContentPadding);
		titleBarHeightInCaseOfPortrait = DisplayMetricsUtil.DpToPixel (baseTitleBarHeightInCaseOfPortrait);
		titleBarHeightInCaseOfLandscape = DisplayMetricsUtil.DpToPixel (baseTitleBarHeightInCaseOfLandscape);
		titleBarButtonHeight = DisplayMetricsUtil.DpToPixel (baseTitleBarButtonHeight);
	}


	private static void textStyles(){
		//
		// ABSOLUTE DEFAULT settings for every text
		//
		// 16 ist the absolute Minimum Font Size - Also minimum on Galaxy ACE
		//
		styleTextDefault = new GUIStyle ();
		styleTextDefault.font = fontRegular;
		styleTextDefault.fontSize = baseFontSizeInDP;
		styleTextDefault.normal.textColor = Color.black;
		styleTextDefault.wordWrap = true;

		styleTextDefaultBold = new GUIStyle (styleTextDefault);
		styleTextDefaultBold.font = fontBold;

		styleTextDefaultBoldPadding = new GUIStyle (styleTextDefaultBold);
		styleTextDefaultBoldPadding.padding.top = 6;
		styleTextDefaultBoldPadding.padding.bottom = 1;
		styleTextDefaultBoldPadding.padding.left = 12;
		styleTextDefaultBoldPadding.padding.right = 12;
		
		styleTextDefaultBoldItalic = new GUIStyle (styleTextDefault);
		styleTextDefaultBoldItalic.font = fontBoldItalic;
		styleTextDefaultBoldItalic.fontStyle = FontStyle.Italic;

		styleTextDefaultItalic = new GUIStyle (styleTextDefault);
		styleTextDefaultItalic.font = fontItalic;
		styleTextDefaultItalic.fontStyle = FontStyle.Italic;

		styleTextDefaultPadding = new GUIStyle (styleTextDefault);
		styleTextDefaultPadding.padding.top = 10;
		styleTextDefaultPadding.padding.bottom = 10;
		styleTextDefaultPadding.padding.left = 10;
		styleTextDefaultPadding.padding.right = 10;

		styleTextDefaultCenter = new GUIStyle (styleTextDefault);
		styleTextDefaultCenter.alignment = TextAnchor.MiddleCenter;

		styleTextDefaultCenterItalic = new GUIStyle (styleTextDefaultItalic);
		styleTextDefaultCenterItalic.alignment = TextAnchor.MiddleCenter;

		styleTextDefaultTorquise = new GUIStyle (styleTextDefaultBold);
		styleTextDefaultTorquise.fontSize = baseFontSizeInDP+6;
		//styleTextDefaultTorquise.fontStyle = FontStyle.Bold;
		styleTextDefaultTorquise.alignment = TextAnchor.MiddleCenter;
		styleTextDefaultTorquise.normal.textColor = new Color (0.173f,0.741f,0.722f);
		styleTextDefaultTorquise.onNormal.textColor = new Color (0.173f,0.741f,0.722f);
		styleTextDefaultTorquise.padding.top = 20;
		styleTextDefaultTorquise.padding.bottom = 2;
		styleTextDefaultTorquise.padding.left = 20;
		styleTextDefaultTorquise.padding.right = 20;

		styleTextDefaultRed = new GUIStyle (styleTextDefault);
		styleTextDefaultRed.alignment = TextAnchor.MiddleCenter;
		styleTextDefaultRed.normal.textColor = Color.red;
		styleTextDefaultRed.onNormal.textColor = Color.red;

		styleTextSmall = new GUIStyle (styleTextDefault);
		styleTextSmall.fontSize = baseFontSizeInDP-2;

		styleTextSmallPadding = new GUIStyle (styleTextSmall);
		styleTextSmallPadding.padding.top = 8;
		styleTextSmallPadding.padding.bottom = 2;
		styleTextSmallPadding.padding.left = 20;
		styleTextSmallPadding.padding.right = 20;

		styleTextSmallCenter = new GUIStyle (styleTextSmall);
		styleTextSmallCenter.alignment = TextAnchor.MiddleCenter;

		styleTextSmallItalic = new GUIStyle (styleTextSmall);
		styleTextSmallItalic.fontStyle = FontStyle.Italic;

		styleTextSmallCenterItalic = new GUIStyle (styleTextSmallItalic);
		styleTextSmallCenterItalic.alignment = TextAnchor.MiddleCenter;

		styleTextBig = new GUIStyle (styleTextDefault);
		styleTextBig.fontSize = baseFontSizeInDP+2;

		styleTextBigBold = new GUIStyle (styleTextBig);
        //styleTextBigBold.fontStyle = FontStyle.Bold;
        styleTextBigBold.font = fontBold;

        styleTextBigBoldPadding = new GUIStyle (styleTextBigBold);
		styleTextBigBoldPadding.padding.top = 6;
		styleTextBigBoldPadding.padding.bottom = 1;
		styleTextBigBoldPadding.padding.left = 12;
		styleTextBigBoldPadding.padding.right = 12;

		styleTextBigYellow = new GUIStyle (styleTextBig);
        //styleTextBigYellow.fontStyle = FontStyle.Bold;
        styleTextBigYellow.font = fontBold;
        styleTextBigYellow.normal.textColor = new Color (0.99f,0.74f,0f);
		styleTextBigYellow.onNormal.textColor = new Color (0.99f,0.74f,0f);
		styleTextBigYellow.padding.top = 20;
		styleTextBigYellow.padding.bottom = 2;
		styleTextBigYellow.padding.left = 20;
		styleTextBigYellow.padding.right = 20;


		//
		// Headers
		//
		styleTextHeader = new GUIStyle (styleTextDefault);
		styleTextHeader.fontSize = baseFontSizeInDP + 4;

		styleTextHeaderCenter = new GUIStyle (styleTextHeader);
		styleTextHeaderCenter.alignment = TextAnchor.MiddleCenter;

		styleTextHeaderPadding = new GUIStyle (styleTextHeader);
		styleTextHeaderPadding.padding.top = 30;

		//
		//	Titles
		//
		styleTextTitleBar = new GUIStyle (styleTextDefault);
		styleTextTitleBar.fontSize = baseFontSizeInDP + 4;
		styleTextTitleBar.normal.textColor = Color.white;
		//styleTextTitleBar.fontStyle = FontStyle.Bold;
        styleTextTitleBar.font = fontBold;
        styleTextStartSceneBig = new GUIStyle (styleTextDefault);
		styleTextStartSceneBig.fontSize = Mathf.RoundToInt(baseFontSizeInDP + 10);
		styleTextStartSceneBig.normal.textColor = Color.black;
		styleTextStartSceneBig.alignment = TextAnchor.MiddleCenter;
		styleTextStartSceneBig.font = fontBold;
		styleTextStartSceneSmall = new GUIStyle (styleTextStartSceneBig);
		styleTextStartSceneSmall.fontSize = baseFontSizeInDP + 1;
		styleTextStartSceneSmall.font = fontRegular;

		styleTextAppCode = new GUIStyle (styleTextBigBold);
		styleTextAppCode.alignment = TextAnchor.MiddleRight;

		//
		// DP -> PIXEL
		//
		styleTextDefault = DisplayMetricsUtil.DpToPixel (styleTextDefault);
		styleTextDefaultBold = DisplayMetricsUtil.DpToPixel (styleTextDefaultBold);
		styleTextDefaultBoldPadding = DisplayMetricsUtil.DpToPixel (styleTextDefaultBoldPadding);
		styleTextDefaultBoldItalic = DisplayMetricsUtil.DpToPixel (styleTextDefaultBoldItalic);
		styleTextDefaultTorquise = DisplayMetricsUtil.DpToPixel (styleTextDefaultTorquise);
		styleTextDefaultRed = DisplayMetricsUtil.DpToPixel (styleTextDefaultRed);
		styleTextBigYellow = DisplayMetricsUtil.DpToPixel (styleTextBigYellow);
		styleTextDefaultItalic = DisplayMetricsUtil.DpToPixel (styleTextDefaultItalic);
		styleTextDefaultPadding = DisplayMetricsUtil.DpToPixel (styleTextDefaultPadding);
		styleTextDefaultCenter = DisplayMetricsUtil.DpToPixel (styleTextDefaultCenter);
		styleTextDefaultCenterItalic = DisplayMetricsUtil.DpToPixel (styleTextDefaultCenterItalic);
		styleTextSmall = DisplayMetricsUtil.DpToPixel (styleTextSmall);
		styleTextSmallItalic = DisplayMetricsUtil.DpToPixel (styleTextSmallItalic);
		styleTextSmallCenter = DisplayMetricsUtil.DpToPixel (styleTextSmallCenter);
		styleTextSmallCenterItalic = DisplayMetricsUtil.DpToPixel (styleTextSmallCenterItalic);
		styleTextSmallPadding = DisplayMetricsUtil.DpToPixel(styleTextSmallPadding); 
		styleTextBig = DisplayMetricsUtil.DpToPixel (styleTextBig);
		styleTextBigBold = DisplayMetricsUtil.DpToPixel (styleTextBigBold);
		styleTextBigBoldPadding = DisplayMetricsUtil.DpToPixel (styleTextBigBoldPadding);

		styleTextHeader = DisplayMetricsUtil.DpToPixel (styleTextHeader);
		styleTextHeaderCenter = DisplayMetricsUtil.DpToPixel (styleTextHeaderCenter);
		styleTextHeaderPadding = DisplayMetricsUtil.DpToPixel (styleTextHeaderPadding);

		styleTextTitleBar = DisplayMetricsUtil.DpToPixel (styleTextTitleBar);
		styleTextStartSceneBig = DisplayMetricsUtil.DpToPixel (styleTextStartSceneBig);
		styleTextStartSceneSmall = DisplayMetricsUtil.DpToPixel (styleTextStartSceneSmall);

		styleTextAppCode = DisplayMetricsUtil.DpToPixel (styleTextAppCode);
	}

	private static void guiSkins(){
		menuSkin.button.fixedHeight = 56;
		// ABOVE: All values above ar in DP and will now be converted to pixel
		menuSkin.button = DisplayMetricsUtil.DpToPixel (menuSkin.button);
		// BELOW: All values below must be already converted from dp to pixel
		menuSkin.font = styleTextBigBold.font;
		menuSkin.button.fontSize = styleTextBigBold.fontSize;
        menuSkin.textField.fontSize = styleTextHeaderCenter.fontSize;
        menuSkin.textField.font = styleTextHeaderCenter.font;
	}

	private static void buttonStyles(){
		styleButtonNoStyle = new GUIStyle ();
		styleButtonNoStyleCentered = new GUIStyle (styleButtonNoStyle);
		styleButtonNoStyleCentered.alignment = TextAnchor.MiddleCenter;
		styleButtonNoStyleCenteredPadding = new GUIStyle (styleButtonNoStyleCentered);
		applyDefaultBorderMarginAndPaddingForButton (styleButtonNoStyleCenteredPadding);

		styleButtonTorquise = new GUIStyle (Master.styleTextDefaultCenter);
		applyDefaultBorderMarginAndPaddingForButton (styleButtonTorquise);
		setStyleTexture (styleButtonTorquise, buttonTorquise);
        //styleButtonTorquise.fontStyle = FontStyle.Bold;
        styleButtonTorquise.font = fontBold;
        styleButtonTorquise.wordWrap = false;

		styleButtonFacebook = new GUIStyle (Master.styleButtonTorquise);
		setStyleTexture (styleButtonFacebook, backgroundTexture);
	}

	private static void boxStyles(){
		styleBoxRed = new GUIStyle (Master.styleTextDefaultCenter);
		applyDefaultBorderMarginAndPaddingForButton (styleBoxRed);
		setStyleTexture (styleBoxRed, boxRed);
		
		styleBoxTorquise = new GUIStyle (Master.styleTextDefaultCenter);
		applyDefaultBorderMarginAndPaddingForButton (styleBoxTorquise);
		setStyleTexture (styleBoxTorquise, boxTorquise);

		/*
		styleBoxGreyWhite = new GUIStyle ();
		styleBoxGreyWhite.normal.background = boxGreyWhite;
		applyDefaultBorderMarginAndPaddingForBox (styleBoxGreyWhite);

		styleBoxWhiteGrey = new GUIStyle ();
		styleBoxWhiteGrey.normal.background = boxWhiteGrey;
		applyDefaultBorderMarginAndPaddingForBox (styleBoxWhiteGrey);
*/
		styleBoxGreyLineOnTop = new GUIStyle ();
		styleBoxGreyLineOnTop.normal.background = boxGreyLineOnTop;
		applyDefaultBorderMarginAndPaddingForBox (styleBoxGreyLineOnTop);
	}

	private static void applyDefaultBorderMarginAndPadding(GUIStyle curStyle){
		curStyle.border.top = 3;
		curStyle.border.right = 3;
		curStyle.border.bottom = 3;
		curStyle.border.left = 3;
		curStyle.margin.top = DisplayMetricsUtil.DpToPixel(4);
		curStyle.margin.right = DisplayMetricsUtil.DpToPixel(4);
		curStyle.margin.bottom = DisplayMetricsUtil.DpToPixel(4);
		curStyle.margin.left = DisplayMetricsUtil.DpToPixel(4);
		curStyle.padding.top = DisplayMetricsUtil.DpToPixel(3);
		curStyle.padding.right = DisplayMetricsUtil.DpToPixel(3);
		curStyle.padding.bottom = DisplayMetricsUtil.DpToPixel(3);
		curStyle.padding.left = DisplayMetricsUtil.DpToPixel(3);
	}

	private static void setStyleTexture(GUIStyle style, Texture2D texture){
		style.normal.background = texture;
		style.onNormal.background = texture;
		style.hover.background = texture;
		style.onHover.background = texture;
		style.focused.background = texture;
		style.onFocused.background = texture;
	}
	
	private static void applyDefaultBorderMarginAndPaddingForBox(GUIStyle curStyle){
		applyDefaultBorderMarginAndPadding (curStyle);
	}

	private static void applyDefaultBorderMarginAndPaddingForButton(GUIStyle curStyle){
		applyDefaultBorderMarginAndPadding (curStyle);
		curStyle.padding.right = DisplayMetricsUtil.DpToPixel(10);
		curStyle.padding.left = DisplayMetricsUtil.DpToPixel(10);
	}

	private void initTextures () {
		HOVContainer.init (h5X.width, h5X.height);

		mainMenuButtonTexture = ScaleTexture (mainMenuButtonTextureBASE, titleBarButtonHeight*0.7f);
		arrowLeftI = ScaleTexture (arrowLeftX, titleBarButtonHeight*0.7f);
		arrowRightI = ScaleTexture (arrowRightX, titleBarButtonHeight*0.7f);
		infoTextureI = ScaleTexture (infoTextureX, titleBarButtonHeight*0.7f);
		facebookI = ScaleTexture (facebookTexture, titleBarButtonHeight*0.65f);
		menuIconDefault = ScaleTexture (menuIconDefault, Master.guiElementHeightDefault);
		menuIconQuestionMark = ScaleTexture (questionMarkTextureX, Master.guiElementHeightDefault);

		Texture2D h1 = scaletimeAgeTexture (h1X);
		Texture2D h2 = scaletimeAgeTexture (h2X);
		Texture2D h3 = scaletimeAgeTexture (h3X);
		Texture2D h4 = scaletimeAgeTexture (h4X);
		Texture2D h5 = scaletimeAgeTexture (h5X);

		Texture2D v1 = scaleValuesTexture (v1X);
		Texture2D v2 = scaleValuesTexture (v2X);
		Texture2D v3 = scaleValuesTexture (v3X);
		Texture2D v4 = scaleValuesTexture (v4X);
		Texture2D v5 = scaleValuesTexture (v5X);
		Texture2D v6 = scaleValuesTexture (v6X);

		v1p = ScaleTexture (v1X, Master.guiElementHeightDefault);
		v2p = ScaleTexture (v2X, Master.guiElementHeightDefault);
		v3p = ScaleTexture (v3X, Master.guiElementHeightDefault);
		v4p = ScaleTexture (v4X, Master.guiElementHeightDefault);
		v5p = ScaleTexture (v5X, Master.guiElementHeightDefault);
		v6p = ScaleTexture (v6X, Master.guiElementHeightDefault);

		int valueBigSize = DisplayMetricsUtil.DpToPixel (100);
		v1b = ScaleTexture (v1X, valueBigSize);
		v2b = ScaleTexture (v2X, valueBigSize);
		v3b = ScaleTexture (v3X, valueBigSize);
		v4b = ScaleTexture (v4X, valueBigSize);
		v5b = ScaleTexture (v5X, valueBigSize);
		v6b = ScaleTexture (v6X, valueBigSize);

		Texture2D v1l = scaleValuesTexture (v1lX);
		Texture2D v2l = scaleValuesTexture (v2lX);
		Texture2D v3l = scaleValuesTexture (v3lX);
		Texture2D v4l = scaleValuesTexture (v4lX);
		Texture2D v5l = scaleValuesTexture (v5lX);
		Texture2D v6l = scaleValuesTexture (v6lX);
		/*
		p1 = ScaleTextureByMax (p1X, DisplayMetricsUtil.GetLongSide() * 0.9f , p1X.height);
		p2 = ScaleTextureByMax (p2X, DisplayMetricsUtil.GetLongSide() * 0.9f , (DisplayMetricsUtil.GetShortSide() - Master.titleBarHeightInCaseOfLandscape) * 0.9f);
		p3a = ScaleTextureByMax (p3aX, DisplayMetricsUtil.GetLongSide() * 0.9f , (DisplayMetricsUtil.GetShortSide() - Master.titleBarHeightInCaseOfLandscape) * 0.9f);
		p3b = ScaleTextureByMax (p3bX, DisplayMetricsUtil.GetLongSide() * 0.9f , (DisplayMetricsUtil.GetShortSide() - Master.titleBarHeightInCaseOfLandscape) * 0.9f);
		p4a = ScaleTextureByMax (p4aX, DisplayMetricsUtil.GetLongSide() * 0.9f , (DisplayMetricsUtil.GetShortSide() - Master.titleBarHeightInCaseOfLandscape) * 0.9f);
		p4b = ScaleTextureByMax (p4bX, DisplayMetricsUtil.GetLongSide() * 0.9f , (DisplayMetricsUtil.GetShortSide() - Master.titleBarHeightInCaseOfLandscape) * 0.9f);
		p5 = ScaleTextureByMax (p5X, DisplayMetricsUtil.GetLongSide() * 0.9f , (DisplayMetricsUtil.GetShortSide() - Master.titleBarHeightInCaseOfLandscape) * 0.9f);
		p6 = ScaleTextureByMax (p6X, DisplayMetricsUtil.GetLongSide() * 0.9f , (DisplayMetricsUtil.GetShortSide() - Master.titleBarHeightInCaseOfLandscape) * 0.9f);
*/
		p1 = p1X;
		p2 = p2X;
		p3a = p3aX;
		p3b = p3bX;
		p4a = p4aX;
		p4b = p4bX;
		p5 = p5X;
		p6 = p6X;

		Texture2D questionMark = scaleValuesTexture (questionMarkTextureX);
		//Texture2D emporer = ScaleTextureByMax (emperorTextureX, HOVContainer.textureAdditionalWidth, HOVContainer.textureAdditionalHeight);
		//Texture2D church = ScaleTextureByMax (churchTextureX, HOVContainer.textureAdditionalWidth, HOVContainer.textureAdditionalHeight);

		/*
		circle1 = ScaleTextureByMax (circle1X, DisplayMetricsUtil.GetLongSide(), HOVContainer.textureHistoryHeight);
		circle2 = ScaleTextureByMax (circle2X, DisplayMetricsUtil.GetLongSide(), HOVContainer.textureHistoryHeight);
		circle3 = ScaleTextureByMax (circle3X, DisplayMetricsUtil.GetLongSide(), HOVContainer.textureHistoryHeight);
		circle4 = ScaleTextureByMax (circle4X, DisplayMetricsUtil.GetLongSide(), HOVContainer.textureHistoryHeight);
		circle5 = ScaleTextureByMax (circle5X, DisplayMetricsUtil.GetLongSide(), HOVContainer.textureHistoryHeight);
		circle6 = ScaleTextureByMax (circle6X, DisplayMetricsUtil.GetLongSide(), HOVContainer.textureHistoryHeight);
		circle7 = ScaleTextureByMax (circle7X, DisplayMetricsUtil.GetLongSide(), HOVContainer.textureHistoryHeight);
*/
		circle1 = circle1X;
		circle2 = circle2X;
		circle3 = circle3X;
		circle3a = circle3aX;
		circle4 = circle4X;
		circle5 = circle5X;
		circle5a = circle5aX;
		circle6 = circle6X;
		circle6a = circle6aX;
		circle7 = circle7X;
		circle7a = circle7aX;



		HOVComponent[] hovComponents = HOVContainer.hovComponents;

		hovComponents[0] = new HOVComponent(h1, v1, null, circle2, circle1, new Vector2(215,440), HOVContainer.colorYellow);
		hovComponents[1] = new HOVComponent(h1, v2, null, circle3, circle3a, new Vector2(250,400), HOVContainer.colorOrange);
		hovComponents[2] = new HOVComponent(h1, v3, null, circle4, null, new Vector2(293,355), HOVContainer.colorRed);
		hovComponents[3] = new HOVComponent(h1, v4, null, circle5, circle5a, new Vector2(325,325), HOVContainer.colorViolet);
		hovComponents[4] = new HOVComponent(h1, v5, null, circle6, circle6a, new Vector2(355,295), HOVContainer.colorBlueDark);
		hovComponents[5] = new HOVComponent(h1, v6, null, circle7, null, new Vector2(390,265), HOVContainer.colorBlueBright);
		hovComponents[6] = new HOVComponent(h1, null, null, circle7, circle7a, new Vector2(0,0), Color.black);
		hovComponents[7] = new HOVComponent(h2, v6l, null, circle6, null, new Vector2(498,237), HOVContainer.colorBlueBright);
		hovComponents[8] = new HOVComponent(h2, v5l, v4l, circle4, null, new Vector2(527,280), HOVContainer.colorBlueDark);
		hovComponents[9] = new HOVComponent(h2, v3l, null, circle3, null, new Vector2(555,360), HOVContainer.colorRed);
		hovComponents[10] = new HOVComponent(h2, v2l, v1l, circle1, null, new Vector2(588,420), HOVContainer.colorOrange);
		hovComponents[11] = new HOVComponent(h3, null, null, null, null, new Vector2(0,0), Color.black);
		hovComponents[12] = new HOVComponent(h4, v1, null, null, null, new Vector2(935,440), HOVContainer.colorYellow);
		hovComponents[13] = new HOVComponent(h4, v2, null, null, null, new Vector2(1070,360), HOVContainer.colorOrange);
		hovComponents[14] = new HOVComponent(h4, v3, null, null, null, new Vector2(1160,290), HOVContainer.colorRed);
		hovComponents[15] = new HOVComponent(h4, v4, null, null, null, new Vector2(1255,230), HOVContainer.colorViolet);
		hovComponents[16] = new HOVComponent(h4, v5, null, null, null, new Vector2(1290,205), HOVContainer.colorBlueDark);
		hovComponents[17] = new HOVComponent(h4, v6, null, null, null, new Vector2(1435,115), HOVContainer.colorBlueBright);
		hovComponents[18] = new HOVComponent(h5, questionMark, null, null, null, new Vector2(1491,100), Color.black);
	}

	private Texture2D scaletimeAgeTexture(Texture2D texture){
		float newWidth = (HOVContainer.textureHistoryHeight*texture.width)/texture.height;
		return ScaleTexture (texture, newWidth);
	}

	private Texture2D scaleValuesTexture(Texture2D texture){
		return ScaleTexture (texture, HOVContainer.textureValuesWidth);
	}
	
	public static int getTitleBarHeight(){
		if (DisplayMetricsUtil.isScreenPortrait ()) {
			return Master.titleBarHeightInCaseOfPortrait;
		} else {
			return Master.titleBarHeightInCaseOfLandscape;
		}
	}

	protected override void UpdateExtended () {/*Only necessary because extending MyMonoBehaviour. This is only necessary because of ScaleTecture*/}
}
