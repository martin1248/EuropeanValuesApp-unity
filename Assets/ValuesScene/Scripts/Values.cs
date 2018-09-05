using UnityEngine;
using System.Collections;

public class Values : MyMonoBehaviour {
	public static ValueComponent[] valueComponents = new ValueComponent[6];
	private int currentStep = -1;

	void Start () {
		Start_AddValue (0, Master.v1b, Master.v1p, "1. Humanistisches Denken", "Renaissance-Humanismus ab 1450", "Der Mensch wird zum Maßstab aller Dinge.", "\"Ich als Mensch bin selbstverantwortlich für mein Schicksal.\"");
		Start_AddValue (1, Master.v2b, Master.v2p, "2. Rationalität", "Klassischer Rationalismus ab 1640", "Die menschliche Vernunft wird wichtiger als blinder Glaube.", "\"Mit meinem Verstand hinterfrage ich kritisch jede Tradition.\"");
		Start_AddValue (2, Master.v3b, Master.v3p, "3. Säkularität", "Zeitalter der Aufklärung ab 1700", "Weltliche Gesetze werden über religiöse Gesetze erhoben.", "\"Trennung von Politik und Religion, Staat und Staatskirche.\"");
		Start_AddValue (3, Master.v4b, Master.v4p, "4. Rechtsstaatlichkeit", "Französische Revolution 1789", "Grundrechte für alle.", "\"Vor dem Gesetz sind nun alle Menschen gleich.\"");
		Start_AddValue (4, Master.v5b, Master.v5p, "5. Demokratie", "Erste Demokratien der Neuzeit in Europa ab 1792", "Man fordert von seinen Herrschern politische Mitbestimmung.", "\"Alle Staatsgewalt geht vom Volk aus.\"");
		Start_AddValue (5, Master.v6b, Master.v6p, "6. Menschenrechte", "Allgemeine Erklärung der Menschenrechte 1948", "Nach dem 2.Weltkrieg fordert man ein Idealgesetz ein, nach dem sich von nun an jede politische, religiöse und wirtschaftliche Institution halten muss.", "\"Jeder Mensch besitzt von Geburt an unveräußerliche Menschenrechte.\"");
	}
	
	protected override void UpdateExtended () {
	}

	void OnGUI() {
		OnGUI_Before ("Die Werte");
		OnGUI_Button ();
		OnGUI_ScrollViewStart ();

		if (currentStep <= -1) {
			GUILayout.BeginVertical ();
			GUILayout.Label("Diese 6 Stufen führten zu den freien Gesellschaften Europas:", Master.styleTextBig);
			GUILayout.Label("",GUILayout.MinHeight(12));
			GUI.skin = Master.menuSkin;
			OnGUI_AddValue (5);
			OnGUI_AddValue (4);
			OnGUI_AddValue (3);
			OnGUI_AddValue (2);
			OnGUI_AddValue (1);
			OnGUI_AddValue (0);
			GUILayout.Label("",GUILayout.MinHeight(12));
			GUILayout.Label("Unser modernes humanistisches Weltbild entwickelte sich über 6 Stufen, die gleichzeitig die Hauptwerte ergeben, aus denen sich alle anderen Europäischen Werte ableiten lassen. Die einzelnen Stufen bauen aufeinander auf - keine Stufe wäre ohne die vorangegangenen entstanden.", Master.styleTextDefault);
			GUILayout.EndVertical ();
		} else {
			GUILayout.BeginVertical ();
			OnGUI_Text ();
			GUILayout.EndVertical ();

			GUILayout.BeginVertical ();
			OnGUI_Details ();
			GUILayout.EndVertical ();
		}

		OnGUI_ScrollViewEnd ();
	}

	void OnGUI_Text ()
	{
		GUILayout.BeginVertical ();

		GUILayout.BeginHorizontal ();
		GUILayout.FlexibleSpace ();
		GUILayout.Label (valueComponents[currentStep].origValueTexture);
		GUILayout.FlexibleSpace ();
		GUILayout.EndHorizontal();

		GUILayout.Label (valueComponents[currentStep].valueTitle + "\n", Master.styleTextHeaderCenter);
		GUILayout.Label (valueComponents[currentStep].yearText + "\n", Master.styleTextDefaultCenterItalic);
		GUILayout.Label (valueComponents[currentStep].value1Text + "\n", Master.styleTextDefaultCenter);
		GUILayout.Label (valueComponents[currentStep].value2Text + "\n", Master.styleTextDefaultCenterItalic);
		GUILayout.EndVertical ();
	}

	void OnGUI_Details ()
	{
		GUILayout.BeginHorizontal ();
		GUILayout.FlexibleSpace ();
		GUILayout.BeginVertical ();

		if (currentStep >= 0) {
			GUILayout.Label ("  Details", Master.styleTextHeaderPadding);
			GUILayout.BeginVertical (Master.styleBoxGreyLineOnTop, GUILayout.ExpandHeight (true));


			switch (currentStep) {
			case 0:
					OnGUI_DetailValue1 ();
					break;
			case 1:
					OnGUI_DetailValue2 ();
					break;
			case 2:
					OnGUI_DetailValue3 ();
					break;
			case 3:
					OnGUI_DetailValue4 ();
					break;
			case 4:
					OnGUI_DetailValue5 ();
					break;
			case 5:
					OnGUI_DetailValue6 ();
					break;
			}

			GUILayout.EndVertical ();
		}
		GUILayout.EndVertical ();
		GUILayout.FlexibleSpace ();
		GUILayout.EndHorizontal ();
	}

	private void Start_AddValue(int valueIndex, Texture2D origValueTexture, Texture2D valueTexture, string valueTitle, string yearText, string value1Text, string value2Text){
		ValueComponent comp = new ValueComponent(origValueTexture, valueTexture, valueTitle, yearText, value1Text, value2Text);
		valueComponents [valueIndex] = comp;
	}

	private void OnGUI_AddValue(int valueIndex) {

		//int baseIndentForStep = DisplayMetricsUtil.DpToPixel (40); //12 is good because first and last values text are at right side limted at the same time
		int tmp = Mathf.RoundToInt(DisplayMetricsUtil.GetShortSideInDP()/50);
		//if (tmp < 40) {
		int	baseIndentForStep = DisplayMetricsUtil.DpToPixel (tmp);
		//}
		GUILayout.BeginHorizontal ();
		GUILayout.Label("",GUILayout.Width(baseIndentForStep*valueIndex));
		if(GUILayout.Button(new GUIContent("  " + valueComponents[valueIndex].valueTitle, valueComponents[valueIndex].valueTexture))){
			currentStep = valueIndex;
			resetScrollPosition();
		}
		GUILayout.EndHorizontal ();
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
		if (currentStep > -1) {
			if (GUILayout.Button (Master.arrowLeftI, Master.styleButtonNoStyleCentered, GUILayout.Height(Master.titleBarButtonHeight), GUILayout.Width(Master.titleBarButtonHeight))) {
				currentStep--;
				resetScrollPosition();
			}
		}
		GUILayout.FlexibleSpace ();
		if (currentStep < 5) {
			if (GUILayout.Button (Master.arrowRightI, Master.styleButtonNoStyleCentered, GUILayout.Height(Master.titleBarButtonHeight), GUILayout.Width(Master.titleBarButtonHeight))) {
				currentStep++;
				resetScrollPosition();
			}
		}
		GUILayout.EndHorizontal ();
		GUILayout.FlexibleSpace ();
		GUILayout.EndVertical ();
		GUILayout.EndArea ();
	}

	private void OnGUI_DetailValue1(){
		GUILayout.Label ("Das Humanistische Denken war der erste Schritt weg vom theozentrischen Weltbild des Mittelalters zum kommenden humanistischen Weltbild der Neuzeit.\n\n", Master.styleTextDefault);
		GUILayout.Label ("Die Wurzeln der Europäischen Werte liegen in den Ideen der humanistischen Weltsicht der griechischen und römischen Antike. \n\n", Master.styleTextDefault);
		GUILayout.Label ("Humanistisches Denken war der Beginn der Gegenbewegung zum theozentrischen Weltbild (alles von einem Gott, alles für einen Gott) des Mittelalters. Das theozentrische Weltbild des Mittelalters betonte meist die Nichtigkeit des Menschen im Vergleich zu Gottes Vollkommenheit. Der Fokus schien mehr auf den Unzulänglichkeiten des Menschen zu liegen. Auch menschliche Fähigkeiten, wie z.B. kritisches Denken, wurden im Gegensatz zu Gottes Allwissenheit als unzureichend oder anmaßend angesehen. \n\n", Master.styleTextDefault);
		GUILayout.Label ("Humanistisches Denken bedeutet, den Menschen und sein Handeln in den Mittelpunkt zu rücken. Es beinhaltet eine neue geistige Grundhaltung, die davon ausgeht, dass der Mensch (mit all seinen Fähigkeiten) einen eigenständigen Wert gegenüber der Allmacht Gottes erhält.\n\n", Master.styleTextDefault);
	}

	private void OnGUI_DetailValue2(){
		GUILayout.Label ("Erstmals darf nun die Fähigkeit der menschlichen Vernunft zur Urteilsfindung neben dem Glauben mitherangezogen werden. \n\n", Master.styleTextDefault);
		GUILayout.Label ("Die zweite Stufe Rationalität entsteht, die, vom Menschen kommende, Vernunft wird als letztendliche Entscheidungsquelle zur Urteilsfindung akzeptiert und steht damit an Stelle des Glaubens.\n\n", Master.styleTextDefault);
		GUILayout.Label ("Ohne Humanismus hätte die menschliche Vernunft neben der unendlichen und undurchschaubaren Weisheit Gottes, die im Mittelalter fast 1.000 Jahre als oberstes Prinzip galt, nicht bestehen können.\n\n", Master.styleTextDefault);
		GUILayout.Label ("Es ist wichtig zu verstehen, dass erst die im Humanistischen Denken begründete Wertschätzung für die Fähigkeiten des Menschen diesen Gedanken möglich machte. Zuvor wurden die menschlichen Fähigkeiten so gering geschätzt, dass es schlicht undenkbar war, die menschliche Vernunft als Ressource für Urteilsfindung zu verwenden. So wird verständlich, warum sich Rationalität erst auf der Basis des Humanistischen Denkens entwickeln konnte.\n\n", Master.styleTextDefault);
	}

	private void OnGUI_DetailValue3(){
		GUILayout.Label ("Da rationales logisches Denken dogmatisches religiöses Denken immer mehr widerlegte, wurde die Religion, welche vorher fast alle Bereiche des Lebens regelte mehr und mehr aus dem weltlichen Bereich zurückgedrängt bis die Machtbefugnisse von Religion und Politik wieder getrennt wurden..\n\n", Master.styleTextDefault);
		GUILayout.Label ("Die dritte Stufe Säkularität wurde verwirklicht. Von nun an muss zumindest die Politik der Vernunft folgen, die Religion wird zur Privatsache. \n\n", Master.styleTextDefault);
		GUILayout.Label ("Erst durch rationales Denken konnten den dogmatischen Regeln der Religion vernünftige Regeln, die durch logisches Schlussfolgern entstanden, gegenübergestellt werden. Vor der Aufwertung der menschlichen Vernunft gab es diese zweite Möglichkeit nicht. Diese durch die Rationalität entstandene Möglichkeit, im weltlichen Leben rationale Schlüsse als Basis für Entscheidungen und Gesetze zu verwenden, fand ihren Ausdruck im Prinzip der Säkularität.\n\n", Master.styleTextDefault);
		GUILayout.Label ("Säkularität bedeutet, im Denken diesseitige Entwicklungen (Politik) von der eigenen jenseitigen Entwicklung (Religion) zu trennen! D.h. von nun an muss zumindest die Politik der Vernunft folgen. Religiöse Dogmen dürfen die politischen Entscheidungen, die dem Wohl der Allgemeinheit dienen, nicht behindern.\n\n", Master.styleTextDefault);
		GUILayout.Label ("Durch Rationalität kam es zur Urteilsfindung über die Vernunft für alles Diesseitige (Politik, Wissenschaft). Religion wurde nun zur Privatsache. Davor regelte die Religion alle Bereiche des Lebens. Politische Entscheidungen werden vom Einfluss religiöse Dogmen befreit.\n\n", Master.styleTextDefault);
		GUILayout.Label ("Säkularität bezeichnet die Trennung staatlicher und religiöser Organisationen per Gesetz. Die Trennung von Politik und Religion, Staat und Staatskirche.\n\n", Master.styleTextDefault);
	}

	private void OnGUI_DetailValue4(){
		GUILayout.Label ("Erst angewandte Säkularität führt zur vierten Stufe: Rechtsstaatlichkeit. Diese führt zur Anerkennung von Grundgesetzen und Verfassungen, die von Menschen gemacht wurden, die nicht von Gott gemacht oder von „Gottesgnaden“ eingeleitet wurden. \n\n", Master.styleTextDefault);
		GUILayout.Label ("Ohne Säkularität gäbe es keine gültigen Gesetze, die nicht von Gott gemacht oder „von Gottes Gnaden“ eingeleitet wurden.\n\n", Master.styleTextDefault);
		GUILayout.Label ("Erst wenn der Einzelne Politik von Religion in seinem Denken trennen kann, kann er säkulare, rechtsstaatliche Prinzipien in seinem Denken akzeptieren.\n\n", Master.styleTextDefault);
		GUILayout.Label ("Das ist die Grundlage für säkulare Grundgesetze und Verfassungen.\n\n", Master.styleTextDefault);
		GUILayout.Label ("Echte Rechtsstaatlichkeit wie sie vorab beschrieben wurde, kann nur auf der Basis von Säkularität entstehen.\n\n", Master.styleTextDefault);
	}

	private void OnGUI_DetailValue5(){
		GUILayout.Label ("Die entstehenden Grundrechte des Einzelnen und die Durchsetzung der Gewaltenteilung bildeten die Basis, von der aus der Bürger es wagte, von seinem Herrscher ein Mitbestimmungsrecht einzufordern. Die fünfte Stufe Demokratie entsteht.\n\n", Master.styleTextDefault);
		GUILayout.Label ("Ohne Rechtsstaatlichkeit gäbe es keine Basis für demokratische Prinzipien.\n\n", Master.styleTextDefault);
		GUILayout.Label ("Erst wenn säkulare, rechtsstaatliche Prinzipien im Denken akzeptiert werden können, können demokratische Prinzipien zugelassen, eingefordert und umgesetzt werden.\n\n", Master.styleTextDefault);
		GUILayout.Label ("Auf der Grundlage säkularer Grundgesetze in der Verfassung entsteht eine Demokratie!\n\n", Master.styleTextDefault);
	}

	private void OnGUI_DetailValue6(){
		GUILayout.Label ("Die Forderung zur Umsetzung der universellen Menschenrechte der sechsten und letzten Stufe wird nur in einer funktionierenden Demokratie Rechnung getragen. \n\n", Master.styleTextDefault);
		GUILayout.Label ("Erst das Verständnis der Menschen für die Sinnhaftigkeit von Demokratie und der gesamtgesellschaftlichen Durchsetzung von zwischenmenschlichen Grundwerten machte die UNO-Menschenrechtscharta zu einem wünschenswerten Gut.\n\n", Master.styleTextDefault);
		GUILayout.Label ("Kaum jemand würde in einer anderen Staatsform als in der Demokratie die universellen Menschenrechte verbindlich einhalten. Außerdem können nur Bürger, die in einer funktionierenden Demokratie leben, daran denken, die Umsetzung der universellen Menschenrechte zu fordern. \n\n", Master.styleTextDefault);
		GUILayout.Label ("Zu wenig beachtet wird oft auch der Umstand, dass die Achtung und der Schutz der Menschenrechte wechselseitig abhängig sind von funktionierenden demokratischen und effizienten rechtsstaatlichen Strukturen.\n\n", Master.styleTextDefault);
		GUILayout.Label ("Die demokratische Weltsicht gipfelt in der Allgemeinen Erklärung der Menschenrechte, die für alle Menschen auf der Erde gelten sollen.\n\n", Master.styleTextDefault);
	}
}