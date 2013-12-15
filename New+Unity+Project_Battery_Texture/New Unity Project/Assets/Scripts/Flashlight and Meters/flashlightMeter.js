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
//draws the flashlight meter texture.
	GUI.DrawTexture(Rect(Screen.width - 500, 75, 512, 40), progressBarFull);
	
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
// resets the counter upon starting a new game. 
function Awake()
{
count = 0;
}

function Update()
{
if(flashlightOn)
{
	count++;
	progress = count * 0.00025;
}
}
//battery meter stops depleting. 
function batteryConsumptionStop()
{
GUI.DrawTexture(Rect(Screen.width - 500, 75, progressTwo, 40), progressBarEmpty);
}

function batteryConsumptionStart()
{
GUI.DrawTexture(Rect(Screen.width - 500, 75,  progressTwo, 40), progressBarEmpty);
}
