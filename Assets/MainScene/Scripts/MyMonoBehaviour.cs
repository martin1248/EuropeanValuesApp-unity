using UnityEngine;
using System.Collections;

public abstract class MyMonoBehaviour : MonoBehaviour{
	private Vector2 scrollPosition = Vector2.zero;

	void Awake () {
		Application.targetFrameRate = 15;
		QualitySettings.vSyncCount = 0; //0=No VSync, 1=Sync with every vSync, 2= Sync with every 2nd vSync
	}

	protected void OnGUI_Before(string titleText) {
		// Background
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), Master.backgroundTexture);

		// Title bar
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Master.getTitleBarHeight()), Master.titleBarTexture);

		// Main button
		if (GUI.Button (new Rect (Master.globalContentPadding, Master.getTitleBarHeight()/2 - Master.mainMenuButtonTexture.height/2, Master.titleBarButtonHeight, Master.titleBarButtonHeight), Master.mainMenuButtonTexture, "")) {
			Application.LoadLevel("MainScene");
		}
		
		// Title text
		Vector2 size = Master.styleTextTitleBar.CalcSize (new GUIContent (titleText));
		GUI.Label (new Rect (Master.globalContentPadding + Master.mainMenuButtonTexture.width + Master.globalContentPadding, Master.getTitleBarHeight() / 2 - size.y / 2, size.x, size.y), titleText, Master.styleTextTitleBar);
	}

	protected void OnGUI_ScrollViewStart () {
		Rect guiArea = new Rect (Master.globalContentPadding, Master.getTitleBarHeight(), Screen.width - Master.globalContentPadding*2, Screen.height - Master.getTitleBarHeight());
		GUILayout.BeginArea(guiArea);
		scrollPosition = GUILayout.BeginScrollView (scrollPosition, GUIStyle.none, GUIStyle.none);
		GUILayout.Label ("", GUILayout.Height (Master.globalContentPadding/2));
	}

	protected void Update()
	{
		// Hardware MENU button
		if (Input.GetKey(KeyCode.Menu))
		{
			Application.LoadLevel("MainScene");
		}
					
		// Hardware ESCAPE(Back) button
		if (Application.platform == RuntimePlatform.Android)
		{
			if (Input.GetKey(KeyCode.Escape))
			{
				if (this.GetType() == typeof(Main))
				{
					Application.Quit();
				} 
				else 
				{
					Application.LoadLevel("MainScene");
				}
			}
			if (Input.GetKey(KeyCode.Home))
			{
				Application.Quit();
			}
		}

		if(Input.touchCount > 0)
		{
			Touch touch = Input.touches[0];
			//
			// SCROLL
			//
			if (touch.phase == TouchPhase.Moved)
			{
				if(touch.deltaTime > 0) {
					float deltaTimeRelation_touch_frame = Time.deltaTime / touch.deltaTime;
					scrollPosition.x -= touch.deltaPosition.x*deltaTimeRelation_touch_frame;
					scrollPosition.y += touch.deltaPosition.y*deltaTimeRelation_touch_frame;
				}
			}
		}

		if (Input.GetKeyDown ("up")) {
			scrollPosition.y -= Screen.height/10;
		}
		
		if (Input.GetKeyDown ("down")) {
			scrollPosition.y += Screen.height/10;
		}

		if (Input.GetKeyDown ("left")) {
			scrollPosition.x -= Screen.width/10;
		}
		
		if (Input.GetKeyDown ("right")) {
			scrollPosition.x += Screen.width/10;
		}
		/*
		if (Input.GetKeyDown ("s")) {
			// Phone:   800x480 (DPI 250)
			// 7 Zoll:  560x350
			// 10 Zoll: 800x500
			Application.CaptureScreenshot("C:/Users/Public/Pictures/" + Time.time + ".png");
		}
		*/

		UpdateExtended ();
	}

	protected abstract void UpdateExtended ();

	protected void OnGUI_ScrollViewEnd (){
		GUILayout.Label ("", GUILayout.Height (Master.globalContentPadding/2));
		GUILayout.EndScrollView ();
		GUILayout.EndArea ();

		// White to Alpha blend for smooth scrolling at sharp borders
		int blendingHeight = DisplayMetricsUtil.DpToPixel (8);
		GUI.DrawTexture (new Rect (0, Master.getTitleBarHeight(), Screen.width, blendingHeight), Master.whiteToAlphaTexture);
		GUI.DrawTexture (new Rect (0, Screen.height - blendingHeight, Screen.width, blendingHeight), Master.alphaToWhiteTexture);
	}

	protected Texture2D ScaleTexture(Texture2D texture, float width) {
		float height = Mathf.RoundToInt ((width * texture.height) / texture.width);
		return ScaleTexture(texture,width,height);
	}

	protected Texture2D ScaleTextureByMax(Texture2D texture, float maxWidth, float maxHeight) {
		//Calculate new maxWidth assuming height is the bottleneck
		float newMaxWidth = Mathf.RoundToInt ((maxHeight * texture.width) / texture.height);
		if(newMaxWidth > maxWidth) {
			// Upps. wrong assumption. Definitely width is bottleneck
			newMaxWidth = maxWidth;
		}
		return ScaleTexture(texture,newMaxWidth);
	}

	protected Texture2D ScaleTexture(Texture2D texture, float width, float height) {
		Texture2D newTex = (Texture2D)Instantiate (texture);
		TextureScale.Bilinear (newTex, Mathf.RoundToInt (width), Mathf.RoundToInt (height));
		newTex.Compress (true);
		return newTex;
	}

	protected void resetScrollPosition(){
		scrollPosition = Vector2.zero;
	}

	protected float debugMemory() {
		float memoryTextures = -1;
		#if ENABLE_PROFILER
		Object[] textures = Resources.FindObjectsOfTypeAll(typeof(Texture));
		foreach(Texture t in textures) {
			memoryTextures += Profiler.GetRuntimeMemorySize(t);
			/*if((Profiler.GetRuntimeMemorySize(t) > 200* 1000)){
				Debug.Log(" " + t.name + "=" + Profiler.GetRuntimeMemorySize(t)/1000 + "KB");
			}*/

			if(t.name.Contains("test")){
				Debug.Log(" " + t.name + " " + Profiler.GetRuntimeMemorySize(t)/1000);
			}
		}
		memoryTextures = memoryTextures /1000/1000;
		//Debug.Log(" TOTAL " + memoryTextures + "MB");

		#endif
		return memoryTextures;
	}

}
