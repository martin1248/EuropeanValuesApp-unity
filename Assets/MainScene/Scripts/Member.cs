using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Member
{
    // Fields for config
	public static string EVERYONE = "everyone";
    public static bool isMember = false;
	public static bool checkFailed = false;
	public static string errorMessage = "";

    // Fields from online member check
    public static string urlToMemberCheck = "http://martin.huch.public.linz.at/teamfreiheit/member.php?memberid=";
    public static bool connectionCheckCompleted = true;
    public static bool internetConnectionExists = true;
	public static bool isEveryone = false;

	private static void SaveLocal(bool _isMember, bool _checkFailed, string _errorMessage)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/member.dat", FileMode.OpenOrCreate);

        PersistedData data = new PersistedData();
        data.isMember = _isMember;
		data.checkFailed = _checkFailed;
		data.errorMessage = _errorMessage;
        bf.Serialize(file, data);
        file.Close();
    }

    public static void LoadLocal()
    {
        if (File.Exists(Application.persistentDataPath + "/member.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/member.dat", FileMode.Open);
            PersistedData data = (PersistedData)bf.Deserialize(file);
            file.Close();

            isMember = data.isMember;
			checkFailed = data.checkFailed;
			errorMessage = data.errorMessage;
        } else
        {
            SaveLocal(false, false, "");
            isMember = false;
        }
    }

	public static void DeleteMember(){
		SaveLocal(false, false, "");
		isMember = false;
	}

    [Serializable]
    class PersistedData
    {
        public bool isMember;
		public bool checkFailed;
		public string errorMessage;
    }

    public static IEnumerator checkMember(string memberId)
    {
        Debug.Log("Started member check for: " + memberId);
        connectionCheckCompleted = false;
        internetConnectionExists = false;
        bool _isMember = false;
		bool _checkFailed = false;
		string _errorMessage = "";

		if(memberId == EVERYONE)
		{
			isEveryone = true;
		} else
		{
			isEveryone = false;
		}

        // Test internet connection - Only one of following must be reachable
        WWW wwwGoogle = new WWW("http://www.google.com");
        yield return wwwGoogle;

        //WWW wwwApple = new WWW("http://www.apple.com");
        //yield return wwwApple;

        //if ((wwwGoogle.error == "" || wwwGoogle.error == null) || (wwwApple.error == "" || wwwApple.error == null))
        if (wwwGoogle.error == "" || wwwGoogle.error == null)
        {
            //SUCCESS - Internet connection exists
            internetConnectionExists = true;
        }
        else
        {
            //FAILURE - Internet connection does not exist
            internetConnectionExists = false;
            _isMember = false;
        }


        if (internetConnectionExists)
        {
            // Look for valid members
            WWW wwwMemberCheck = new WWW(urlToMemberCheck + memberId);
            yield return wwwMemberCheck;

            if (wwwMemberCheck.error == "" || wwwMemberCheck.error == null)
            {

                // Success 
                if (wwwMemberCheck.text.ToUpper().Contains("DENIED"))
                {
                    _isMember = false;
                }
                else if (wwwMemberCheck.text.ToUpper().Contains("ACCEPTED"))
                {
                    _isMember = true;
                } else
                {
                    // In this case we (1) reached the member page and it (2) returned a page 
                    // but (3) it does not contain expected string DENIED or ACCEPTED

                    // Possible resons:
                    // (a) buggy server code - developers fault
                    //         Lucky user - we let him get the App without confirming that he has a valid memberID
					_isMember = false;

					_checkFailed = true;
					_errorMessage = "Der App Server hat eine unerwartete Antwort gesendet. " +
						"Aktivierung der App ist leider nicht möglich. Wir bitten um Entschuldigung. " +
						"Kontaktieren Sie TeamFreiheit für die Behebung des Problems.";
                }
				Debug.Log("Member check: Response of server was: " + wwwMemberCheck.text);
            }
            else
            {
                // Failure                
                //(1) We are connected to the internet 
                //(2) but do not reach your site
				_isMember = false;
				_checkFailed = true;

                //(a) The only scenario would be that the host of the website provider is down
                if (wwwMemberCheck.error.ToLower().Contains("could not resolve host"))
                {
					_errorMessage = "Der App Server ist momentan nicht erreichbar. " +
						"Bitte versuchen Sie es später nocheinmal. " +
						"Falls dieses Problem weiterhin besteht, dann kontaktieren Sie TeamFreiheit";
                } else if (wwwMemberCheck.error.ToLower().Contains("403")) //forbidden
                {
					_errorMessage = "Der App Server ist nicht erreichbar, weil die Verbindung zum App Server nicht erlaubt wurde. " +
						"Das ist der Fall, wenn Sie sich hinter einer Firewall oder in einem geschützen Firmennetzwerk befinden. " +
						"Verbinden Sie sich zum Internet aus einem Netzwerk ohne Firewall und versuchen Sie es dann nochmals.";
                }
                else
                {
					_errorMessage = "Der App Server ist aus einem unerwarteten Grund nicht erreichbar und die App konnte somit nicht aktiviert werden. " +
						"Kontaktieren Sie TeamFreiheit um Unterstützung zu bekommen und geben Sie dabei bitte folgenden Fehler an: " + wwwMemberCheck.error;
                }

				Debug.Log("Member check: error message from WWW is: " + wwwMemberCheck.error);
            }
        }

        connectionCheckCompleted = true;

		// SPECIAL CODE: In case of connection problems then this special code will activate app ignoring the problem
		if((memberId == "teamfreiheit" && _checkFailed) || (memberId == "teamfreiheit" && checkFailed)) {
			internetConnectionExists = true;
			_checkFailed = false;
			_isMember = true;
		}

		// MASTER CODE: This code always activates the app. (Only initial internet connection is necessary)
		if(memberId == "teamfreiheitteamfreiheit") {
			internetConnectionExists = true;
			_checkFailed = false;
			_isMember = true;
		}

        SaveLocal(_isMember, _checkFailed, _errorMessage);

        LoadLocal();

        Debug.Log("Member check: Internet connection exists: " + internetConnectionExists);
		Debug.Log("Member check: is Member? : " + _isMember);
		Debug.Log("Member check: Did check fail : " + _checkFailed);
		Debug.Log("Member check: error message in German is: " + _errorMessage);
    }

}
