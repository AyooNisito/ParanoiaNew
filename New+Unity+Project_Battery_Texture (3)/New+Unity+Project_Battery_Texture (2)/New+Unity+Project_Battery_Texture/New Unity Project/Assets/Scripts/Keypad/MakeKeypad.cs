using UnityEngine;
using System.Collections;

public class MakeKeypad : MonoBehaviour {

	
	public AudioClip doorOpeningSound;
	private int halfScreenW;
	private int GUIBoxWH;
	private int blockSquare;
	public static bool keypadUp = false;
	public int tries = 3;
	public string combo = "";
	private string updater;
	public int numberLimit = 4;
	public static string correctCombo = "";
	public bool doorOpen = false;
	
	void Start()
	{
		halfScreenW = Screen.width/2;
	    GUIBoxWH = (int)(Screen.height/1.5);
	    blockSquare = GUIBoxWH/5;
		
		getCorrectCombo (numberLimit);
	}
	
	void getCorrectCombo(int num)
	{
		correctCombo = "";
		for (int i = 0; i < num; i++)
		{
			int number = 0;
			bool check = true;
			while (check)
			{
				check = false;
				number = (int)(Random.Range (0,9));
			    for (int j = 0; j < correctCombo.Length; j++)
			    {
					int checker = int.Parse(correctCombo.Substring (j,1));
				    if (checker == number)
				    {
				    	check = true;
				    }
			    }
			}
			correctCombo = correctCombo + number;
		}
		Debug.Log(correctCombo);
	}
	
	void Update()
	{
		 if (Input.GetKeyDown (KeyCode.UpArrow) == true)
		{
			keypadUp = false;
			Screen.showCursor = false; 
		}
		else if (Input.GetKeyDown (KeyCode.LeftArrow) == true)
		{
			keypadUp = false;
			Screen.showCursor = false;
		}
		else if (Input.GetKeyDown (KeyCode.RightArrow) == true)
		{
			keypadUp = false;
			Screen.showCursor = false;
		}
		else if (Input.GetKeyDown (KeyCode.DownArrow) == true)
		{
			keypadUp = false;
			Screen.showCursor = false;
		}
		else if (Input.GetKeyDown (KeyCode.W) == true)
		{
			keypadUp = false;
			Screen.showCursor = false;
		}
		else if (Input.GetKeyDown (KeyCode.A) == true)
		{
			keypadUp = false;
			Screen.showCursor = false;
		}
		else if (Input.GetKeyDown (KeyCode.S) == true)
		{
			keypadUp = false;
			Screen.showCursor = false;
		}
		else if (Input.GetKeyDown (KeyCode.D) == true)
		{
			keypadUp = false;
			Screen.showCursor = false;
		}
	}
	
	void OnGUI()
	{
		if (keypadUp == true)
		{
		
		GUI.BeginGroup (new Rect((halfScreenW - GUIBoxWH/2),
			(Screen.height/2 - GUIBoxWH/2), 
			GUIBoxWH, GUIBoxWH));
	    Rect position = new Rect(0,0,GUIBoxWH,GUIBoxWH);
	    GUI.Box (position, "");
		
		DrawBoard();
//		DrawPieces();
		
	    GUI.EndGroup();
		}
	}
	
	void DrawBoard()
	{
//	    for (int m = 0;m<4;m++)
//		{
//		    for(int n = 0; n<4;n++)
//			{
//			GUI.Label (new Rect(m*blockSquare, n*blockSquare, blockSquare,blockSquare),tile,"label");
//			}
//		}
		GUI.Button (new Rect(0*blockSquare, 0*blockSquare, 2*blockSquare,blockSquare),"Enter Combination:");
		GUI.Button (new Rect(2*blockSquare, 0*blockSquare, 3*blockSquare,blockSquare),combo);
		
		if (GUI.Button (new Rect(0*blockSquare, 1*blockSquare, blockSquare,blockSquare),"9"))
		{
			if (combo.Length < numberLimit)
			{
			    combo = combo + "9";
			}
		}
		if (GUI.Button (new Rect(1*blockSquare, 1*blockSquare, blockSquare,blockSquare),"8"))
		{
			if (combo.Length < numberLimit)
			{
			    combo = combo + "8";
			}
		}
		if (GUI.Button (new Rect(2*blockSquare, 1*blockSquare, blockSquare,blockSquare),"7"))
		{
			if (combo.Length < numberLimit)
			{
			    combo = combo + "7";
			}
		}
		if (GUI.Button (new Rect(0*blockSquare, 2*blockSquare, blockSquare,blockSquare),"6"))
		{
			if (combo.Length < numberLimit)
			{
			    combo = combo + "6";
			}
		}
		if (GUI.Button (new Rect(1*blockSquare, 2*blockSquare, blockSquare,blockSquare),"5"))
		{
			if (combo.Length < numberLimit)
			{
			    combo = combo + "5";
			}
		}
		if (GUI.Button (new Rect(2*blockSquare, 2*blockSquare, blockSquare,blockSquare),"4"))
		{
			if (combo.Length < numberLimit)
			{
			    combo = combo + "4";
			}
		}
		if (GUI.Button (new Rect(0*blockSquare, 3*blockSquare, blockSquare,blockSquare),"3"))
		{
			if (combo.Length < numberLimit)
			{
			    combo = combo + "3";
			}
		}
		if (GUI.Button (new Rect(1*blockSquare, 3*blockSquare, blockSquare,blockSquare),"2"))
		{
			if (combo.Length < numberLimit)
			{
			    combo = combo + "2";
			}
		}
		if (GUI.Button (new Rect(2*blockSquare, 3*blockSquare, blockSquare,blockSquare),"1"))
		{
			if (combo.Length < numberLimit)
			{
			    combo = combo + "1";
			}
		}
		if (GUI.Button (new Rect(0*blockSquare, 4*blockSquare, blockSquare,blockSquare),"0"))
		{
			if (combo.Length < numberLimit)
			{
			    combo = combo + "0";
			}
		}
		if (GUI.Button (new Rect(1*blockSquare, 4*blockSquare, 2*blockSquare,blockSquare),"<---"))
		{
			if (combo.Length > 0 && combo.Length < 5)
			{
				combo = combo.Substring(0,combo.Length - 1);
			}
		}
		GUI.Button (new Rect(3*blockSquare, 1*blockSquare, 2*blockSquare,blockSquare),updater);
		GUI.Button (new Rect(3*blockSquare, 2*blockSquare, 2*blockSquare,blockSquare),"Attempts Left: " + tries);
		if (GUI.Button (new Rect(3*blockSquare, 3*blockSquare, 2*blockSquare,blockSquare),"Submit"))
		{
			if (tries > 0 && doorOpen == false)
			{
				if (string.Compare (combo,correctCombo) == 0)
				{
					doorOpen = true;
					updater = "DOOR OPEN";
					combo = "DOOR OPEN";
					//do door opening stuff
					GameObject.Find("Door").rigidbody.AddForce(17,0,0);
					audio.PlayOneShot(doorOpeningSound);
					
				
				}
				else
				{
					tries = tries - 1;
					updater = "Combo " + combo + " incorrect";
					combo = "";
					if (tries == 0)
					{
						
						updater = "ERR: KEYPAD LOCKED";
						combo = "ERROR: KEYPAD LOCKED";
						Application.LoadLevel("LoseScene");
					}
				}
			}
		}
		if (GUI.Button (new Rect(3*blockSquare, 4*blockSquare, 2*blockSquare,blockSquare),"Exit"))
		{
			keypadUp = false;
			GameObject player = GameObject.Find ("First Person Controller");
			MouseLook script = player.GetComponent<MouseLook>();
			script.keypadUp = false;
			
		}
	}
	
	void OnTriggerStay()
	{
	
	if (Input.GetKeyDown(KeyCode.E) == true)
		{
			keypadUp = true;
			Screen.showCursor = true; 
		}	
	}
	


//    void DrawPieces()
//    {
//	    for (int i = 0; i <currentGame.tiles.Count;i++)
//	    {
//	    	int x = currentGame.tiles[i].x;
//	    	int y = currentGame.tiles[i].y;
//			Texture png = currentGame.tiles[i].image;
//			if(GUI.Button(new Rect(x*blockSquare,y*blockSquare,blockSquare,blockSquare),png,"label"))
//			{
//				//Tile til = currentGame.tiles[i];
//				if (wordStarted == false || (til.near == true && til.selected == false))
//				{
//					wordStarted = true;
//					if (currentPiece != null)
//					{
//						currentPiece.inUse = false;
//						setNear (false,currentPiece);
//					}
//			        currentPiece = til;
//					currentI = i;
//					
//					currentPiece.selected = true;
//					currentPiece.inUse = true;
//					setNear (true,currentPiece);
//					currentWord = currentWord + currentPiece.thisLetter.letter;
//					currentWordScore += currentPiece.thisLetter.numValue;
//					showScore = currentWordScore * ((currentWord.Length - 1) / 2);
//					currentGame.tiles[i].image = (Texture)(Resources.Load(currentGame.tiles[i].thisLetter.imageName + "S")) as Texture;
//				}
//			}
//		}
//    }
}
