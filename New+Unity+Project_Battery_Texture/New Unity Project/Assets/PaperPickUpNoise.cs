using UnityEngine;
using System.Collections;

public class PaperPickUpNoise : MonoBehaviour {
	public AudioClip pickUpSound;
	bool soundPlayed1 = false; 
	bool soundPlayed2 = false; 
	bool soundPlayed3 = false; 
	bool soundPlayed4 = false; 
	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
	if(GameObject.Find("Paper") == null && soundPlayed1 == false)
		{
		soundPlayed1 = true; 
		audio.PlayOneShot(pickUpSound);	
		}
	if(GameObject.Find("Paper1") == null && soundPlayed2 == false)
		{
		soundPlayed2 = true; 
		audio.PlayOneShot(pickUpSound);	
		}
	if(GameObject.Find("Paper2") == null && soundPlayed3 == false)
		{
		soundPlayed3 = true; 
		audio.PlayOneShot(pickUpSound);	
		}
	if(GameObject.Find("Paper3") == null && soundPlayed4 == false)
		{
		soundPlayed4 = true; 
		audio.PlayOneShot(pickUpSound);	
		}
	}
}
