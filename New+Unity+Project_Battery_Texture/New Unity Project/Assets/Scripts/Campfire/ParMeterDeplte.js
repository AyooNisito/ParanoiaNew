#pragma strict


static var standingNearFire : boolean = false;; 


function Start () {

}

function Update () {

}

function OnTriggerStay(other:Collider)
{
if(Campfire.fireLit)
{
standingNearFire = true;
}

}
function OnTriggerExit(other:Collider)
{
standingNearFire = false;
}