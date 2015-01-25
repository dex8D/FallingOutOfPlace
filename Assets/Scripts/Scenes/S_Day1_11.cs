using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class S_Day1_11 : MonoBehaviour
{
	#region "Class Variables"
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

//		private int cntr = 0;
	#endregion // Class Variables
	
	#region "Events"
		void Awake ()
		{
				Debug.Log (Application.loadedLevelName + " " + Application.loadedLevel.ToString ());
				ChangeDescriptionText ("MP: ugh these mornings are so tedious…. Should I even shower?");
				ChangeAnswer1Text ("Yes: I better, I smell like shit later if I don’t (Focus UP, Anxiety Down)");
				ChangeAnswer2Text ("No: That’s too much work, AXE here I come (Focus Down, Anxiety UP)");
//		ChangeAnswer3Text ("");
//		ChangeAnswer4Text ("");
//		ChangeAnswer5Text ("");
		}
	
	#region "Button Events"
		public void btnOneEvent ()
		{
				Debug.Log ("Load Level1Test from Level1Test");
				GameObject.Find ("Character").GetComponent<CC_Character> ().AnxietyDown ();
				GameObject.Find ("Character").GetComponent<CC_Character> ().FocusUp ();
				Application.LoadLevel ("MP_Day1_2");
		}
	
		public void btnTwoEvent ()
		{
				Debug.Log ("Load Level2Test from Level1Test");
				GameObject.Find ("Character").GetComponent<CC_Character> ().AnxietyUp ();
				GameObject.Find ("Character").GetComponent<CC_Character> ().FocusDown ();
				Application.LoadLevel ("MP_Day1_2");
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
