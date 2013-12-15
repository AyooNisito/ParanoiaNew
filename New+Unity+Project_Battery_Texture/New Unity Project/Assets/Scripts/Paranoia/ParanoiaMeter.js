#pragma strict

var progress : float = 0;
var pos : Vector2 = new Vector2(20,40);
var size : Vector2 = new Vector2(60,20);
var progressBarEmpty : Texture2D;
var progressBarFull : Texture2D;
static var count : float = 0; 
public var heartBeat : AudioClip;
var soundPlay :boolean = false; 

function OnGUI()
{
    GUI.DrawTexture(Rect(Screen.width - 500, 25, 512, 40), progressBarEmpty);
    GUI.DrawTexture(Rect(Screen.width - 500, 25, 512 * Mathf.Clamp01(progress), 40), progressBarFull);
} 

function Awake()
{
count = 0;
}

function Update()
{
//sound playes when the meter gets about 75% full
  if(count > 1500 && !soundPlay)
  {
  soundPlay = true;
  audio.PlayOneShot(heartBeat);
  }
  
  if(soundPlay && count < 1500)
  {
  soundPlay = false;
  audio.Stop();
  }
  //lose game when meters full
  if(count > 2000)
  {
 Application.LoadLevel("LoseScene");
  }
 	//if the flashlights on and your not standing near the lit campfire it increases paranoia by one. 
	if(Flashlight.flashlightOn == true)
	{
		if(!ParMeterDeplte.standingNearFire)
			{
			count++;
			progress = count * 0.0005;
			}
		else
			{
			if(count > 0)
				{
					count -=1;
					progress = count * 0.0005;
				}
			}
	}
	//if the flashlights off and your not standing near the lit campfire it increases paranoia by three. 
	else
	{
		if(!ParMeterDeplte.standingNearFire)
		{
			count +=3;
			progress = count * 0.0005;
		}
		else
		{
			if(count > 0)
			{
				count -=3;
				progress = count * 0.0005;
			}
		}
	}
}