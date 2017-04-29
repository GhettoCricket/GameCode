using UnityEngine;
using System.Collections;

public class Life : MonoBehaviour {
	
	public static int lives;
	// Use this for initialization
	void Start () {
	
	}
	public GUIStyle LifeStyle;
	// Update is called once per frame
	void OnGUI () {
	GUI.Label(new Rect(25.0f, 100.0f, 128.0f, 32.0f),lives.ToString(),LifeStyle);
	}
	
}
