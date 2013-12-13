using UnityEngine;
using System.Collections;

public class WinText : MonoBehaviour {
	public GUIText Win;
	// Use this for initialization
	void Start () 
	{
	Screen.showCursor = true; 
	Win.text = "You Win";
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	void OnGUI()
	{
		if(GUI.Button(new Rect(Screen.width/2-80,Screen.height/2+120,160,40), "Main Menu")) 
		{
			Application.LoadLevel("Main Menu");
		}	
	}
}
