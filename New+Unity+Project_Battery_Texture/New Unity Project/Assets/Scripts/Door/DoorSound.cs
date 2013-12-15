using UnityEngine;
using System.Collections;

public class DoorSound : MonoBehaviour {
	public AudioClip doorOpening;
	//moves the door and plays the door opening sound. 
	 void OnTriggerStay(Collider other) 
	{
		if(Input.GetKeyDown("e"))
		{
			Debug.Log ("You hit e");
		GameObject.Find("Door").rigidbody.AddForce(17,0,0);
		audio.PlayOneShot(doorOpening);
				GameObject.Destroy(gameObject.GetComponent("DoorSound"));
		}
    }
}
