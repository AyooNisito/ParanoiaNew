using UnityEngine;
using System.Collections;

public class NumbersBar : MonoBehaviour {
	
	public string numString ="";
	public string numStringTwo ="";
	public string numStringThree ="";
	public string numStringFour ="";
	// Use this for initialization
	void Start () 
	{
	
	int numOne = 0;
	int numTwo = 0;
	int numThree = 0;
	int numFour = 0;
	
	numOne = Random.Range (0,9);
	numTwo = Random.Range (0,9);
	numThree = Random.Range (0,9);
	numFour = Random.Range (0,9);
	
	numString = numOne.ToString();
	numStringTwo = numTwo.ToString();
	numStringThree = numThree.ToString();
	numStringFour = numFour.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnGUI()
	{
	GUI.Box (new Rect(0,0,35,35),"?");
	GUI.Box (new Rect(35,0,35,35),"?");
	GUI.Box (new Rect(70,0,35,35),"?");
	GUI.Box (new Rect(105,0,35,35),"?");
		
	if(PickUpNum.destroyed)
		{
		GUI.Box (new Rect(0,0,35,35),numString);	
		}
//	GUI.Box (new Rect(0,0,35,35),numString);
//	GUI.Box (new Rect(35,0,35,35),numStringTwo);	
//	GUI.Box (new Rect(70,0,35,35),numStringThree);
//	GUI.Box (new Rect(105,0,35,35),numStringFour);	
	}
}
