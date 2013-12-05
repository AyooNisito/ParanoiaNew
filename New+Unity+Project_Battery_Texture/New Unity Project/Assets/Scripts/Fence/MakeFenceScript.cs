using UnityEngine;
using System.Collections;

public class MakeFenceScript : MonoBehaviour {
	
	public Transform fence;
	// Use this for initialization
	void Start () 
	{
	    //top wall
		for (int i = -360; i < (440); i = i + 6)
		{
			Instantiate(fence, new Vector3(i, 0, 350), Quaternion.identity);
		}
		//right wall
		fence.rotation = Quaternion.Euler (0f,90.0f,0f);
		for (int i = -350; i < (350); i = i + 6)
		{
			Instantiate(fence, new Vector3(440, 0, i), fence.rotation);
		}
		//bottom
		fence.rotation = Quaternion.Euler (0f,180.0f,0f);
		for (int i = -360; i < (440); i = i + 6)
		{
			Instantiate(fence, new Vector3(i, 0, -350), Quaternion.identity);
		}
		//left
		fence.rotation = Quaternion.Euler (0f,270.0f,0f);
		for (int i = -350; i < (350); i = i + 6)
		{
			Instantiate(fence, new Vector3(-360, 0, i), fence.rotation);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}