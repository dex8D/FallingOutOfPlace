using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class S_Day2_11 : MonoBehaviour
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
				ChangeDescriptionText ("MP goes to school, normal events happen\nAfter School Lee\nLee: I’m so glad that chem homework was just completion.\nMP: You and me both. You want to go hangout?");
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
						ChangeDescriptionText ("Lee: Nah, I’m off to meet up with some guys for a project.\nMP: Suit yourself, I’m going to go work out then. ");
				} else if (cntr == 1) {
						ChangeDescriptionText ("Lee: Just don’t overdo the bench presses, remember what happened last time?\nMP: *shudders* I still have some of the bruises. I won’t do that again. ");
				} else if (cntr == 2) {
						goBackground.GetComponent<SpriteRenderer> ().sprite = sprite2;
						ChangeDescriptionText ("The Gym\nMP: Alright let’s get started, do I start with a cardio warm up, or go balls deep?");
						ChangeAnswer1Text ("Warm Up: Cardio will make this work out more effective");
						ChangeAnswer2Text ("Balls Deep: Nah, Go big or go home");
				} else if (cntr == 3) {
						Debug.Log ("Load Level1Test from Level1Test");
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().AnxietyDown ();
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().FocusUp ();
						goBackground.GetComponent<SpriteRenderer> ().sprite = sprite3;
						ChangeDescriptionText ("After the workout: The showers are open, should I shower now?");
						ChangeAnswer1Text ("Yes: I better, I smell like shit");
						ChangeAnswer2Text ("No: I’m too worn out, I will shower later. AXE come to papa ");
				} else if (cntr == 4) {
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().AnxietyDown ();
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().FocusUp ();
						goBackground.GetComponent<SpriteRenderer> ().sprite = sprite4;
						ChangeDescriptionText ("Home\nAfter a little bit of homework, he starts texting\nMP: I should probably see how Sam is doing. *into phone* What’s up?\nSam: Not much, just getting done with history. You? ");
						ChangeAnswer1Text ("(Continue)");
						ChangeAnswer2Text ("");
				} else if (cntr == 5) {
						ChangeDescriptionText ("MP: Shit, I completely forgot about that paper.\nSam: Well that answers that question. :P What would you do without me? ");
				} else if (cntr == 6) {
						ChangeDescriptionText ("MP: *internally* Do I give her the honest answer or just joke with her?");
						ChangeAnswer1Text ("Be honest. (Focus Down, Anxiety UP) ");
						ChangeAnswer2Text ("Just joke. (Focus UP, Anxiety Down) ");
				} else if (cntr == 7) {
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().AnxietyUp ();
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().FocusDown ();
						Application.LoadLevel ("MP_Day2_2");
				}
				cntr++;
		}
	
		public void btnTwoEvent ()
		{
				if (cntr == 3) {
						Debug.Log ("Load Level2Test from Level1Test");
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().AnxietyUp ();
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().FocusDown ();
						goBackground.GetComponent<SpriteRenderer> ().sprite = sprite3;
						ChangeDescriptionText ("After the workout: The showers are open, should I shower now?");
						ChangeAnswer1Text ("Yes: I better, I smell like shit");
						ChangeAnswer2Text ("No: I’m too worn out, I will shower later. AXE come to papa ");
						cntr++;
				} else if (cntr == 4) {
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().AnxietyUp ();
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().FocusDown ();
						
						goBackground.GetComponent<SpriteRenderer> ().sprite = sprite4;
						ChangeDescriptionText ("Home\nAfter a little bit of homework, he starts texting\nMP: I should probably see how Sam is doing. *into phone* What’s up?\nSam: Not much, just getting done with history. You? ");
						ChangeAnswer1Text ("(Continue)");
						ChangeAnswer2Text ("");
						cntr++;
				} else if (cntr == 7) {
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().AnxietyDown ();
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().FocusUp ();
						Application.LoadLevel ("MP_Day2_3");
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
