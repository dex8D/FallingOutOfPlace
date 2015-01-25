using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CC_Arrow : MonoBehaviour
{

#region "Class Variables"
		public string strDirection = "";
		public string strObject = "";
		public string strNumber = "";
		public int intNumberOfImages = 0;
		public int intImage = 0;
	
		private GameObject goOff;
		private GameObject goOn;
	
		private GameObject goLeftArrow;
		private GameObject goRightArrow;

		private GameObject character;
	
		private List<GameObject> listGameObjects = new List<GameObject> ();
		private List<GameObject> listGameObjects2 = new List<GameObject> ();
#endregion

#region "Events"
		// Use this for initialization
		void Start ()
		{
		
		}
	
		void Awake ()
		{
				goOn = GameObject.Find (strObject + "On");
				goOff = GameObject.Find (strNumber + strObject + "Off");
		
				// TODO Reformat this to reduce the number of used GameObject.Finds
				goLeftArrow = GameObject.Find (strNumber + "Arrow" + "Left");
				goRightArrow = GameObject.Find (strNumber + "Arrow" + "Right");

				int i;
				for (i = 0; i < intNumberOfImages; i++) {
						listGameObjects.Add (GameObject.Find (strObject + i.ToString ()));
						listGameObjects2.Add (GameObject.Find (strObject + "On" + i.ToString ()));
				}

				character = GameObject.Find ("Character");
		}
	 
		// Update is called once per frame
		void Update ()
		{
		
		}

#region "Mouse Events"
		void OnMouseDown ()
		{
				//Debug.Log ("Works");
				if (strDirection == "Left") {
						ChangeSprite ("Left");
				} else if (strDirection == "Right") {
						ChangeSprite ("Right");
				} else {
						Debug.Log ("An error has occurred.");
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

#region "Methods"
		void ChangeSprite (string localDirection)
		{
	
				if (localDirection == "Left") {
						if (intImage == 0) {
								listGameObjects [0].transform.position = new Vector3 (0, 10, 0);
								listGameObjects [intNumberOfImages - 1].transform.position = goOff.transform.position + new Vector3 (0, 0, -1);
				
								listGameObjects2 [0].transform.position = new Vector3 (0, 10, 0);
								listGameObjects2 [intNumberOfImages - 1].transform.position = goOn.transform.position + new Vector3 (0, 0, -1);
								//Debug.Log (intImage);
								goRightArrow.GetComponent<CC_Arrow> ().intImage = intNumberOfImages - 1;
								intImage = intNumberOfImages - 1;
								HelpCharacter ();
						} else {
								listGameObjects [intImage].transform.position = new Vector3 (0, 10, 0);
								listGameObjects [intImage - 1].transform.position = goOff.transform.position + new Vector3 (0, 0, -1);
				
								listGameObjects2 [intImage].transform.position = new Vector3 (0, 10, 0);
								listGameObjects2 [intImage - 1].transform.position = goOn.transform.position + new Vector3 (0, 0, -1);
								//Debug.Log (intImage);
				
								goRightArrow.GetComponent<CC_Arrow> ().intImage = intImage - 1;
								intImage = intImage - 1;
								HelpCharacter ();
						}
				} else if (localDirection == "Right") { 
						if (intImage == intNumberOfImages - 1) {
								listGameObjects [intNumberOfImages - 1].transform.position = new Vector3 (0, 10, 0);
								listGameObjects [0].transform.position = goOff.transform.position + new Vector3 (0, 0, -1);
				
								listGameObjects2 [intNumberOfImages - 1].transform.position = new Vector3 (0, 10, 0);
								listGameObjects2 [0].transform.position = goOn.transform.position + new Vector3 (0, 0, -1);
								//Debug.Log (intImage);
				
								goLeftArrow.GetComponent<CC_Arrow> ().intImage = 0;
								intImage = 0;
								HelpCharacter ();
						} else {
								listGameObjects [intImage].transform.position = new Vector3 (0, 10, 0);
								listGameObjects [intImage + 1].transform.position = goOff.transform.position + new Vector3 (0, 0, -1);
				
								listGameObjects2 [intImage].transform.position = new Vector3 (0, 10, 0);
								listGameObjects2 [intImage + 1].transform.position = goOn.transform.position + new Vector3 (0, 0, -1);
								//Debug.Log (intImage);
				
								goLeftArrow.GetComponent<CC_Arrow> ().intImage = intImage + 1;
								intImage = intImage + 1;
								HelpCharacter ();
						}
				} else {
						Debug.Log ("It should not be possible to get here.");
				}
		
		
//		if (spriteRenderer.sprite == sprite1) // if the spriteRenderer sprite = sprite1 then change to sprite2
//		{
//			spriteRenderer.sprite = sprite2;
//		}
//		else
//		{
//			spriteRenderer.sprite = sprite1; // otherwise change it back to sprite1
//		}
		}

		void HelpCharacter ()
		{
				if (strObject == "Hair") {
						character.GetComponent<CC_Character> ().hair = intImage;
				} else if (strObject == "Eye") {
						character.GetComponent<CC_Character> ().eyes = intImage;
				} else if (strObject == "Shirt") {
						character.GetComponent<CC_Character> ().shirt = intImage;
				} else if (strObject == "Pants") {
						character.GetComponent<CC_Character> ().pants = intImage;
				}
		}
	
	#endregion // Methods
}
 