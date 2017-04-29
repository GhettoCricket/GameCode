using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {
	
	public static int Score;
	// Use this for initialization
	void Start () {
	
	}
	public GUIStyle ScoreStyle;
	// Update is called once per frame
	void OnGUI () {
		
	GUI.Label(new Rect(25.0f, 25.0f, 128.0f, 32.0f),Score.ToString(),ScoreStyle);
	
	}
}
