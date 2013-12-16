using UnityEngine;
using System.Collections;

public class RandomNoises : MonoBehaviour {
	
	public AudioClip  owl;
	public AudioClip  wolf;
	public AudioClip  growl;
	public AudioClip  cackle;
	public AudioClip  thunder;
	public Light light1;
	public Light light2;
	public float start;
	// Use this for initialization
	void Start () 
	{
		start = 21f;
	    Monster ();
		audio.clip = thunder;
        audio.Play();
		Lightning script = this.GetComponent<Lightning>();
		script.light = true;
	}
	
	// Update is called once per frame
	void Update () 
	{
	    int rand = Random.Range(0,5005);
		//Debug.Log (rand);
		switch (rand)
		{
		case 100:
		case 101:
		case 102:
		case 103:
		case 104:
		case 105:
		    {
			    audio.clip = owl;
                audio.Play();
			    break;
		    }
		    case 501:
		    case 502:
		    case 503:
		    {
			    audio.clip = wolf;
                audio.Play();
			 Monster ();
			break;
		    }
			case 1501:
		    case 1502:
		    case 1503:
		    {
			    audio.clip = growl;
                audio.Play();
			 Monster ();
			break;
		    }
			case 3501:
		    case 3502:
		    case 3503:
		    {
			    audio.clip = cackle;
                audio.Play();
			 Monster ();
			break;
		    }
		    case 5000:
			case 5001:
			case 5002:
		    {
			    audio.clip = thunder;
                audio.Play();
			 Monster ();
			Lightning script = this.GetComponent<Lightning>();
			script.light = true;
			break;
		    }
		}
	}
	void Monster()
	{
		GameObject player = GameObject.Find("First Person Controller");
		float dir = player.transform.eulerAngles.y;
		if (dir < 0f)
		{
			dir += 360f;
		}
		float xdist = 0f;
		float zdist = 0f;
		float point = 0f;
		if (dir <= 45 || dir >= 315)
		{
	    xdist = player.transform.position.x + start;
		zdist = player.transform.position.z + start;
		point = Mathf.Sqrt(Mathf.Pow (xdist,2) + Mathf.Pow (zdist,2));
		}
		else if (dir <= 225 || dir >= 135)
		{
	    xdist = player.transform.position.x - start;
		zdist = player.transform.position.z - start;
		point = Mathf.Sqrt(Mathf.Pow (xdist,2) + Mathf.Pow (zdist,2));
		}
		else if (dir <= 135 || dir >= 45)
		{
	    xdist = player.transform.position.x + start;
		zdist = player.transform.position.z + start;
		point = Mathf.Sqrt(Mathf.Pow (xdist,2) + Mathf.Pow (zdist,2));
		}
		else if (dir <= 315 || dir >= 225)
		{
	    xdist = player.transform.position.x + start;
		zdist = player.transform.position.z + start;
		point = Mathf.Sqrt(Mathf.Pow (xdist,2) + Mathf.Pow (zdist,2));
		}
//		else if (dir <= 180)
//		{
//	    xdist = player.transform.position.x - start;
//		zdist = player.transform.position.z - start;
//		point = Mathf.Sqrt(Mathf.Pow (xdist,2) + Mathf.Pow (zdist,2));
//		}
//		else if (dir <=270)
//		{
//		xdist = player.transform.position.x - start;
//		zdist = player.transform.position.z - start;
//		point = Mathf.Sqrt(Mathf.Pow (xdist,2) + Mathf.Pow (zdist,2));
//		}
//		else
//		{
//	    xdist = player.transform.position.x - start;
//		zdist = player.transform.position.z + start;
//		point = Mathf.Sqrt(Mathf.Pow (xdist,2) + Mathf.Pow (zdist,2));
//		}
		GameObject mon = Resources.Load("monster") as GameObject;
		Instantiate(mon, new Vector3(xdist, 0.5f, zdist), Quaternion.identity);
//		if (start >= 20f)
//		{
//			start = 17f;
//		}
	}
}
