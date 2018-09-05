using UnityEngine;
using System.Collections;

public class HintsForLetter : MyMonoBehaviour {
	protected override void UpdateExtended () {
	}
	
	void OnGUI() {
		OnGUI_Before ("Leserbrief");
		OnGUI_ScrollViewStart ();

		GUILayout.Label ("Wie man einen Leserbrief verfasst:", Master.styleTextBig);

		OnGUI_Header("Rasch reagieren!");
		GUILayout.Label ("Zeitungen veröffentlichen selten Leserbriefe zu Themen, die nicht mehr aktuell sind. Sich auf einen gerade erschienenen Beitrag zu beziehen, erhöht die Chancen der Veröffentlichung des Leserbriefs.", Master.styleTextDefault);
	
		OnGUI_Header("Kurz halten!");
		GUILayout.Label ("Sehen Sie sich andere Leserbriefe an, um eine passende Länge für die jeweilige Zeitung abzuschätzen. Wenn der Leserbrief zu lang ist, kürzt die Redaktion Teile weg, die sie für unwichtiger hält. Auch werden kürzere Leserbriefe eher gelesen als lange!", Master.styleTextDefault);
	
		OnGUI_Header("Klare Struktur verwenden!");
		GUILayout.Label ("Zuerst: Worauf man sich bezieht. \nDann: Worin man übereinstimmt. \nDann: Worin man abweicht und warum.", Master.styleTextDefault);
	
		OnGUI_Header("Genau sein!");
		GUILayout.Label ("Man sollte sich wenn möglich auf einen bestimmten Zeitungs- oder Leitartikel (mit Datum und Titel) beziehen und klar ausdrücken, worauf man abzielt: “Ich widerspreche Abgeordnetem Soundso in seiner Position in dieser oder jener Sache, weil…“", Master.styleTextDefault);
	
		OnGUI_Header("Fokussiert bleiben!");
		GUILayout.Label ("Die eigene Position so kurz und bündig wie möglich halten, ohne notwendige Details wegzulassen. Zu lange Sätze und Umschweifen lassen den Leser schnell das Interesse verlieren. Bei einem Punkt oder Thema bleiben!", Master.styleTextDefault);

		OnGUI_Header("Annehmbare Argumente verwenden!");
		GUILayout.Label ("Die Leserschaft beim Überlegen der Argumente immer vor Augen haben! Vernunft- und Erfahrungswerte verwenden. Auch sollten schon dargelegte Sichtweisen nicht einfach wiederholt werden. Leser wollen kurze, einsichtige Gedanken und neue Perspektiven.", Master.styleTextDefault);
					
		OnGUI_Header("Einen ansprechenden Anfang wählen!");
		GUILayout.Label ("Ein interessanter Titel und erster Satz werden die Aufmerksamkeit von Lesern auf sich ziehen, die die Zeitung nur durchblättern.", Master.styleTextDefault);

		OnGUI_Header("Persönlicher Ansatzpunkt");
		GUILayout.Label ("Leser sind oft mehr an Themen interessiert, wenn diese ihr Leben und ihre Umgebung bewegen. Eine persönliche Note („Das betrifft mich insofern, als…“) verleiht zudem Glaubwürdigkeit.", Master.styleTextDefault);

		OnGUI_Header("Wenn möglich, humorvoll sein!");
		GUILayout.Label ("Wenn das Thema es erlaubt, ist Humor oder sogar Ironie von Vorteil. Was den Leser zum Schmunzeln bringt, erleichtert die Akzeptanz.", Master.styleTextDefault);
				
		OnGUI_Header("Nichts voraussetzen!");
		GUILayout.Label ("Gehen Sie nicht davon aus, dass die Leser über das Thema Bescheid wissen. Oft ist es gut, kurz eine Hintergrundinformation zu geben, bevor man zu seinen eigentlichen Argumenten kommt.", Master.styleTextDefault);


		OnGUI_ScrollViewEnd ();
	}

	private void OnGUI_Header(string text){
		GUILayout.Label (text, Master.styleTextHeaderPadding);
		GUILayout.BeginVertical (Master.styleBoxGreyLineOnTop);
		GUILayout.EndVertical ();
	}
}
