using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class numbersHold : MonoBehaviour {
	static List<GameObject> papers = new List<GameObject>();
	public string numString ="";
	public string numStringTwo ="";
	public string numStringThree ="";
	public string numStringFour ="";
	void Start ()
	{
	papers.Add(GameObject.Find("Paper"));
	papers.Add(GameObject.Find("Paper1"));
	papers.Add(GameObject.Find("Paper2"));
	papers.Add(GameObject.Find("Paper3"));	
	}
	
	void OnControllerColliderHit(ControllerColliderHit hit)
	{
		if(papers.Contains(hit.gameObject))
		{
		if(Input.GetKeyDown("e"))
			{
		Destroy (hit.gameObject);
			}	
		}
	}
	
	void OnGUI()
	{	
	if(GameObject.Find("Paper") == null)
		{
		GUI.Box (new Rect(0,0,35,35),numString);	
		}
		else
		{
		GUI.Box (new Rect(0,0,35,35),"?");	
		}
		if(GameObject.Find("Paper1") == null)
		{
		GUI.Box (new Rect(35,0,35,35),numStringTwo);
		}
		else
		{
		GUI.Box (new Rect(35,0,35,35),"?");	
		}
		if(GameObject.Find("Paper2") == null)
		{
		GUI.Box (new Rect(70,0,35,35),numStringThree);
		}
		else
		{
		GUI.Box (new Rect(70,0,35,35),"?");	
		}
		if(GameObject.Find("Paper3") == null)
		{
		GUI.Box (new Rect(105,0,35,35),numStringFour);
		}
		else
		{
		GUI.Box (new Rect(105,0,35,35),"?");	
		}
	}
	
	void Update()
	{
		
		this.numString = MakeKeypad.correctCombo.Substring (0,1);
		this.numStringTwo = MakeKeypad.correctCombo.Substring (1,1);
		this.numStringThree = MakeKeypad.correctCombo.Substring (2,1);
		this.numStringFour = MakeKeypad.correctCombo.Substring (3,1);
	}
		

}
