﻿using UnityEngine;
using System.Collections;

public class WalkingSound : MonoBehaviour {
public AudioClip  walkStart;
	// Use this for initialization
void Update()
{

		if (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.S) ||Input.GetKeyDown (KeyCode.D))
		{
   		 audio.clip = walkStart;
    	 audio.Play();
 
			
	}

}
}