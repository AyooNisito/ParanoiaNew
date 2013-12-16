using UnityEngine;
using System.Collections;

public class CampfireCollision : MonoBehaviour 
{
		public bool isLit = false;
		GameObject innerFlame;
		GameObject outerFlame;
		GameObject fireLight;
	
	void OnControllerColliderHit(ControllerColliderHit hit)
{
		Debug.Log("hit");
		if(!isLit)
	{
		if(Input.GetKeyDown("e"))
		{
		innerFlame = GameObject.Find("InnerFlame");
		outerFlame = GameObject.Find("OuterFlame");
		fireLight = GameObject.Find("FireLight");
				

		innerFlame.particleSystem.Play();
		outerFlame.particleSystem.Play();
		fireLight.light.enabled = true;
				
		isLit = true;
		
		}	
	}
}
		
}

