using UnityEngine;
using System.Collections;

public class WalkingStop : MonoBehaviour {
public AudioClip  walkStop;
	// Use this for initialization
void Update()
{
		//plays a walking sound upon keypress.
if (Input.GetKeyUp (KeyCode.W) || Input.GetKeyUp (KeyCode.A) || Input.GetKeyUp (KeyCode.S) ||Input.GetKeyUp (KeyCode.D))
{
    audio.clip = walkStop;
    audio.Stop();
 
}
}
}
