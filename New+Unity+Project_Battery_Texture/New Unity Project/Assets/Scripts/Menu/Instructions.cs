using UnityEngine;
using System.Collections;

public class Instructions : MonoBehaviour {
	
	public GUIText controls;
	public GUIText instructions;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() 
	{
		instructions.text = "You are locked in a park and need the key in the shed to escape.\nFind all four numbers to find the combination to the shed. Open \nthe " +
			"shed and take the key to win. Do not max your paranoia.  \nParanoia increases over time and increases " +
			"faster in darkness.  \nFind and light campfires to reduce your paranoia. There are \nbatteries " +
			"scattered around the map to refill your flashlight.";
		
		controls.text = "Move Keys: WASD \nFlashlight Toggle: F \nInteract: E \nJump: Space";
		
		if(GUI.Button(new Rect(Screen.width/2-80,Screen.height/2+120,160,40), "Back")) 
		{
			Application.LoadLevel("Main Menu");
		}
		
		
	}
}
