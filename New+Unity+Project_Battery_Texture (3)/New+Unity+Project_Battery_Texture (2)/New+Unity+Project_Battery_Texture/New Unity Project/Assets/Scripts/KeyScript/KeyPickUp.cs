using UnityEngine;
using System.Collections;

public class KeyPickUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//Picks up the key and wins the game. 
	void OnTriggerStay(Collider other)
	{
		if(other.gameObject.name.Equals("First Person Controller") && Input.GetKeyDown(KeyCode.E))
		{
			Application.LoadLevel("WinScene");
		}
	}
}
