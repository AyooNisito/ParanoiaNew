#pragma strict

static var progress : float = 0;
var pos : Vector2 = new Vector2(20,40);
var size : Vector2 = new Vector2(60,20);
var progressBarEmpty : Texture2D;
var progressBarFull : Texture2D;
var flashlightOn : boolean; 
static var progressTwo: float = 0; 
static var count:float = 0;


function OnGUI()
{
//checks to see if the flashlight is on
	flashlightOn = Flashlight.flashlightOn;
	
	GUI.DrawTexture(Rect(Screen.width - 500, 100, 512, 64), progressBarFull);
	
	progressTwo = 512 * Mathf.Clamp01(progress);
	
	if(flashlightOn)
	{
    batteryConsumptionStart();
	}
	else
	{
	batteryConsumptionStop();
	}	
} 

function Update()
{
if(flashlightOn)
{
	count++;
	progress = count * 0.0005;
}
}

function batteryConsumptionStop()
{
GUI.DrawTexture(Rect(Screen.width - 500, 100, progressTwo, 64), progressBarEmpty);
}

function batteryConsumptionStart()
{
GUI.DrawTexture(Rect(Screen.width - 500, 100,  progressTwo, 64), progressBarEmpty);
}
