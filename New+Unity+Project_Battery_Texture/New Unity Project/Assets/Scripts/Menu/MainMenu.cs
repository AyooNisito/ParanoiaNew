using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	
	void Start () 
	{
	Screen.showCursor = true;	
	
	}

	
	void OnGUI () 
	{
		// Make a background box
		//GUI.Box(new Rect(10,10,100,90), "Loader Menu");

		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		
		if(GUI.Button(new Rect(Screen.width/2-80,Screen.height/2,160,40), "Play Game")) 
		{
			
			Application.LoadLevel("scenetest");
		}

		// Make the second button.
		
		if(GUI.Button(new Rect(Screen.width/2-80,Screen.height/2+60,160,40), "Instructions")) 
		{
			
			Application.LoadLevel("Instructions");
			
		}
		
		if(GUI.Button(new Rect(Screen.width/2-80,Screen.height/2+120,160,40), "Credits")) 
		{
			
			Application.LoadLevel("Credits");
			
		}
		
		if(GUI.Button(new Rect(Screen.width/2-80,Screen.height/2+180,160,40), "Exit")) 
		{
			
			Application.Quit();
		}
		
		
	}
}

