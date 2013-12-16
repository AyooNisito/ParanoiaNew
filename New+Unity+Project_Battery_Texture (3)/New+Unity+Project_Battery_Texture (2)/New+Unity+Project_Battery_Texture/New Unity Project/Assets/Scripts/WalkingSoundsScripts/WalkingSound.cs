using UnityEngine;
using System.Collections;

public class WalkingSound : MonoBehaviour {
public AudioClip  walkStart;
	// Use this for initialization
void Update()
{
		//plays a walking sound upon keypress
		
		if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) 
  { 
			if (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.A) || Input.GetKeyDown (KeyCode.S) ||Input.GetKeyDown (KeyCode.D))
			{
   		 PlayClip(walkStart);
	}
	}

}
	bool PlayClip(AudioClip sound){
  if (audio.isPlaying) return false;
  audio.clip = sound;
  audio.Play();
  return true;
}
}