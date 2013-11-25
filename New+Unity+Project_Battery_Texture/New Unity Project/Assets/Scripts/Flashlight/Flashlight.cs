using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour {
	
	public bool on = true;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKeyDown(KeyCode.F)){
        on = !on;
		audio.Play();}
    if(on){
        light.enabled = true;
		
		}
    else if(!on){
        light.enabled = false;
		
		}
	}
}
