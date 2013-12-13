#pragma strict

var batPickedUp : boolean = false;
var pickUpSound: AudioClip;
function OnTriggerEnter(other : Collider)
{
	
   if(!batPickedUp)
   {
   	  audio.PlayOneShot(pickUpSound);
   	  flashlightMeter.count = 0;
   	  batPickedUp = true;
	 yield WaitForSeconds (.5);
	 Destroy(gameObject);
       
   }
}
 
