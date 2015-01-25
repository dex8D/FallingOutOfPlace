using UnityEngine;
using System.Collections;

public class CC_Buttons : MonoBehaviour
{
	#region "Class Variables"
	public string strButton = "";
	public bool chosenGender;
	#endregion
	
	#region "Events"
	void Awake ()
	{
		Debug.Log ("CC_Buttons Awake");
	}
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}	
	#region "Button Events"
	void OnMouseDown ()
	{
		//Debug.Log ("Works");
		if (strButton == "Start")
		{
			// Load Male Screen?
			Debug.Log ("Start Game Button");

/*			int h;
			int e;
			int s;
			int p;

			h = GameObject.Find ("FirstArrowLeft").intImage;
*/
			if(chosenGender){
				Debug.Log ("male game");
				Application.LoadLevel ("MP_Day1_1");
			}
			else
			{
				Debug.Log ("female game");
				Application.LoadLevel ("FP_Day1_1");
			}
		}
		else if (strButton == "Back")
		{
			// Load Female Screen?
			Debug.Log ("Back Button");
			DestroyImmediate (GameObject.Find ("Character"));
			Application.LoadLevel ("MainMenu");
		}
		else
		{
			Debug.Log ("// It shouldn't be possible to get here.");
		}
	}
	
	//	void OnMouseEnter ()
	//	{
	//		Debug.Log ("Enter");
	//	}
	//	
	//	void OnMouseLeave ()
	//	{
	//		Debug.Log ("Leave");
	//	}
	//	
	//	void OnMouseUp ()
	//	{
	//		Debug.Log ("up");
	//	}
	//	
	//	void OnMouseOver ()
	//	{
	//		Debug.Log ("Over");
	//	}
	#endregion // Mouse Events
	
	#endregion // Events
	
}
