using UnityEngine;
using System.Collections;

public class monsterMoving : MonoBehaviour {
	
	public GameObject player;
	public float timeStart;
	public float timeLeft;
	public float direction;
	public float moveSpeed;
	public float angleX;
	public float angleZ;
	// Use this for initialization
	void Start () 
	{
	    player = GameObject.Find("First Person Controller");
		timeLeft = 1.5f;
		timeStart = 0f;
		moveSpeed = 15f;
		direction = player.transform.eulerAngles.y + 270f;
		this.transform.rotation = Quaternion.Euler(0f,direction,0f);
		if (direction >= 180f)
		{
			angleZ = -(270f - direction);
		}
		else
		{
			angleZ = -(90f - direction);
		}
		if (direction >= 270f)
		{
			angleX = -(360f - direction);
		}
		else if (direction <= 90f)
		{
			angleX = -(0f - direction);
		}
		else
		{
			angleZ = -(180f - direction);
		}
		angleX = angleX / 90f;
		angleZ = angleZ / 90f;
		Debug.Log(this.transform.position);
	}
	
	// Update is called once per frame
	void Update () 
	{
	    if (timeStart >= timeLeft)
		{
			Destroy(this.gameObject);
			//Debug.Log("Destroyed " + timeStart);
		}
		timeStart += Time.deltaTime;
		float newX = this.transform.position.x + Time.deltaTime * moveSpeed * angleX;
		float newZ = this.transform.position.z + Time.deltaTime * moveSpeed * angleZ;
//		newX *= angleX;
//		newZ *= angleZ;
		this.transform.position = new Vector3(newX,0.5f,newZ);
		//Debug.Log(this.transform.position);
	}
}
