#pragma strict

var batPickedUp : boolean = false;
 
function OnTriggerEnter()
{
   if(!batPickedUp)
   {
       flashlightMeter.count = 0;
       flashlightMeter.progressTwo = 512 * Mathf.Clamp01(flashlightMeter.progress);
       flashlightMeter.progress =0;
       renderer.enabled = false;
       batPickedUp = true;
   }
}
 
