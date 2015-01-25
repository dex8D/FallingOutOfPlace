using UnityEngine;
using System.Collections;

public class CC_Character : MonoBehaviour
{
	#region "Class Variables"
		public static CC_Character self = null;

		public int hair = 0;
		public int eyes = 0;
		public int shirt = 0;
		public int pants = 0;

		public int focus = 0;
		public int anxiety = 0;


		private GameObject goCharacterLocation;


		//private string strGender = "";	
	#endregion // Class Variables
		
	#region "Events"
		void Awake ()
		{
				//Debug.Log (this.ToString () + "  ::  " + (this != null).ToString () + "  ::  " + (self != this).ToString () + "  ::  " + (this != null && self != this).ToString ());
				if (self != null && self != this) {
						//Debug.Log ("Why is this getting deleted right away?");
						Destroy (this.gameObject);
						return;
				} else {
						self = this;
				}
		
				DontDestroyOnLoad (this);
		}
	
		// Use this for initialization
		void Start ()
		{
				anxiety = Random.Range (-2, 2);
				focus = Random.Range (-2, 2);
		}
	
		void OnLevelWasLoaded (int localLevelNumber)
		{
				if (Application.loadedLevelName.ToString () != "CharacterCreation" && Application.loadedLevelName.ToString () != "FemaleCharacterCreation") {
						goCharacterLocation = GameObject.Find ("CharacterLocation");
						Move (true);
				} else {
			
//			GameObject goMale = GameObject.Find ("Male");
//			GameObject goFemale = GameObject.Find ("Female");
//			if (goMale == null)
//			{
//				//strGender = "Female";
//				GetComponent<SpriteRenderer> ().sprite = sprFemale;
//				Destroy (goFemale);
//			}
//			else
//			{
//				//strGender = "Male";
//				Destroy (goMale);
//			}
			
						goCharacterLocation = null;
				}
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
	#endregion // Events
	
	#region "Methods"
		void Move (bool bolShow)
		{
				if (bolShow == true) {
						// TODO Create an empty gameObject for which the characters can be moved to easily.
						//Debug.Log (transform.position.ToString ());
						transform.position = goCharacterLocation.transform.position;
						//Debug.Log (transform.position.ToString ());
				} else {
						transform.position = new Vector3 (0, 10, 0);
				}
		}

		public void FocusUp ()
		{
				if (focus < 2) {
						focus++;
				}
		}

		public void FocusDown ()
		{
				if (focus > -2) {
						focus--;
				}
		}

		public void AnxietyUp ()
		{
				if (anxiety < 2) {
						anxiety++;
				}
		}

		public void AnxietyDown ()
		{
				if (anxiety > -2) {
						anxiety--;
				}
		}
	#endregion // Methods
}
 