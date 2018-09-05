using UnityEngine;
using System.Collections;

public class GetActiveComponent {
	public string title;
	public string text;
	public string linkText;
	public string url;
	public Texture2D texture;

	public GetActiveComponent(string title, Texture2D texture, string linkText, string url, string text){
		this.title = title;
		this.text = text;
		this.linkText = linkText;
		this.url = url;
		this.texture = texture;
	}
}
