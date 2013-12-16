#pragma strict


static var standingNearFire : boolean = false;

function Awake()
{
standingNearFire = false; 
}

function Start () {

}

function Update () {

}
// checks to see if you are standing near the campfire. 
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