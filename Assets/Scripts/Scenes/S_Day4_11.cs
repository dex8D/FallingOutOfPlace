using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class S_Day4_11 : MonoBehaviour
{
	#region "Class Variables"
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
		ChangeDescriptionText ("MP: Well, you know I could use a duo partner, or a player two on some game\nSam: I was hoping you would say that.");
		ChangeAnswer1Text ("(Continue)");
		ChangeAnswer2Text ("");
		//		ChangeAnswer3Text ("");
		//		ChangeAnswer4Text ("");
		//		ChangeAnswer5Text ("");
	}
	
	#region "Button Events"
	public void btnOneEvent ()
	{
		if (cntr == 0)
		{
			ChangeDescriptionText ("They go back to MP’s room and start to play video games\nAfter a while, it gets dark.\nSam: Well that was a productive evening.\nMP: Beats being stuck alone, raging at Dark Souls all day ");
		}
		else if (cntr == 1)
		{
			ChangeDescriptionText ("Sam: *Laughs* most definitely true\nMP: I forgot how fun this was, it’s been ages since we last hung out. ");
		}
		else if (cntr == 2)
		{
			ChangeDescriptionText ("Sam: Agreed, it’s nice to just unwind with someone close, and forget all the expectations.\nMP: Right!");
		}
		else if (cntr == 3)
		{
			ChangeDescriptionText ("Sam: Well I need to get to bed, 8am class.\nMP: Okay sweet dreams Sam *hug*\nSam: You too. *hug* ");
		}
		else if (cntr == 4)
		{
			ChangeDescriptionText ("Fifth Day, Wakes up, Showers, Goes to class\nAfter School\nMP: Damn I can’t seem to find Lee… or Sam for that Matter. Well I have been putting it off, let’s hit the gym. ");
			GameObject.Find ("Character").GetComponent<CC_Character> ().AnxietyDown ();
			GameObject.Find ("Character").GetComponent<CC_Character> ().FocusUp ();
		}
		else if (cntr == 5)
		{
			ChangeDescriptionText ("MP: Shit, I completely forgot about that paper.\nSam: Well that answers that question. :P What would you do without me? ");
		}
		else if (cntr == 6)
		{
			ChangeDescriptionText ("MP: *internally* Do I give her the honest answer or just joke with her?");
			ChangeAnswer1Text ("Be honest. (Focus Down, Anxiety UP) ");
			ChangeAnswer2Text ("Just joke. (Focus UP, Anxiety Down) ");
		}
		cntr++;

		//*******consult grant further
	}
	
	public void btnTwoEvent ()
	{
			//Application.LoadLevel ("MP_Day2_3");
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
