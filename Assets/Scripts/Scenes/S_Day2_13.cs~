using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class S_Day2_13 : MonoBehaviour
{
	#region "Class Variables"
		public GameObject goBackground = null;
		public Sprite sprite1 = null;
		public Sprite sprite2 = null;
		public Sprite sprite3 = null;
		public Sprite sprite4 = null;
		public Sprite sprite5 = null;
	
		public Text txtText = null;
		public Text txtAnswer1 = null;
		public Text txtAnswer2 = null;
	
		public Button btnAnswer1 = null;
		public Button btnAnswer2 = null;
	
		private int cntr = 0;
	#endregion // Class Variables
	
	#region "Events"
		void Awake ()
		{
				Debug.Log (Application.loadedLevelName + " " + Application.loadedLevel.ToString ());
				ChangeDescriptionText ("MP: Honestly I don’t know… you make my life quite better\nSam: I know :)");
				ChangeAnswer1Text ("(Continue)");
				ChangeAnswer2Text ("");
				//		ChangeAnswer3Text ("");
				//		ChangeAnswer4Text ("");
				//		ChangeAnswer5Text ("");
		}
	
	#region "Button Events"
		public void btnOneEvent ()
		{
				if (cntr == 0) {
						ChangeDescriptionText ("MP: Probably lose my mind and fail a class or two\nSam: No kidding :P ");
				} else if (cntr == 1) {
						ChangeDescriptionText ("MP: Speaking of failing classes, can you give me some hints on the paper\nSam: Fine, but just one more time. I can’t keep bailing you out, she will catch on to us");
				} else if (cntr == 2) {
						ChangeDescriptionText ("MP: Thank you so much, I will ttyl\nSam: No problem, ttyl <3 ");
				} else if (cntr == 3) {
						ChangeDescriptionText ("MP then does the paper, and spends the rest of the night playing computer games ");
				} else if (cntr == 4) {
						goBackground.GetComponent<SpriteRenderer> ().sprite = sprite2;
						ChangeDescriptionText ("Third Day\nAlarm goes off, MP has a huge headache: \nDo I even want to shower?");
						ChangeAnswer1Text ("Yes: I better, I smell like shit later if I don’t");
						ChangeAnswer2Text ("No: That’s too much work, AXE here I come");
				} else if (cntr == 5) {
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().AnxietyDown ();
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().FocusUp ();
						goBackground.GetComponent<SpriteRenderer> ().sprite = sprite3;
						ChangeDescriptionText ("Normal School day\nAfter School Lee Scene\nLee: Dude, it’s Wednesday, ready to light it up?");
						ChangeAnswer1Text ("Yep");
						ChangeAnswer2Text ("Nope");
				} else if (cntr == 6) {
						Application.LoadLevel ("MP_Day2_4");
				}
		
				cntr++;
		
		}
	
		public void btnTwoEvent ()
		{
				if (cntr == 5) {
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().AnxietyUp ();
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().FocusDown ();
						goBackground.GetComponent<SpriteRenderer> ().sprite = sprite3;
						ChangeDescriptionText ("Normal School day\nAfter School Lee Scene\nLee: Dude, it’s Wednesday, ready to light it up?");
						ChangeAnswer1Text ("Yep");
						ChangeAnswer2Text ("Nope");
						cntr++;
				} else if (cntr == 6) {
						Application.LoadLevel ("MP_Day2_5");
				}
		}
		/*
	public void btnThreeEvent ()
	{
		Debug.Log ("Load Level3Test from Level1Test");
		Application.LoadLevel ("Level3Test");
	}
	
	public void btnFourEvent ()
	{
		Debug.Log ("Load Level4Test from Level1Test");
		Application.LoadLevel ("Level4Test");
	}
	
	public void btnFiveEvent ()
	{
		Debug.Log ("Load Level5Test from Level1Test");
		Application.LoadLevel ("Level5Test");
	}
*/

	#endregion // Button Events
	#endregion // Events
	
	#region "Methods"
	#region "Change Text"
		private void ChangeAnswer1Text (string localText)
		{
				txtAnswer1.text = localText;
		}
	
		private void ChangeAnswer2Text (string localText)
		{
				txtAnswer2.text = localText;
		}
	
		/*	private void ChangeAnswer3Text (string localText)
	{
		txtAnswer3.text = localText;
	}
	
	private void ChangeAnswer4Text (string localText)
	{
		txtAnswer4.text = localText;
	}
	
	private void ChangeAnswer5Text (string localText)
	{
		txtAnswer5.text = localText;
	}
*/	
		private void ChangeDescriptionText (string localText)
		{
				txtText.text = localText;
		}
	
	#endregion // Change Text
	#endregion // Methods
}
