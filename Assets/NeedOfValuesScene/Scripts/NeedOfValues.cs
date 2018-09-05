using UnityEngine;
using System.Collections;

public class NeedOfValues : MyMonoBehaviour {
	protected override void UpdateExtended () {}

	void OnGUI() {
		OnGUI_Before ("Werte? Wozu?");
		OnGUI_ScrollViewStart ();

		GUILayout.Label ("Menschenrechte wirken sich auf unseren Alltag aus\n\nVergleiche:", Master.styleTextHeaderCenter);

		GUILayout.BeginHorizontal ();
		GUILayout.Label ("MIT Menschenrechte", Master.styleBoxTorquise, GUILayout.Height (Master.guiElementHeightDefault*1.5f));
		GUILayout.FlexibleSpace ();
		GUILayout.Label ("OHNE Menschenrechte", Master.styleBoxRed, GUILayout.Height (Master.guiElementHeightDefault*1.5f));
		GUILayout.EndHorizontal ();

		GUILayout.BeginVertical ();
		GUILayout.Label ("", GUILayout.Height (DisplayMetricsUtil.DpToPixel (1)));
		OnGUI_Line ("Heirat", "Ich heirate, wen ich will und liebe.", "Ich werde verheiratet und es wird keine Rücksicht darauf genommen, wen ich liebe.");
		OnGUI_Line ("Religion", "Ich glaube an einen oder keinen Gott. \nIch wechsle meine Religion.", "Religionswechsel ist nicht drin. \nDas könnte tödlich ausgehen!");
		OnGUI_Line ("Hautfarbe", "Meine Hautfarbe ist gelb, oder weiß , oder schwarz …egal, ich kann im Bus sitzen, wo ich will.", "Meine Hautfarbe ist gelb, oder weiß , oder schwarz …und davon hängt ab, wo ich im Bus sitze.");
		OnGUI_Line ("Bildung", "Ich habe ein Recht darauf zu studieren.", "Bildung ist ein Privileg. Ich kann‘s mir nicht leisten - Pech gehabt! \nIch bin eine Frau – Pech gehabt! \nIch hab die falsche Hautfarbe – Pech gehabt!");
		OnGUI_Line ("Selbst-/Fremdbestimmung", "Mein Leben gehört mir. Ich entscheide selbst darüber.", "Mein Leben wird von willkürlichen Regeln von Staat und Kirche fremdbestimmt.");
		OnGUI_Line ("Sozialer Status", "Ich bin gleich viel wert wie ein Mann, mein Nachbar, der Bundespräsident.", "Als Frau bin ich weniger wert als ein Mann. Die soziale Oberschicht hat mehr Rechte als die Unterschicht.");
		OnGUI_Line ("Arbeit", "Ich habe ein Recht auf angemessene Bezahlung.", "Ich muss arbeiten wie ein Sklave, und schlimmer noch, ich werde wie einer bezahlt.");
		GUILayout.EndVertical ();

		OnGUI_ScrollViewEnd ();
	}

	private void OnGUI_Line(string lineHeader, string lineTextWith, string lineTextWithout){
		GUILayout.BeginVertical ();

		GUILayout.BeginHorizontal ();
		GUILayout.FlexibleSpace ();
		GUILayout.Label (lineHeader, Master.styleTextHeader);
		GUILayout.FlexibleSpace ();
		GUILayout.EndHorizontal ();

		GUILayout.BeginVertical (Master.styleBoxGreyLineOnTop);

		int indent = Mathf.RoundToInt(DisplayMetricsUtil.DpToPixel (DisplayMetricsUtil.PixelToDp(Screen.width)/8));

		GUILayout.BeginHorizontal (GUILayout.MaxHeight(0));
		OnGUI_LineColumn (lineTextWith, Master.styleBoxTorquise);
		GUILayout.FlexibleSpace ();
		GUILayout.Label("", GUILayout.MinWidth(indent),GUILayout.Height(1)); // GUILayout.Height(1) it was not easy to find this solution for a not easy to understand problem
		GUILayout.EndHorizontal ();

		GUILayout.BeginHorizontal ();
		GUILayout.Label("", GUILayout.MinWidth(indent),GUILayout.Height(1));
		GUILayout.FlexibleSpace ();
		OnGUI_LineColumn (lineTextWithout, Master.styleBoxRed);
		GUILayout.EndHorizontal ();

		GUILayout.EndVertical ();

		GUILayout.Label ("",GUILayout.MinHeight(DisplayMetricsUtil.DpToPixel(5)));
		
		GUILayout.EndVertical ();
	}
	
	void OnGUI_LineColumn (string text, GUIStyle style) {
		GUILayout.BeginVertical (style);
		GUILayout.Label (text, Master.styleTextDefault);
		GUILayout.EndVertical ();
	}
}
