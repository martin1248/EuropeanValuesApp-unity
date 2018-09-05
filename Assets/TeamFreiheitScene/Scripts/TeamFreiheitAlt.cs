using UnityEngine;
using System.Collections;

public class TeamFreiheitAlt : MyMonoBehaviour {
	private const int debugTouchCountActiv = 30;
	public Texture2D logo;
	private int debugTouchCounter = 0;
	private string debugTouchEnd = "";

	private int countUpdate = 0;

	protected override void UpdateExtended () {
		for (var i = 0; i < Input.touchCount; ++i) {
			if (Input.GetTouch(i).phase == TouchPhase.Began) {
				debugTouchCounter++;
			}
		}
		if (Input.GetKeyDown ("d")) {
			debugTouchCounter++;
		}
		
		if (debugTouchCounter > debugTouchCountActiv) {
			countUpdate++;

			if(Input.touchCount > 0)
			{
				Touch touch = Input.touches[0];
				
				if (touch.phase == TouchPhase.Moved) {
					debugTouchEnd = "Start Y-Position: " + touch.rawPosition.y + "\nTime Deltatime: " + Time.deltaTime + "\nTouch DeltaTime: " + touch.deltaTime + "\nTouch DeltaPos-Y: " + touch.deltaPosition.y + "\nCurrent Y-Position: " + touch.position.y + "\n(" + (Time.deltaTime / touch.deltaTime) + ")";
				}
			}
			
		}
	}
	
	void OnGUI() {

		OnGUI_Before ("TeamFreiheit");
		OnGUI_ScrollViewStart ();

		GUILayout.BeginHorizontal ();
		GUILayout.FlexibleSpace ();
		GUILayout.Label(logo, Master.styleTextDefaultCenter, GUILayout.Width(DisplayMetricsUtil.DpToPixel(240)), GUILayout.Height(DisplayMetricsUtil.DpToPixel(120)));
		GUILayout.FlexibleSpace ();
		GUILayout.EndHorizontal ();


		GUILayout.Label ("teamfreiheit.info", Master.styleTextDefaultTorquise);
		GUILayout.BeginHorizontal ();
		GUILayout.FlexibleSpace ();
		if (GUILayout.Button ("Zur Website",Master.styleButtonTorquise,GUILayout.Height(Master.guiElementHeightDefault))) {
            //TODO
            debugTouchCounter = 100;

            //Application.OpenURL ("http://teamfreiheit.info");
		}
		GUILayout.FlexibleSpace ();
		GUILayout.EndHorizontal ();


		if (debugTouchCounter > debugTouchCountActiv) {
			OnGUI_debugInfo ();
		}


		OnGUI_Header("Über diese App");
		GUILayout.Label ("Diese App wurde von TeamFreiheit geschrieben, mit dem Ziel die Werte Europas zu vermitteln.", Master.styleTextDefault);

		OnGUI_Header("Wer ist 'TeamFreiheit'?");
		GUILayout.Label ("'TeamFreiheit' ist eine humanistische Organisation mit Sitz in Österreich, die sich unabhängig und überparteilich für den Erhalt der Freiheiten in Europa einsetzt. ", Master.styleTextDefault);

		OnGUI_ScrollViewEnd ();
	}

	private void OnGUI_Header(string text){
		GUILayout.Label (text, Master.styleTextHeaderPadding);
		GUILayout.BeginVertical (Master.styleBoxGreyLineOnTop);
		GUILayout.EndVertical ();
	}

	private void OnGUI_debugInfo() {
		GUILayout.Label ("\n\n\n\nDEBUG MODE\n", Master.styleTextStartSceneBig);
		GUILayout.BeginVertical ();
		GUILayout.Label ("Current display settings", Master.styleTextHeader);
		GUILayout.Label ("   DPI (in use)______: " + DisplayMetricsUtil.GetDPI_Debug(), Master.styleTextDefault);
		GUILayout.Label ("   DPI by Unity______: " + Screen.dpi, Master.styleTextDefault);
		if (DisplayMetricsAndroid.IsAndroid) {
			GUILayout.Label ("   DPI by Android____: " + DisplayMetricsAndroid.DensityDPI, Master.styleTextDefault);
		}
		GUILayout.Label ("   Resolution type__: " + DisplayMetricsUtil.GetResolutionType(), Master.styleTextDefault);
		GUILayout.Label ("   Scale____________: " + DisplayMetricsUtil.GetScale_DEBUG(), Master.styleTextDefault);
		GUILayout.Label ("   Screensize_______: " + DisplayMetricsUtil.GetScreenSize_DEBUG(), Master.styleTextDefault);

		GUILayout.Label ("   Short Side: " + DisplayMetricsUtil.GetShortSideInDP() + " dp = " +
							                 DisplayMetricsUtil.GetShortSide() + " pixel = " +
							                 DisplayMetricsUtil.GetShortSideInInch() + " inch = " +
							                 DisplayMetricsUtil.GetShortSideInCentimeters() + " cm", Master.styleTextDefault);
		GUILayout.Label ("   Long Side: " + DisplayMetricsUtil.GetLongSideInDP() + " dp = " +
                                         	DisplayMetricsUtil.GetLongSide() + " pixel = " +
		                					DisplayMetricsUtil.GetLongSideInInch() + " inch = " +
		                 					DisplayMetricsUtil.GetLongSideInCentimeters() + " cm", Master.styleTextDefault);
        GUILayout.Label("Member information:", Master.styleTextHeader);
        GUILayout.Label("  Was there an internet connection(at last check) " + Member.internetConnectionExists, Master.styleTextDefault);
        GUILayout.Label("  Error message(In case an error occurred): " + Member.errorMessage, Master.styleTextDefault);
		if(GUILayout.Button("Delete Member information")) {
			Member.DeleteMember();
		}
        GUILayout.Label ("\n\n", Master.styleTextDefault);

		if (debugTouchCounter > debugTouchCountActiv*4) {
			GUILayout.Label ("Touch Data: \n" + debugTouchEnd, Master.styleTextDefault);
			
			GUILayout.Label ("\n\n", Master.styleTextDefault);
			GUILayout.Label ("How often was Update() called: " + countUpdate, Master.styleTextDefault);
			GUILayout.Label ("\n\n\n", Master.styleTextDefault);

			GUILayout.Label ("DisplayMetricsAndroid says", Master.styleTextHeader);
			GUILayout.Label ("   IsAndroid=" + DisplayMetricsAndroid.IsAndroid, Master.styleTextDefault);
			if (DisplayMetricsAndroid.IsAndroid) {
				GUILayout.Label ("   " + DisplayMetricsAndroid.HeightPixels + "x" + DisplayMetricsAndroid.WidthPixels + " (Screen size)", Master.styleTextDefault);
				GUILayout.Label ("   Density=" + DisplayMetricsAndroid.Density, Master.styleTextDefault);
				GUILayout.Label ("   DensityDPI=" + DisplayMetricsAndroid.DensityDPI, Master.styleTextDefault);
				GUILayout.Label ("   X-DPI=" + DisplayMetricsAndroid.XDPI, Master.styleTextDefault);
				GUILayout.Label ("   Y-DPI=" + DisplayMetricsAndroid.YDPI, Master.styleTextDefault);
				
				float widthInch2 = DisplayMetricsAndroid.HeightPixels / DisplayMetricsAndroid.DensityDPI;
				float heightInch2 = DisplayMetricsAndroid.WidthPixels / DisplayMetricsAndroid.DensityDPI;
				GUILayout.Label ("   " + widthInch2 + "x" + heightInch2 + " inch", Master.styleTextDefault);
				GUILayout.Label ("   " + System.Math.Round(widthInch2*2.54f,1) + "x" + System.Math.Round(heightInch2*2.54f,1) + " (Calculated cm)", Master.styleTextDefault);
			}
			GUILayout.Label ("\n\n\n", Master.styleTextDefault);


			GUILayout.Label ("What is the right dpi for this display?", Master.styleTextDefault);
			GUILayout.Label ("Measure below which grey line has 5.08 cm(+/-0.1; equal to 2 inch).", Master.styleTextDefault);
			GUILayout.Label ("The line which matches is the right dpi:", Master.styleTextDefault);
			GUILayout.Label ("The line should match the first grey line - if not then UI might not be as perfect as possible:", Master.styleTextDefault);

			GUILayout.Button ("MATCH THIS", GUILayout.Height (15), GUILayout.Width (DisplayMetricsUtil.DpToPixel (160 * 2)));
			GUILayout.Button (" 96 dpi", GUILayout.Height (15), GUILayout.Width (96 * 2));
			GUILayout.Button ("101 dpi", GUILayout.Height (15), GUILayout.Width (101 * 2));
			GUILayout.Button ("160 dpi", GUILayout.Height (15), GUILayout.Width (160 * 2));
			GUILayout.Button ("213 dpi", GUILayout.Height (15), GUILayout.Width (213 * 2));
			GUILayout.Button ("234 dpi", GUILayout.Height (15), GUILayout.Width (234 * 2));
			GUILayout.Button ("240 dpi", GUILayout.Height (15), GUILayout.Width (240 * 2));
			GUILayout.Button ("267 dpi", GUILayout.Height (15), GUILayout.Width (267 * 2));
			GUILayout.Button ("285 dpi", GUILayout.Height (15), GUILayout.Width (285 * 2));
			GUILayout.Button ("294 dpi", GUILayout.Height (15), GUILayout.Width (294 * 2));
			GUILayout.Button ("312 dpi", GUILayout.Height (15), GUILayout.Width (312 * 2));
			GUILayout.Button ("326 dpi", GUILayout.Height (15), GUILayout.Width (326 * 2));
			GUILayout.Button ("342 dpi", GUILayout.Height (15), GUILayout.Width (342 * 2));
			GUILayout.Button ("367 dpi", GUILayout.Height (15), GUILayout.Width (367 * 2));
			GUILayout.Button ("380 dpi", GUILayout.Height (15), GUILayout.Width (380 * 2));
		}

		GUILayout.EndVertical ();
	}
}

