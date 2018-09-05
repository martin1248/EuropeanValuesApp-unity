using UnityEngine;
using System.Collections;

public class GetActive : MyMonoBehaviour {
    public  static string urlEuropeanValues = 			"http://europaeischewerte.info";
	public  static string urlTeamfreiheit = 			"http://teamfreiheit.info";
	private static string urlTeamfreiheitGetActive = 	"http://teamfreiheit.info/deutsch/aktivwerden.html";
	private static string urlTeamfreiheitDonate = 		"http://teamfreiheit.info/deutsch/spenden.html";
	private static string urlTeamfreiheitPetition = 	"http://teamfreiheit.info/petitionen.html";
	private static string urlTeamfreiheitBuch = 		"http://teamfreiheit.info/buch.html";
	//private static string urlTeamfreiheitCommunity = 	"http://community.teamfreiheit.info";
	private static string urlTeamfreiheitLearntool = 	"http://learntool.teamfreiheit.info/";
	private static string urlFacebookTeamfreiheit = 	"http://www.facebook.com/teamfreiheit";
	public  static string emailAdress = "kontakt@teamfreiheit.info";

	public Texture2D toVote;
	public Texture2D book;
	public Texture2D game;
	
	private GetActiveComponent[] components = new GetActiveComponent[17];

	void Start(){
		components[0] = new GetActiveComponent ("Zeitung lesen", null, null , null, 
			"Die Zeitung ist das wichtigste Informationsmedium unserer Zeit:\n" +
			" - Informiere dich welche Entscheidungen die Politiker treffen.\n"  +
			" - Sei dir bewusst, was in deinem Land und der Welt rundherum passiert.");
		components[1] = new GetActiveComponent ("Facebook Beiträge lesen", null, "Zur Facebook Seite" , urlFacebookTeamfreiheit, 
	        "Auf Facebook posten wir aktuelle Artikel von Zeitungen und mehr, die die 6 Werte betreffen.");
		components[2] = new GetActiveComponent ("Newsletter abonnieren", null, "Newsletter abonnieren" ,urlTeamfreiheit, 
			"Bei besonderen Themen, die unsere Werte oder ihre Einschränkung betreffen, senden wir einen Newsletter aus. \n\n" +
			"Melde dich dafür auf der Website an.");


		components[3] = new GetActiveComponent ("Website \"Die Europäischen Werte\"", null, "Zur Website",urlEuropeanValues, 
			"Ausführlich kannst du dich auf der eigens dafür eingerichteten Webseite informieren.");
		components[4] = new GetActiveComponent ("Das Buch \"Der Bauplan der Freiheit\"", book, "Buch bestellen" ,urlTeamfreiheitBuch, 
			"Unser Buch widmet sich ebenso den \"Europäischen Werten\" und ihrer Entstehung.");
		components[5] = new GetActiveComponent ("Vortrag von TeamFreiheit", null, null ,null, 
		    "Besuche einen Vortrag von TeamFreiheit. Kontaktiere uns, dann informieren wir dich über die nächsten Termine.\n\n" + emailAdress);
		components[6] = new GetActiveComponent ("Lernspiel im Internet", game, "Zum Spiel" ,urlTeamfreiheitLearntool, 
			"Auf unserer Website findet ihr unser Lernspiel. \n"+
			"In diesem Spiel beginnt ihr im Mittelalter und müsst den werdenden Helden dabei helfen, die bekannten Werte aus der Antike in die mittelalterliche Gesellschaft einzuführen.\n"+
		    "Hinweis: Das Spiel kann nur mit einem Computer mit Internetanschluss gespielt werden.");

		components[7] = new GetActiveComponent ("Wählen gehen", toVote, null ,null, 
	        "Wählen zu gehen ist keine Pflicht, sondern ein lang erkämpftes Recht.\n"+
	        "Nur wenn du wählen gehst, kannst du aktiv mitentscheiden, wie du dir deine Zukunft vorstellst. "+
	        "Wenn du nicht wählen gehst, überlässt du die Gestaltung deiner Zukunft anderen.\n");
		components[8] = new GetActiveComponent ("Unterschreibe Petitionen", null, "Zu den Petitionen" ,urlTeamfreiheitPetition, 
			"Eine Petitione ist ein anerkanntes Mittel einer Demokratie. Ein Ersuchen aus dem Volk heraus, das man an die Politiker weiterleitet.\n" +
			"Je mehr sich auf einer Petitionsliste eintragen, umso deutlicher zeigt es den Volksvertretern, was dem Volk wichtig ist.");
		components[9] = new GetActiveComponent ("Schreibe E-Mails an Journalisten", null, null ,null, 
            "Leserbriefe sind oft die meist gelesenen Artikel einer Zeitung. Sie sind ein schnelles und effizientes Mittel, um eine Meinung einem breiten Publikum zugänglich zu machen. Man geht davon aus, dass ein Leserbrief für einen großen Teil der Bevölkerung spricht.");
		components[10] = new GetActiveComponent ("Schreibe E-Mails an die Politiker", null, null ,null, 
			"Politiker sind die Vertreter des Volkes in der Regierung und vertreten die Interessen von allen und auch dir.\n"+
			"Schreibe den Politikern ein E-Mail, was aus deiner Sicht bedeutend ist und welche Missstände es zu beheben gibt.\n");
		components[11] = new GetActiveComponent ("Auf Petitionen aufmerksam machen", null, null ,null, 
			"Eine Petition gewinnt mit steigender Anzahl an Unterschriften an Bedeutung und Dringlichkeit für die Politiker. "+
			"Leite die Petition an Freunde und Bekannte weiter.");
		components[12] = new GetActiveComponent ("TeamFreiheit weiterempfehlen", null, null, null, 
		    "Erzähle Freunden und Bekannten von TeamFreiheit. Wenn wir breit aufgestellt sind, dann können wir mehr Druck auf die Politik ausüben.");


		components[13] = new GetActiveComponent ("Einmalige Spende", null, "Zur Spenden Website" ,urlTeamfreiheitDonate,
			"Unterstütze uns durch eine Spende und ermögliche es uns, Vorträge zu halten.");



		components[14] = new GetActiveComponent ("Werde Fördermitglied", null, "Zur Website" ,urlTeamfreiheitDonate, 
		    "Dein monatlicher Beitrag ermöglicht unseren Einsatz für den Erhalt der Freiheiten in Europa. Mit jedem neuen Mitglied wächst unser Team von Freiheitskämpfern.\n\n"+
         	"Unsere Kontodaten:\n"+
         	"Kontoinhaber: TeamFreiheit.info\n"+
         	"IBAN: AT556000000510083555,\n"+
         	"BIC: OPSKATWW");


		components[15] = new GetActiveComponent ("TeamFreiheit Vortrag organisieren", null, null ,null, 
		    "Mit einem Vortrag ermöglichst du auch anderen Interessierten TeamFreiheit kennen zu lernen. "+
		    "Organisiere einen Vortrag vor Ort, an einer Schule, einer Universität, einem öffentlichen Vortragsraum oder im privaten Rahmen!"+
		    "Bei Interesse kontaktiere uns unter kontakt@teamfreiheit.info.\n\n" + emailAdress);
		//components[16] = new GetActiveComponent ("Nimm an der Community teil", null, "Zur Community" ,urlTeamfreiheitCommunity, 
		//	"Die Community von Teamfreiheit bietet eine Platform um sich mit Anderen u.a. bezüglich aktuelle Themen auszutauschen.");
		components[16] = new GetActiveComponent ("Bei TeamFreiheit aktiv sein", null, "Zur Website" ,urlTeamfreiheitGetActive, 
		    "Dir gefällt TeamFreiheit und du möchtest aktiv werden, um die Europäischen Werte zu erhalten? Kontaktiere uns:\n\n"+
		emailAdress);
	}

	protected override void UpdateExtended () {}

	void OnGUI() {
		OnGUI_Before ("Was kann ich tun?");
		OnGUI_ScrollViewStart ();

		int spaceAfterYellowText = DisplayMetricsUtil.DpToPixel (20);
		int spaceAfterGetActiveComponent = DisplayMetricsUtil.DpToPixel (30);

		for (int i = 0; i < components.Length; i++) {
			if (i == 0) {
				GUILayout.Label ("Jeder kann etwas auf seine Weise beitragen!\n"+
				         "Und jeder hat Verantwortung für kommende Generationen!", Master.styleTextBigYellow);
				GUILayout.Label("",GUILayout.MinHeight(spaceAfterYellowText));
				GUILayout.Label ("Informier dich", Master.styleTextDefaultTorquise);
			}
			else if (i == 3) {
				GUILayout.Label ("Informier dich über die Europäischen Werte", Master.styleTextDefaultTorquise);
			}
			else if (i == 7) {
				GUILayout.Label ("Werte müssen immer wieder aktiv eingefordert werden. Dort wo sie nicht eingefordert werden, werden sie sonst ignoriert und übergangen.", Master.styleTextBigYellow);
				GUILayout.Label("",GUILayout.MinHeight(spaceAfterYellowText));
				GUILayout.Label ("Sei selbst aktiv in der Demokratie", Master.styleTextDefaultTorquise);
			}
			else if (i == 11) {
				GUILayout.Label ("Ein Wassertropfen allein versickert leicht unbemerkt – aber viele Tropfen werden zu einem mächtigen Strom!", Master.styleTextBigYellow);
				GUILayout.Label("",GUILayout.MinHeight(spaceAfterYellowText));
				GUILayout.Label ("Empfehle uns weiter, damit wir breiter aufgestellt sind", Master.styleTextDefaultTorquise);
			}
			else if (i == 13) {
				GUILayout.Label ("Unterstütze uns", Master.styleTextDefaultTorquise);
			}
			else if (i == 15) {
				GUILayout.Label ("Werde selbst aktiv bei TeamFreiheit", Master.styleTextDefaultTorquise);
			}
			
			OnGUI_GetActiveComponent(i);

			/*
			if (i == 9){
				GUILayout.BeginHorizontal();
				GUILayout.FlexibleSpace ();
				if (GUILayout.Button ("Tipps für Leserbrief",Master.styleButtonTorquise,GUILayout.Height(Master.guiElementHeightDefault))) {
					Application.LoadLevel("HintsForLetterScene");
				}
				GUILayout.FlexibleSpace ();
				GUILayout.EndHorizontal ();
			}
			*/


			GUILayout.Label("",GUILayout.MinHeight(spaceAfterGetActiveComponent));
		}

		OnGUI_ScrollViewEnd ();
	}

	void OnGUI_GetActiveComponent(int index){
		//BEFORE: GUILayout.BeginVertical (Master.styleBoxGreyWhite, GUILayout.ExpandHeight (true));
		GUILayout.BeginVertical (GUILayout.ExpandHeight (true));

		//TITLE
		GUILayout.Label (components[index].title, Master.styleTextHeaderPadding);

		//BEFORE: GUILayout.BeginVertical (Master.styleBoxWhiteGrey, GUILayout.ExpandHeight (true));
		GUILayout.BeginVertical (Master.styleBoxGreyLineOnTop, GUILayout.ExpandHeight (true));

		//TEXTURE
		GUILayout.BeginHorizontal ();
		GUILayout.FlexibleSpace ();
		if (components [index].texture != null) {
			GUILayout.Label(components[index].texture,Master.styleTextDefaultCenter,
			                GUILayout.Height(DisplayMetricsUtil.DpToPixel(130)), // GUILayout.Height is important because it resizes image to that height
			                GUILayout.Width(DisplayMetricsUtil.DpToPixel(240)));
			// This will require a rectanlge with 130x240 which is ALWAYS taken. Even if texture is smaller.
		}
		GUILayout.FlexibleSpace ();
		GUILayout.EndHorizontal ();

		//TEXT
		GUILayout.Label (components[index].text, Master.styleTextDefault);
		//URL
		GUILayout.BeginHorizontal();
		GUILayout.FlexibleSpace ();
		if (components [index].url != null) {
			if (GUILayout.Button (components [index].linkText,Master.styleButtonTorquise,GUILayout.Height(Master.guiElementHeightDefault))) {
				Application.OpenURL (components[index].url);
			}
		}
		GUILayout.FlexibleSpace ();
		GUILayout.EndHorizontal ();
		GUILayout.EndVertical ();

		GUILayout.EndVertical ();
	}
}
