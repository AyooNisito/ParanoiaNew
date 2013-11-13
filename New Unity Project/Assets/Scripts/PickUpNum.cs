using UnityEngine;
using System.Collections;

public class PickUpNum : MonoBehaviour {
public static bool destroyed = false;
	// Use this for initialization
	
	void OnControllerColliderHit(ControllerColliderHit hit)
	{
		if(hit.gameObject.name == "Paper")
		{
		if(Input.GetKeyDown("e"))
		{
			
		Destroy (hit.gameObject);
		destroyed = true; 
	}	
		}
	}
		
}
