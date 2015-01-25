using UnityEngine;
using System.Collections;

public class MM_Buttons : MonoBehaviour
{

	#region "Class Variables"
	public string strButton = "";
	#endregion
	
	#region "Events"
	void Awake ()
	{
		Debug.Log ("MM_Buttons Awake");
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
		//Debug.Log ("Down     " + strButton);
		Debug.Log ("Works");
		if (strButton == "Start")
		{
			Application.LoadLevel ("GenderSelect");
		}
		else if (strButton == "Quit")
		{
			Debug.Log ("QUIT GAME");
			Application.Quit ();
		}
	}
	
	void OnMouseEnter ()
	{
		//Debug.Log ("Enter");
	}
		
	void OnMouseLeave ()
	{
		//Debug.Log ("Leave");
	}
		
	void OnMouseUp ()
	{
		//Debug.Log ("up");
	}
		
	void OnMouseOver ()
	{
		//Debug.Log ("Over");
	}
	#endregion // Mouse Events
	
	#endregion // Events
}
