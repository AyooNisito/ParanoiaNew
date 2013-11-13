#pragma strict
 static var flashlightOn:boolean = false; 
 var progressTwo: float = 0; 
 var lightMeterFull: int = 512;
function Start()
{
flashlightOn = true;
Screen.lockCursor = true;
}

function Update () 
{
//checks to see how full the flashlight meter is
	progressTwo = flashlightMeter.progressTwo;

//if your flashlight meter is depleted it will not let you turn on the flashlight	
if (progressTwo == lightMeterFull)
{
light.enabled = false;
flashlightOn = false; 
}
else
{
//checks for key input first press turns on the flashlight second press turns it off
if(Input.GetKeyDown("f"))
{
if(light.enabled == true)
{
light.enabled = false;
flashlightOn = false; 
}
else
{
flashlightOn = true; 
light.enabled = true;
}
}

}	


}