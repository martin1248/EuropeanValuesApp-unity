using UnityEngine;
using System.Collections;

public class Main : MyMonoBehaviour {
    private static string enteredMemberId = "";

    protected override void UpdateExtended () {
	}

    IEnumerator Start()
    {
        Member.LoadLocal();
        if (!Member.isMember)
        {
            return Member.checkMember(enteredMemberId != "" ? enteredMemberId : Member.EVERYONE);
        } else
        {
            return null;
        }
    }
    /**
	 * PLAYER SETTINGS - SCRIPTING BACKEND - auf 64 bit gesetzt. Siehe: http://docs.unity3d.com/Manual/iphone-64bit.html
	 * 
	 * Bundle Identifier

		The Bundle Identifier string MUST MATCH the provisioning profile of the game you are building. The basic structure of the identifier is com.CompanyName.GameName. This structure may vary internationally based on where you live, so always default to the string provided to you by Apple for your Developer Account. Your GameName is set up in your provisioning certificates, that are manageable from the Apple iPhone Developer Center website. Please refer to the Apple iPhone Developer Center website for more information on how this is performed.
	 * 
	 * 
	 * 
	 * 
	 * TODO  - CHECK PERFORMANCE IMPACT (IF IT IS NOT OBVIOUS I MIGHT JUST NEGLECT THIS)
		What kind of performance impact will UnityGUI make on my games?

		A: UnityGUI is fairly expensive when many controls are used. 
		It is ideal to limit your use of UnityGUI to game menus or very minimal GUI Controls while your game is running. 
		It is important to note that every object with a script containing an OnGUI() call 
		will require additional processor time – even if it is an empty OnGUI() block. 
		It is best to disable any scripts that have an OnGUI() call if the GUI Controls are not being used. 
		You can do this by marking the script as enabled = false.



		Any other tips for using UnityGUI?
		A: Try using GUILayout as little as possible. If you are not using GUILayout at all from one OnGUI() call, you can disable all GUILayout rendering using MonoBehaviour.useGUILayout = false; This doubles GUI rendering performance. Finally, use as few GUI elements while rendering 3D scenes as possible.
	 */
    void OnGUI() {
        OnGUI_Before("");
        OnGUI_ScrollViewStart();
        GUILayout.FlexibleSpace();

        if (!Member.isMember)
        {
            if (!Member.connectionCheckCompleted || !Member.internetConnectionExists)
            {
                GUILayout.Label("DIE EUROPÄISCHEN WERTE", Master.styleTextStartSceneBig);

                GUILayout.BeginHorizontal();
                GUILayout.FlexibleSpace();
                if (GUILayout.Button(Master.circle7a, Master.styleButtonNoStyle, GUILayout.MaxHeight(DisplayMetricsUtil.GetShortSide()*0.6f), GUILayout.MaxWidth(DisplayMetricsUtil.GetShortSide() * 0.6f)))
                {
                    Application.LoadLevel("MainScene");
                }
                GUILayout.FlexibleSpace();
                GUILayout.EndHorizontal();

                GUILayout.FlexibleSpace();
				if (Member.connectionCheckCompleted && !Member.internetConnectionExists)
                {
                    GUILayout.Label("Bitte stellen Sie eine Verbindung mit dem Internet her.\nDas ist nur einmal notwendig.", Master.styleTextDefaultCenter);
                } else
                {
                    GUILayout.Label("Die APP wird initialisiert.\nBitte warten ...", Master.styleTextDefaultCenter);
                }
            }
            else
            {
				// This code is reached when
				// - Connection check is completed
				// - Internet connection exists
				// - User is NOT a member
				//GUILayout.Label("Geben Sie unten Ihren Code ein,\nden Sie von TeamFreiheit erhalten,\n um die App zu aktivieren:", Master.styleTextDefaultCenter);
                //GUILayout.Label("", GUILayout.MinHeight(DisplayMetricsUtil.DpToPixel(3)));
				GUILayout.Label("APP CODE eingeben:", Master.styleTextHeaderCenter);
                
				GUILayout.BeginHorizontal();
                GUILayout.FlexibleSpace();
				//GUILayout.Label("APP CODE:", Master.styleTextAppCode, GUILayout.Height(Master.guiElementHeightDefault*1.1f)); //NOTE: Dirty small UI fix
                enteredMemberId = GUILayout.TextField(enteredMemberId, Master.menuSkin.textField, GUILayout.Height(Master.guiElementHeightDefault), GUILayout.Width(DisplayMetricsUtil.DpToPixel(130)));
                GUILayout.FlexibleSpace();
                GUILayout.EndHorizontal();
                GUILayout.Label("", GUILayout.MinHeight(DisplayMetricsUtil.DpToPixel(3)));
				GUILayout.BeginHorizontal();
                GUILayout.FlexibleSpace();
                if (GUILayout.Button("Aktivieren", Master.styleButtonTorquise, GUILayout.Height(Master.guiElementHeightDefault), GUILayout.Width(DisplayMetricsUtil.DpToPixel(250))))
                {
                    Application.LoadLevel("MainScene");
                }
                GUILayout.FlexibleSpace();
                GUILayout.EndHorizontal();
                GUILayout.Label("", GUILayout.MinHeight(DisplayMetricsUtil.DpToPixel(5)));
				if(Member.checkFailed) {
					GUILayout.Label(Member.errorMessage, Master.styleTextDefaultRed);
				} else {
	                if (!Member.isEveryone)
	                {
	                    GUILayout.Label("Der Code ist nicht gültig", Master.styleTextDefaultRed);
	                }
				}
				GUILayout.Label("", GUILayout.MinHeight(DisplayMetricsUtil.DpToPixel(5)));

                GUILayout.FlexibleSpace();

				GUILayout.FlexibleSpace();




				GUILayout.Label("Um einen App Code zu bekommen, \nschreiben Sie eine E-Mail mit dem Betreff \"APP CODE\" an:", Master.styleTextDefaultCenter);
				GUILayout.Label("", GUILayout.MinHeight(DisplayMetricsUtil.DpToPixel(3)));
				GUILayout.BeginHorizontal();
				GUILayout.FlexibleSpace();
				if (GUILayout.Button(GetActive.emailAdress, Master.styleButtonTorquise, GUILayout.Height(Master.guiElementHeightDefault)))
				{
					Application.OpenURL("mailto:" + GetActive.emailAdress);
				}
				GUILayout.FlexibleSpace();
				GUILayout.EndHorizontal();

				GUILayout.FlexibleSpace();


                
                GUILayout.Label("Besuchen Sie auch die Website:", Master.styleTextDefaultCenter);
                GUILayout.Label("", GUILayout.MinHeight(DisplayMetricsUtil.DpToPixel(3)));
                GUILayout.BeginHorizontal();
                GUILayout.FlexibleSpace();
                if (GUILayout.Button("Europaeischewerte.info", Master.styleButtonTorquise, GUILayout.Height(Master.guiElementHeightDefault)))
                {
                    Application.OpenURL(GetActive.urlEuropeanValues);
                }
                GUILayout.FlexibleSpace();
                GUILayout.EndHorizontal();
            }
        } else { 
            GUILayout.Label("DIE EUROPÄISCHEN WERTE", Master.styleTextStartSceneBig);
            GUILayout.Label("", GUILayout.MinHeight(DisplayMetricsUtil.DpToPixel(15)));

            GUILayout.BeginHorizontal();
            GUILayout.Label("", GUILayout.MinWidth(DisplayMetricsUtil.DpToPixel(1))); // Indent complete menu to the right
            GUILayout.BeginVertical();
            GUI.skin = Master.menuSkin;
            if (GUILayout.Button(new GUIContent("     Die Werte ", Master.v1p)))
            {
                Application.LoadLevel("ValuesScene");
            }
            if (GUILayout.Button(new GUIContent("     Ihre Geschichte", Master.v2p)))
            {
                Application.LoadLevel("HistoryOfValuesScene");
            }
            if (GUILayout.Button(new GUIContent("     Werte? Wozu?", Master.menuIconQuestionMark)))
            {
                Application.LoadLevel("NeedOfValues");
            }
            if (GUILayout.Button(new GUIContent("     Was kann ich tun?", Master.menuIconDefault)))
            {
                Application.LoadLevel("GetActiveScene");
            }
            GUILayout.EndVertical();
            GUILayout.Label("", GUILayout.MinWidth(DisplayMetricsUtil.DpToPixel(1))); // Indent complete menu to the left
            GUILayout.EndHorizontal();

            GUILayout.Label("", GUILayout.MinHeight(DisplayMetricsUtil.DpToPixel(15)));
            GUILayout.Label("Copyright by TeamFreiheit.info\nHumanistischer Verein für Demokratie und Menschenrechte", Master.styleTextStartSceneSmall);
        }
		GUILayout.FlexibleSpace ();
		GUILayout.FlexibleSpace ();
		OnGUI_ScrollViewEnd ();
		OnGUI_Button ();
	}

	void OnGUI_Button ()
	{
		int buttonBarHeight = Master.getTitleBarHeight();
		int buttonBarWidth = Master.titleBarButtonHeight*2 + Master.globalContentPadding;
		Rect guiArea = new Rect (Screen.width - buttonBarWidth - Master.globalContentPadding, 0, buttonBarWidth, buttonBarHeight);
		GUILayout.BeginArea(guiArea);
		GUILayout.BeginVertical ();
		GUILayout.FlexibleSpace ();
		GUILayout.FlexibleSpace ();
		GUILayout.BeginHorizontal ();
		if (GUILayout.Button (Master.infoTextureI, Master.styleButtonNoStyleCentered, GUILayout.Height(Master.titleBarButtonHeight), GUILayout.Width(Master.titleBarButtonHeight))) {
			Application.LoadLevel("TeamFreiheitScene"); 
		}
		GUILayout.FlexibleSpace ();
		if (GUILayout.Button (Master.facebookI, Master.styleButtonNoStyleCentered, GUILayout.Height(Master.titleBarButtonHeight), GUILayout.Width(Master.titleBarButtonHeight))) {
			Application.OpenURL("http://www.facebook.com/teamfreiheit"); 
		}
		GUILayout.EndHorizontal ();
		GUILayout.FlexibleSpace ();
		GUILayout.EndVertical ();
		GUILayout.EndArea ();
	}
}