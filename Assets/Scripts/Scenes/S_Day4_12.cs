using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class S_Day4_12 : MonoBehaviour
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
		ChangeDescriptionText ("MP: Well I would love too, but I kinda told lee that we were going to make prestige 5 tonight in COD.\nSam: Oh… okay… well I will see you later. ");
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
			ChangeDescriptionText ("MP: *Sighs* damn… I did it again.\nMP waits for Lee to get out of class\nLee: Who pissed in your coffee? ");
		}
		else if (cntr == 1)
		{
			ChangeDescriptionText ("MP: Oh, I just passed up an opportunity to hang out with Sam.\nLee: Again dude, you know I would have bailed if I knew you and Sam were together.  ");
		}
		else if (cntr == 2)
		{
			ChangeDescriptionText ("SMP: I know… just I really don’t know, let’s just go kill shit.\nMP and Lee go back to MP’s room ");
		}
		else if (cntr == 3)
		{
			ChangeDescriptionText ("After long time\nLee: Can I date Sam?\nMP: Holy shit dude, where the hell did that come from?");
		}
		else if (cntr == 4)
		{
			ChangeDescriptionText ("Lee: I was just thinking dude, Sam’s a cute chick, and I have been trying to help and get you the courage to date her. So far I have seen months of not a damn step in the right direction.\nMP: Okay dude, this is not the conversation I want to have right now. ");
		}
		else if(cntr == 5)
		{
			ChangeDescriptionText("Lee: Fine suit yourself, but I’m not going to wait forever, because you know I have liked her since I got here.\nMP: Fine… I will try to move forward. ");
		}
		else if(cntr == 6)
		{
			ChangeDescriptionText("Lee: Alright, night dude, I got an 8am class.\nMP: Night dude. ");
		}
		else if(cntr == 7)
		{
			ChangeDescriptionText ("Fifth Day, Wakes up, Showers, Goes to class\nAfter School\nMP: Damn I can’t seem to find Lee… or Sam for that Matter. Well I have been putting it off, let’s hit the gym. ");
			GameObject.Find ("Character").GetComponent<CC_Character> ().AnxietyDown ();
			GameObject.Find ("Character").GetComponent<CC_Character> ().FocusUp ();
		}
		else if (cntr == 8)
		{
			ChangeDescriptionText ("MP: Shit, I completely forgot about that paper.\nSam: Well that answers that question. :P What would you do without me? ");
		}
		else if (cntr == 9)
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
