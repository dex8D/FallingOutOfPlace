using UnityEngine;
using System.Collections;

public class GS_Buttons : MonoBehaviour
{
	
	#region "Class Variables"
	public string strGender = "";
	//public static GS_Buttons self;
	//public GameObject goSelf;
	#endregion
	
	#region "Events"
	void Awake ()
	{
		Debug.Log ("GS_Buttons Awake");
		//self = this;
		//goSelf = this.gameObject;
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
		if (strGender == "Male")
		{
			// Load Male Screen?
			//DontDestroyOnLoad (this);
			Application.LoadLevel ("CharacterCreation");
		}
		else if (strGender == "Female")
		{
			// Load Female Screen?
			//DontDestroyOnLoad (this);
			Application.LoadLevel ("FemaleCharacterCreation");
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
