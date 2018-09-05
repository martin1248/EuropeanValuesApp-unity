using UnityEngine;
using System.Collections;

public class HOVComponent {
	public Texture2D history;
	public Texture2D value;
	public Texture2D value2;
	public Texture2D addtional;
	public Texture2D addtional2;
	public Vector2 valueLocation;
	public Color zoomLineColor;
	public string title;
	public string year;
	public string text;

	public HOVComponent(Texture2D history, Texture2D value, Texture2D value2, Texture2D addtional, Texture2D addtional2, Vector2 valueLocation, Color zoomLineColor){
		this.history = history;
		this.value = value;
		this.value2 = value2;
		this.addtional = addtional;
		this.addtional2 = addtional2;
		this.zoomLineColor = zoomLineColor;
		this.valueLocation = new Vector2(valueLocation.x*HOVContainer.scale1750To1024*HOVContainer.textureHistoryScale, valueLocation.y*HOVContainer.scale1750To1024*HOVContainer.textureHistoryScale);
	}
}
