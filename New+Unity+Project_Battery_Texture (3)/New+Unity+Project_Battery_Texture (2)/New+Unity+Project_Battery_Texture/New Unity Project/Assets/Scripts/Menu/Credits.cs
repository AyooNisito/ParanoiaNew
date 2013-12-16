using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() 
	{
	
		
			if(GUI.Button(new Rect(Screen.width/2-80,Screen.height/2+120,160,40), "Back")) 
			{
				
				Application.LoadLevel("Main Menu");
				
			}
		
		
		
		
	}
}
