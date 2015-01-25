using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class S_Day2_25 : MonoBehaviour
{
	#region "Class Variables"
		public Text txtText = null;
		public Text txtAnswer1 = null;
		public Text txtAnswer2 = null;
		public Text txtAnswer3 = null;
		public Text txtAnswer4 = null;
		public Text txtAnswer5 = null;
	
		public Button btnAnswer1 = null;
		public Button btnAnswer2 = null;
		public Button btnAnswer3 = null;
		public Button btnAnswer4 = null;
		public Button btnAnswer5 = null;
	#endregion // Class Variables
	
	#region "Events"
		void Awake ()
		{
				Debug.Log (Application.loadedLevelName + " " + Application.loadedLevel.ToString ());
				ChangeDescriptionText ("ALL THE WRONG THINGS!!  You wander into public on your first day of whatever and what not.  Unbeknownst to you, a major change" + 
						"had occurred to your body.");
				ChangeAnswer1Text ("Continue");
				ChangeAnswer2Text ("");
				ChangeAnswer3Text ("");
				ChangeAnswer4Text ("");
				ChangeAnswer5Text ("");
		}
	
	#region "Button Events"
		public void btnOneEvent ()
		{
				Debug.Log ("Load Level1Test from Level1Test");
				Application.LoadLevel ("Level2Test");
		}
	
		public void btnTwoEvent ()
		{
				Debug.Log ("Load Level2Test from Level1Test");
				Application.LoadLevel ("Level2Test");
		}
	
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
	
		private void ChangeAnswer3Text (string localText)
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
	
		private void ChangeDescriptionText (string localText)
		{
				txtText.text = localText;
		}
	#endregion // Change Text
	#endregion // Methods
}
