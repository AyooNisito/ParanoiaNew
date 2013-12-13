using UnityEngine;
using System.Collections;

public class KeyPickUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name.Equals("First Person Controller") && Input.GetKeyDown(KeyCode.E))
		{
		//	GameObject key = GameObject.Find("Key_B_02");
		//	key.rigidbody.AddForce(0,10,0);
		//	key.transform.Rotate(-90,0,0);
			Application.LoadLevel("WinScene");
		}
	}
}
