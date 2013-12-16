using UnityEngine;
using System.Collections;

public class Lightning : MonoBehaviour {
	public AudioClip  thunder;
	public Light light1;
	public Light light2;
	float time;
		float count;
		bool on ;
		float lighton;
		float timelight;
	public bool light;
	// Use this for initialization
	void Start () 
	{
	    time = 2f;
		count = 0f;
		light = false;
		on = true;
		timelight = 0f;
		lighton = Random.Range (0,30) / 100f;
	}
	
	// Update is called once per frame
	void Update () 
	{	
			if (on && light)
			{
				light1.intensity = 8f;
				light2.intensity = 8f;
			timelight += Time.deltaTime;
			count += Time.deltaTime;
			}
			else if (!on && light)
			{
				light1.intensity = 0f;
				light2.intensity = 0f;
			timelight += Time.deltaTime;
			count += Time.deltaTime;
			}
			//Debug.Log(light1.intensity);
			if (timelight >= lighton)
			{
				on = !on;
				Debug.Log ("lightning " + on);
				timelight = 0f;
				lighton = Random.Range (0,30) / 100f;
				//lighton = Random.Range (0,100) / 100f;
			}
//		if (light)
//		{
//		    light1.intensity = 8f;
//			light2.intensity = 8f;
//			count += Time.deltaTime;
//		}
			if (count > time && light)
			{
			time = 5f;
			count = 0f;
			light = false;
			on = true;
		    timelight = 0f;
		    lighton = Random.Range (0,30) / 100f;
			light1.intensity = 0f;
			light2.intensity = 0f;
			Debug.Log ("lightning done");
			}
	}
}
