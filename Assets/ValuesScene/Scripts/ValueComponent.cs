using UnityEngine;
using System.Collections;

public class ValueComponent {
	public Texture2D origValueTexture;
	public Texture2D valueTexture;
	public string valueTitle;
	public string yearText;
	public string value1Text;
	public string value2Text;
	
	public ValueComponent(Texture2D origValueTexture, Texture2D valueTexture, string valueTitle, string yearText, string value1Text, string value2Text){
		this.origValueTexture = origValueTexture;
		this.valueTexture = valueTexture;
		this.valueTitle = valueTitle;
		this.yearText = yearText;
		this.value1Text = value1Text;
		this.value2Text = value2Text;
	}
}
