using UnityEngine;
using System.Collections;

public class HistoryOfValues : MyMonoBehaviour {
	public Texture2D portraitLandscape;
	private Texture2D curHistory;
	private Texture2D curValue;
	private Texture2D curValue2;
	private Texture2D curAdditional;
	private Texture2D curAdditional2;
	private Color curZoomLineColor;
	private string curTitle;
	private string curYear;
	private string curText;
	private Vector2 curValueSmallLocation;
	private Vector2 curValueBigLocation;
    private int currentStep = 0;
	private GUIStyle alignmentStyleForCirclePictures = new GUIStyle ();

	
	void Start () {
		alignmentStyleForCirclePictures.alignment = TextAnchor.MiddleRight;

		HOVComponent[] hovComponents = HOVContainer.hovComponents;
		for (int i = 0; i < hovComponents.Length; i++) {
			switch (i) {
			case 0:
					hovComponents[i].title = "Antiker Humanismus:";
					hovComponents[i].year = "ab 600 v. Chr.";
					hovComponents[i].text = "Den Startpunkt der Emanzipation des Menschen neben seinen Göttern nennt man Humanistisches Denken. ";
					break;
			case 1:
					hovComponents[i].title = "Antiker Rationalismus:";
					hovComponents[i].year = "ab 600 v. Chr.";
					hovComponents[i].text = "Die Menschen beginnen, ihre Umwelt und das Handeln der Götter rational zu hinterfragen. ";
					break;
			case 2:
					hovComponents[i].title = "Antiker Säkularismus:";
					hovComponents[i].year = "ab 500 v. Chr.";
					hovComponents[i].text = "Die Götter nehmen ihren Platz im privaten Bereich ein und verlassen den öffentlichen Bereich. \nTrennung der Machtbefugnisse von Religion und Politik.";
					break;
			case 3:
					hovComponents[i].title = "Erste Rechtsstaatlichkeit:";
					hovComponents[i].year = "ab 470 v. Chr.";
					hovComponents[i].text = "„Lex statt Rex“: Das aufgeschriebene Gesetz (Lex) ersetzt die willkürliche Gesetzgebung eines Königs (Rex).";
					break;
			case 4:
					hovComponents[i].title = "Attische Demokratie:";
					hovComponents[i].year = "ab 462 v. Chr.";
					hovComponents[i].text = "Man beginnt von seinen Herrschern politische Mitbestimmung einzufordern.";
					break;
			case 5:
					hovComponents[i].title = "Griechische Philosophen der Stoa:";
					hovComponents[i].year = "ab 330 v. Chr.";
					hovComponents[i].text = "Die Idee, dass jedem Menschen von Geburt an gleiche Rechte zustehen, stammt aus der Antike.";
					break;
			case 6:
					hovComponents[i].title = "Ein voll entwickeltes humanistisches Weltbild";
					hovComponents[i].year = "";
					hovComponents[i].text = "... entstand durch die Verwirklichung der 6 beschriebenen Werte.";
					break;
			case 7:
					hovComponents[i].title = "Wendepunkt + Rückentwicklung";
					hovComponents[i].year = "";
					hovComponents[i].text = "Menschenrechte: In der griechischen Philosophierichtung der Stoa definiert, wurden sie jedoch nie gesetzlich festgeschrieben!";
					break;
			case 8:
					hovComponents[i].title = "Römisches Kaiserreich";
					hovComponents[i].year = "ab 27 v. Chr.";
					hovComponents[i].text = "Demokratie & Rechtsstaatlichkeit verschwinden stufenweise mit der Umwandlung bzw. dem Rückfall der römischen Republik in ein römisches Kaiserreich.";
					break;
			case 9:
					hovComponents[i].title = "Staatsreligion: Christentum";
					hovComponents[i].year = "ab 380 n. Chr.";
					hovComponents[i].text = "Säkularität wird aufgehoben: Christentum wird römische Staatsreligion. Es werden schrittweise alle anderen Religionen verboten.";
					break;
			case 10:
					hovComponents[i].title = "Gott steht wieder über dem Menschen";
					hovComponents[i].year = "ab 400 n. Chr.";
					hovComponents[i].text = " - Rationalität wird durch Glaube ersetzt und \n - der Fokus ändert sich vom Menschen auf Gott.";
					break;
			case 11:
					hovComponents[i].title = "Das Mittelalter beginnt";
					hovComponents[i].year = "ab 500 n. Chr.";
					hovComponents[i].text = "Das Mittelalter ist die Zeit zwischen der Antike und der Wiedergeburt der Antike.";
					break;
			case 12:
					hovComponents[i].title = "Renaissance- Humanismus";
					hovComponents[i].year = "ab 1450 n. Chr.";
					hovComponents[i].text = "Neue geistige Grundhaltung: Der Mensch und seine Entwicklung im „hier und jetzt“ werden wieder in den Mittelpunkt gerückt.";
					break;
			case 13:
					hovComponents[i].title = "Klassischer Rationalismus";
					hovComponents[i].year = "ab 1640 n. Chr.";
					hovComponents[i].text = "Die Fähigkeit der menschlichen Vernunft – anstelle des Glaubens – wird wieder zur Urteilsfindung herangezogen.";	
					break;
			case 14:
					hovComponents[i].title = "Aufklärung";
					hovComponents[i].year = "ab 1700 n. Chr.";
					hovComponents[i].text = "Trennung von Politik und Religion: Rationales, logisches Denken widerlegt zunehmend religiöses, dogmatisches Denken und verdrängt die Religion aus der Politik.";
					break;
			case 15:
					hovComponents[i].title = "Französische Revolution";
					hovComponents[i].year = "ab 1789 n. Chr.";
					hovComponents[i].text = "Angewandte Säkularität führt zu Rechtsstaatlichkeit: Grundgesetze und Verfassungen entstehen, die nicht im Namen eines Gottes, sondern von Menschen gemacht wurden. Es kommt zur Teilung der Staatsgewalten.";
					if(DisplayMetricsUtil.IsScreenSizeSmartphoneSmall()){
						hovComponents[i].text = "Angewandte Säkularität führt zu Rechtsstaatlichkeit: Grundgesetze und Verfassungen entstehen. Es kommt zur Teilung der Staatsgewalten.";
					}
				break;
			case 16:
					hovComponents[i].title = "Demokratie";
					hovComponents[i].year = "ab 1792 n. Chr.";
					hovComponents[i].text = "Die erste europäische Demokratie der Neuzeit entsteht 1792 in Frankreich auf Basis einer demokratischen Verfassung. ";
					break;
			case 17:
					hovComponents[i].title = "Erklärung der Allgemeinen Menschenrechte";
					hovComponents[i].year = "ab 1948 n. Chr.";
					hovComponents[i].text = "Die Menschenrechte gewähren allen Menschen die gleichen Rechte und die gleiche Freiheit. Jeder Mensch besitzt von Geburt an unveräußerliche Menschenrechte.";
					if(DisplayMetricsUtil.IsScreenSizeSmartphoneSmall()){
						hovComponents[i].title = "Allgemeinen Menschenrechte";
					}
					break;
			case 18:
					hovComponents[i].title = "Zukunft";
					hovComponents[i].year = "";
					hovComponents[i].text = "Was die Zukunft bringt, hängt von unseren heutigen Taten und Entscheidungen ab!";
					break;
			}
		}
	}

	protected override void UpdateExtended () {
        /*

        ABOUT SWYPE
         - WORKED BEST WITH ANDROID
         - CAUSED TROUBLES ON iOS SIMULATOR
         - NOT TESTET ON iOS DIRECTLY

		if (Input.touchCount > 0) {
			//
			// Swype left/Right
			//
			Touch touch = Input.touches [0];
			if (touch.phase == TouchPhase.Ended) {
				float distanceX = touch.rawPosition.x - touch.position.x;
                bool isFunnyiOSBehaviour = (touch.rawPosition.x * 2 == touch.position.x); // When I press "->" Button in History Scene then not the button is activated but also VERY STRANGLY this swype handling is activated. Very string is that it is only a click without move, but when "rawposition=35" then "position=70". It is always double. So in that case sywpe handling must not be activated.
				if(Mathf.Abs(distanceX) > Screen.width/6 && !isFunnyiOSBehaviour)
                {
					if(distanceX < 0) {
						if (currentStep > 0) {
							currentStep--;
                            currentStepA--;
                            DEL_ME = DEL_ME + "!--!ABS" + touch.rawPosition.x  + "-" + touch.position.x + ">" + Screen.width;
                            //changeContent = true;
                            //resetFade();
                        }
					} else {
						if (currentStep < 23) {
							currentStep++;
                            currentStepA++;
                            //changeContent = true;
                            //resetFade();
                            DEL_ME = DEL_ME + "!++!ABS" + touch.rawPosition.x + "-" + touch.position.x + "<" + Screen.width; ;
                        }
					}
				}
			}
		}
        */
		
		if(currentStep >= 5)
		{
			Update_HistoryContent ();
			Update_PositionOfTheValues ();
		}
}

	void Update_HistoryContent ()
	{
		HOVComponent comp = HOVContainer.hovComponents [currentStep-5];
		curHistory = comp.history;
		curValue = comp.value;
		curValue2 = comp.value2;
		curAdditional = comp.addtional;
		curAdditional2 = comp.addtional2;
		curZoomLineColor = comp.zoomLineColor;
		curTitle = comp.title;
		curYear = comp.year;
		curText = comp.text;
		curValueSmallLocation = comp.valueLocation;
	}

	void Update_PositionOfTheValues ()
	{
		float addToX = Master.globalContentPadding;
		float addToY = Master.getTitleBarHeight() + HOVContainer.spaceBetweenTitlebarAndHistoryTexture;
		curValueSmallLocation.x += addToX;
		curValueSmallLocation.y += addToY;

		// Special treatment: Y-axis of Locations of all values(small ones in the big histery texture) should be a little bit more.
		// I do not have an idea why but this is the easiest way.
		curValueSmallLocation.y += DisplayMetricsUtil.DpToPixel (4);

		Vector2 relZoomValueLocation = HOVContainer.valuePos1;
		if (currentStep > 11) {
			relZoomValueLocation = HOVContainer.valuePos2;
		}
		if (currentStep > 16) {
			relZoomValueLocation = HOVContainer.valuePos3;
		}
		if (currentStep > 22) {
			relZoomValueLocation = HOVContainer.valuePos4;
		}
		curValueBigLocation = new Vector2 (relZoomValueLocation.x + addToX, relZoomValueLocation.y + addToY);
	}

	void OnGUI() {
		OnGUI_Before ("Ihre Geschichte");

		if (DisplayMetricsUtil.isScreenPortrait ()) {
			Rect guiArea = new Rect (Master.globalContentPadding, Master.getTitleBarHeight (), Screen.width - Master.globalContentPadding * 2, Screen.height - Master.getTitleBarHeight ());
			GUILayout.BeginArea (guiArea);
			GUILayout.Label ("", GUILayout.Height (HOVContainer.spaceBetweenTitlebarAndHistoryTexture));
			GUILayout.BeginVertical ();
			GUILayout.FlexibleSpace ();
			GUILayout.Label (portraitLandscape, Master.styleTextDefaultCenter, GUILayout.Height (DisplayMetricsUtil.DpToPixel (200)));
			GUILayout.FlexibleSpace ();
			GUILayout.EndVertical ();
			GUILayout.EndArea ();
			return;
		}

		if (currentStep < 5) {
			OnGUI_ScrollViewStart ();
			OnGUI_0To4Sequence();
			OnGUI_ScrollViewEnd ();
		} else {
			OnGUI_5To23Sequence ();
			OnGUI_Value ();
			//OnGUI_timeAgeText (); - NOT NECESSARY ANYMORE
		}
		OnGUI_Button ();
	}

	void OnGUI_0To4Sequence ()
	{
		float usedScreenWidth = HOVContainer.textureHistoryWidth * 0.95f;
		float usedScreenHeight = Screen.height - Master.titleBarHeightInCaseOfLandscape - DisplayMetricsUtil.DpToPixel (90);

		if (currentStep == 0) {
			GUILayout.BeginVertical ();

			GUILayout.Label ("Die Geschichte Europas ist von einem ständigen Wandel von Werten und den entsprechenden Weltbildern gekennzeichnet.\n", Master.styleTextHeaderCenter);
			GUILayout.BeginHorizontal ();

			GUILayout.FlexibleSpace ();
			GUILayout.Label(Master.p1, Master.styleTextDefaultCenter,
			                GUILayout.Height(Master.p1.height*usedScreenWidth/Master.p1.width),
			                GUILayout.Width(usedScreenWidth));
			GUILayout.FlexibleSpace ();

			GUILayout.EndHorizontal ();

			GUILayout.EndVertical ();
		} else if (currentStep == 1) {
			GUILayout.BeginVertical ();
			
			GUILayout.Label ("Wandel der Weltbilder in Europa", Master.styleTextHeaderCenter);
			GUILayout.BeginHorizontal ();
			
			GUILayout.FlexibleSpace ();
			GUILayout.Label(Master.p2, Master.styleTextDefaultCenter,
			                GUILayout.Height(Master.p2.height*usedScreenWidth/Master.p2.width),
			                GUILayout.Width(usedScreenWidth));
			GUILayout.FlexibleSpace ();
			
			GUILayout.EndHorizontal ();
			
			GUILayout.EndVertical ();
		} else if (currentStep == 2) {
			GUILayout.BeginVertical ();
			GUILayout.Label ("Von dem theozentrischen Weltbild\nmit Gott im Mittelpunkt des Denkens ...", Master.styleTextHeaderCenter);
			GUILayout.Label("",Master.styleButtonNoStyle, GUILayout.MinHeight(1));
			GUILayout.BeginHorizontal ();
			
			GUILayout.FlexibleSpace ();
			GUILayout.Label(Master.circle1,Master.styleTextDefaultCenter,
			                GUILayout.Height(usedScreenHeight),
			                GUILayout.Width(usedScreenWidth/2));
			GUILayout.FlexibleSpace ();
			GUILayout.Label(Master.p3b,Master.styleTextDefaultCenter,
			                GUILayout.Height(usedScreenHeight),
			                GUILayout.Width(usedScreenWidth/2));
			GUILayout.FlexibleSpace ();
			
			GUILayout.EndHorizontal ();
			
			GUILayout.EndVertical ();
		} else if (currentStep == 3) {
			GUILayout.BeginVertical ();
			GUILayout.Label ("... zu dem humanistischen Weltbild\nmit dem Menschen im Mittelpunkt des Denkens!", Master.styleTextHeaderCenter);
			GUILayout.Label("",Master.styleButtonNoStyle,GUILayout.MinHeight(1));
			GUILayout.BeginHorizontal ();
			
			GUILayout.FlexibleSpace ();
			GUILayout.Label(Master.circle7,Master.styleTextDefaultCenter,
			                GUILayout.Height(usedScreenHeight),
			                GUILayout.Width(usedScreenWidth/2));
			GUILayout.FlexibleSpace ();
			GUILayout.Label(Master.p4b,Master.styleTextDefaultCenter,
			                GUILayout.Height(usedScreenHeight),
			                GUILayout.Width(usedScreenWidth/2));
			GUILayout.FlexibleSpace ();
			
			GUILayout.EndHorizontal ();
			
			GUILayout.EndVertical ();
		} else if (currentStep == 4) {
			GUILayout.BeginVertical ();
            GUILayout.Label("Humanistische Entwicklung in Europa.", Master.styleTextDefaultBold);
            GUILayout.Label("Diese Kurve veranschaulicht das Zu- oder Abnehmen der 6 grundlegenden Europäischen Werte in der Geschichte Europas.", Master.styleTextDefault);
            GUILayout.Label("", GUILayout.MinHeight(DisplayMetricsUtil.DpToPixel(3)));
            GUILayout.Label(Master.p5,Master.styleTextDefaultCenter,
			                GUILayout.Height(Master.p5.height*usedScreenWidth/Master.p5.width),
			                GUILayout.Width(usedScreenWidth));
            GUILayout.Label("", GUILayout.MinHeight(DisplayMetricsUtil.DpToPixel(3)));
            GUILayout.Label("Zeichenerklärung der Sterne im Feld „Altertum“?", Master.styleTextDefaultBold);
            GUILayout.Label("Die Anzahl der Sterne zeigt, in welchem Maße die humanistischen Prinzipien Eingang in die gesellschaftliche Ordnung der Antike gefunden haben. Die Bewertung reicht von 6 Sternen für die volle Umsetzung des neuen Denkens bis zu einem Stern für eine nur sehr begrenzte Umsetzung. ", Master.styleTextDefault);

            GUILayout.Label("", GUILayout.MinHeight(DisplayMetricsUtil.DpToPixel(9)));
            GUILayout.Label(Master.p6,Master.styleTextDefaultCenter,
			                GUILayout.Height(Master.p6.height*usedScreenWidth/Master.p6.width),
			                GUILayout.Width(usedScreenWidth));
			GUILayout.Label ("Unter besonderer Berücksichtigung dieser Entwicklungen und Ereignisse:", Master.styleTextDefault);
			GUILayout.Label (" - Griechische Antike (800 - 146 v. Chr.)", Master.styleTextDefault);
			GUILayout.Label (" - Römische Antike (509 v. Chr. - 500 n. Chr.)", Master.styleTextDefault);
			GUILayout.Label (" - Christentum wird Staatsreligion (380 n. Chr.) ", Master.styleTextDefault);
			GUILayout.Label (" - Renaissance (1450-1600)", Master.styleTextDefault);
			GUILayout.Label (" - Reformation (1517-1600)", Master.styleTextDefault);
			GUILayout.Label (" - Aufklärung (1600-1800)", Master.styleTextDefault);
			GUILayout.Label (" - Franz. Revolution (1789)\n", Master.styleTextDefault);
			GUILayout.FlexibleSpace ();
			GUILayout.EndVertical ();
		}
	}

	void OnGUI_5To23Sequence ()
	{
		// Ignoring rule to use: OnGUI_ScrollViewStart ();
		Rect guiArea = new Rect (Master.globalContentPadding, Master.getTitleBarHeight (), Screen.width - Master.globalContentPadding * 2, Screen.height - Master.getTitleBarHeight ());
		GUILayout.BeginArea (guiArea);
		GUILayout.Label ("", GUILayout.Height (HOVContainer.spaceBetweenTitlebarAndHistoryTexture));
		GUILayout.BeginVertical ();
		GUILayout.BeginHorizontal ();
		GUILayout.Label (curHistory, Master.styleButtonNoStyle);
		GUILayout.FlexibleSpace ();
		GUILayout.EndHorizontal ();
		GUILayout.BeginHorizontal (Master.styleBoxGreyLineOnTop);
		// COMPLETE TEXT BLOCK - START
		GUILayout.BeginVertical ();
		GUILayout.BeginHorizontal ();
		GUILayout.Label (curTitle, Master.styleTextDefaultBold);
		GUILayout.FlexibleSpace ();
		GUILayout.Label (curYear, Master.styleTextDefaultItalic);
		GUILayout.EndHorizontal ();
		GUILayout.BeginHorizontal ();
		GUILayout.Label (curText, Master.styleTextDefault);
		GUILayout.FlexibleSpace ();
		GUILayout.EndHorizontal ();
		GUILayout.EndVertical ();
		// COMPLETE TEXT BLOCK - END
		GUILayout.EndHorizontal ();
		GUILayout.FlexibleSpace ();
		GUILayout.EndVertical ();
		// Ignoring rule to use: OnGUI_ScrollViewEnd ();
		GUILayout.EndArea ();
	}
	
	void OnGUI_timeAgeText() {
		if (currentStep >= 16) {
			GUI.Label (HOVContainer.timeAgeTextRect1, "Altertum", Master.styleTextDefault);
			GUI.Label (HOVContainer.timeAgeTextRect2, "Mittelalter", Master.styleTextDefault);
		}
		if (currentStep >= 17) {
			GUI.Label (HOVContainer.timeAgeTextRect3, "Neuzeit", Master.styleTextDefault);
		}
		if (currentStep >= 23) {
			GUI.Label (HOVContainer.timeAgeTextRect4, "Zukunft", Master.styleTextDefault);	
		}
	}

	void OnGUI_Value ()
	{
		if (curValue != null) {
			GUI.color = new Color (1, 1, 1, 1);
			if((currentStep != 11) && (currentStep != 16)){
				if  (Event.current.type == EventType.Repaint){
					Drawing.DrawLine(curValueBigLocation, curValueSmallLocation, curZoomLineColor, 2.0f, true);
				}
			}

			float x = curValueBigLocation.x;
			float y = curValueBigLocation.y;

			GUI.Label (new Rect (x - curValue.width/2, y - curValue.height/2, curValue.width, curValue.height), curValue);
		
			if (curValue2 != null) {
				x += curValue.width;
				GUI.Label (new Rect (x - curValue.width/2, y - curValue.height/2, curValue2.width, curValue2.height), curValue2);
			}
		}

		if (curAdditional != null) {
			float newAdditionalHeight = HOVContainer.textureHistoryHeight * 0.9f;
			float newAdditionalWidth = newAdditionalHeight;//newAdditionalHeight * curAdditional.width / curAdditional.height;
			float spaceBetweenTitlebarAndAdditional = (HOVContainer.textureHistoryHeight - newAdditionalHeight) / 2;

			float x = DisplayMetricsUtil.GetLongSide() - Master.globalContentPadding - newAdditionalWidth;
			float y = Master.getTitleBarHeight () + HOVContainer.spaceBetweenTitlebarAndHistoryTexture + spaceBetweenTitlebarAndAdditional;

			if (curAdditional2 != null) {				
				float x2 = x - newAdditionalWidth;
				GUI.Label (new Rect (x2, y, newAdditionalWidth, newAdditionalHeight), curAdditional2, alignmentStyleForCirclePictures);
			}

			GUI.Label (new Rect (x, y, newAdditionalWidth, newAdditionalHeight), curAdditional, alignmentStyleForCirclePictures);
		}
	}
	
	void OnGUI_Button ()
	{
		int buttonBarHeight = Master.getTitleBarHeight();
		int buttonBarWidth = Master.titleBarButtonHeight*2 + Master.globalContentPadding;
		Rect guiArea = new Rect (Screen.width - buttonBarWidth - Master.globalContentPadding, 0, buttonBarWidth, buttonBarHeight);
		GUILayout.BeginArea(guiArea);
		GUILayout.BeginVertical ();
		GUILayout.FlexibleSpace ();
		GUILayout.BeginHorizontal ();
		if (currentStep > 0) {
			if (GUILayout.Button (Master.arrowLeftI, Master.styleButtonNoStyleCentered, GUILayout.Height(Master.titleBarButtonHeight), GUILayout.Width(Master.titleBarButtonHeight))) {
				currentStep--;
            }
		}
		GUILayout.FlexibleSpace ();
		if (currentStep < 23) {
			if (GUILayout.Button (Master.arrowRightI, Master.styleButtonNoStyleCentered, GUILayout.Height(Master.titleBarButtonHeight), GUILayout.Width(Master.titleBarButtonHeight))) {
				currentStep++;
            }
		}
		GUILayout.EndHorizontal ();
		GUILayout.FlexibleSpace ();
		GUILayout.EndVertical ();
		GUILayout.EndArea ();
	}
}
