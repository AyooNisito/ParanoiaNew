#pragma strict

var batPickedUp : boolean = false;
var pickUpSound: AudioClip;
function OnTriggerEnter(other : Collider)
{
	
   if(!batPickedUp)
   {
   //resets the flashlight meter when a battery is picked up and removes the battery form play. 
   	  audio.PlayOneShot(pickUpSound);
   	  flashlightMeter.count = 0;
   	  batPickedUp = true;
	 yield WaitForSeconds (.5);
	 Destroy(gameObject);
       
   }
}
 
