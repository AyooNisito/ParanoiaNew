#pragma strict

var progress : float = 0;
var pos : Vector2 = new Vector2(20,40);
var size : Vector2 = new Vector2(60,20);
var progressBarEmpty : Texture2D;
var progressBarFull : Texture2D;
var count : float = 0; 

function OnGUI()
{
    GUI.DrawTexture(Rect(Screen.width - 500, 25, 512, 64), progressBarEmpty);
    GUI.DrawTexture(Rect(Screen.width - 500, 25, 512 * Mathf.Clamp01(progress), 64), progressBarFull);
} 

function Update()
{
	if(Flashlight.flashlightOn == true)
	{
	count++;
	progress = count * 0.00005;
	}
	else
	{
	count +=3;
	progress = count * 0.00005;
	}
	 
	
	
    
   // Camera.main.fieldOfView += .1;
	
}