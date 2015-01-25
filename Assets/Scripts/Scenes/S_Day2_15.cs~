using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class S_Day2_15 : MonoBehaviour
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
				ChangeDescriptionText ("MP: No, let’s not tonight, I had a huge migraine this morning and I don’t want another.\nLee: *sighs* fine, but I’m not drinking alone, let’s go light up the consoles ");
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
						goBackground.GetComponent<SpriteRenderer> ().sprite = sprite2;
						ChangeDescriptionText ("MP: Now you’re talking!\nSpends the rest of the night with Lee ");
						cntr = 4;
				} else if (cntr == 5) {
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().AnxietyDown ();
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().FocusUp ();
						goBackground.GetComponent<SpriteRenderer> ().sprite = sprite3;
						ChangeDescriptionText ("Fourth Day\nMP: That was a lot of fun.\nShowers to wake up.");
				} else if (cntr == 6) {
						goBackground.GetComponent<SpriteRenderer> ().sprite = sprite4;
						ChangeDescriptionText ("Goes to school\nMP class ends early so he goes to the cafeteria to rest\nMP rests his head on a table ");
				} else if (cntr == 7) {
						ChangeDescriptionText ("Sam: Hey sleepyhead\nMP: whaa… OH Sam! Hey! ");
				} else if (cntr == 8) {
						ChangeDescriptionText ("Sam: You really need to sleep more.\nMP: Yea I know… I blame Lee. ");
				} else if (cntr == 9) {
						ChangeDescriptionText ("Sam *Laughs* yea, Lee does like to keep people up.\nMP: Tell me about it. ");
				} else if (cntr == 10) {
						ChangeDescriptionText ("Sam: What are you doing down here, I thought you had class during this time?\nMP: Yea I did, but it got let out early, we had a test. ");
				} else if (cntr == 11) {
						ChangeDescriptionText ("Sam: How did you do?\nMP: If I did well, would I be down here holding my head? ");
				} else if (cntr == 12) {
						ChangeDescriptionText ("Sam: *chuckles* No I suppose not.\nMP: what about you, what are you up to down here. ");
				} else if (cntr == 13) {
						ChangeDescriptionText ("Sam: I was just bored, came to harass people.\nMP: I was the first choice? ");
				} else if (cntr == 14) {
						ChangeDescriptionText ("Sam: Kinda yea.\nMP: I don’t know if I should be flattered or annoyed. ");
				} else if (cntr == 15) {
						ChangeDescriptionText ("Sam: Both, both is good.\nMP: Both is good. ");
				} else if (cntr == 16) {
						ChangeDescriptionText ("Sam: I got to go, unless you want to do something. ");
						ChangeAnswer1Text ("Yeah, totally");
						ChangeAnswer2Text ("Ah, well...");
				} else if (cntr == 17) {
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().AnxietyDown ();
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().FocusUp ();
						Application.LoadLevel ("MP_Day2_6");
				}
		
				cntr++;
		
		}
	
		public void btnTwoEvent ()
		{
				if (cntr == 17) {
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().AnxietyUp ();
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().FocusDown ();
						Application.LoadLevel ("MP_Day2_7");
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
