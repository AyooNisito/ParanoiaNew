#pragma strict


public static var  fireLit : boolean = false; 
var innerFlame : GameObject;
var outerFlame : GameObject;
var fireLight : GameObject;
public var fireCrackle : AudioClip;

function Awake()
{
fireLit = false; 
}
function Start () 
{

}

function Update () 
{

}

function OnTriggerStay(other : Collider)
{
		if(!fireLit)
	{
	//creates the particle effect of the flame. 
		if(Input.GetKeyDown("e"))
		{
		innerFlame = GameObject.Find("InnerFlame");
		outerFlame = GameObject.Find("OuterFlame");
		fireLight = GameObject.Find("FireLight");
		audio.loop = true;
		audio.PlayOneShot(fireCrackle);
		
		innerFlame.particleSystem.Play();
		outerFlame.particleSystem.Play();
		fireLight.light.enabled = true;
				
		fireLit = true;
		Destroy(GetComponent(Campfire));
		
		}	
	}
}