//
//using System.Collections;
//using UnityEngine;
//using UnityEngine.UI;
//
//public class G_GameController : MonoBehaviour
//{
//	#region "Class Variables"
//	public Text txtText = null;
//	public Text txtAnswer1 = null;
//	public Text txtAnswer2 = null;
//	public Text txtAnswer3 = null;
//	public Text txtAnswer4 = null;
//	public Text txtAnswer5 = null;
//	
////	public Button btnAnswer1 = null;
////	public Button btnAnswer2 = null;
////	public Button btnAnswer3 = null;
////	public Button btnAnswer4 = null;
////	public Button btnAnswer5 = null;
//	
//	private GameObject btnAnswer11 = null;
//	private GameObject btnAnswer22 = null;
//	private GameObject btnAnswer33 = null;
//	private GameObject btnAnswer44 = null;
//	private GameObject btnAnswer55 = null;
//	
//	private int intScene = 0;
//	private int intSceneMiddle = 0;
//	private bool bolMiddle = false;
//	
//	public int intFocus = 0;
//	#endregion
//
//	#region "Events"
//	// Use this for initialization
//	void Start ()
//	{
//		// Unable to properly pull Text fields in through code for some reason.  Doing so in the editor.
//		//btnAnswer1 = GameObject.Find ("Button1");
//		btnAnswer11 = GameObject.Find ("Button11");
//		btnAnswer22 = GameObject.Find ("Button22");
//		btnAnswer33 = GameObject.Find ("Button33");
//		btnAnswer44 = GameObject.Find ("Button44");
//		btnAnswer55 = GameObject.Find ("Button55");
//		
//		StartText ();
//	}
//	
//	// Update is called once per frame
//	void Update ()
//	{
//		if (Input.GetKeyDown (KeyCode.Escape) == true)
//		{
//			// TODO Add a messagebox type thing to pop up and ask the player if they want to quit.  If yes, quit to main menu.  If no, return.
//			Debug.Log ("Escape has been pressed.");
//		}
//	}
//	#endregion // Events
//	
//	#region "Methods"
//	
//	#region "Change Text"
//	private void ChangeAnswer1Text (string localText)
//	{
//		txtAnswer1.text = localText;
//	}
//	
//	private void ChangeAnswer2Text (string localText)
//	{
//		txtAnswer2.text = localText;
//	}
//	
//	private void ChangeAnswer3Text (string localText)
//	{
//		txtAnswer3.text = localText;
//	}
//	
//	private void ChangeAnswer4Text (string localText)
//	{
//		txtAnswer4.text = localText;
//	}
//	
//	private void ChangeAnswer5Text (string localText)
//	{
//		txtAnswer5.text = localText;
//	}
//	
//	private void ChangeDescriptionText (string localText)
//	{
//		txtText.text = localText;
//	}
//	#endregion // Change Text
//	
//	#region "Button Methods"
//	public void Button1 ()
//	{
//		Debug.Log ("?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!?!??!?!?!?!??!?!?!?!");
//		if (bolMiddle == false)
//		{
//			switch (intScene)
//			{
//			case 0:
//				Bathroom (intFocus);
//				break;
//			case 1:
//				break;
//			case 2:
//				break;
//			case 3:
//				break;
//			default:
//				break;
//			}
//		}
//		else
//		{
//			switch (intSceneMiddle)
//			{
//			case 0:
//				break;
//			case 1:
//				break;
//			case 2:
//				break;
//			case 3:
//				break;
//			default:
//				break;
//			}
//		}
//	}
//	
//	public void Button2 ()
//	{
//		if (bolMiddle == false)
//		{
//			switch (intScene)
//			{
//			case 0:
//				UseStall ();
//				break;
//			case 1:
//				break;
//			case 2:
//				break;
//			case 3:
//				break;
//			default:
//				break;
//			}
//		}
//		else
//		{
//			switch (intSceneMiddle)
//			{
//			case 0:
//				break;
//			case 1:
//				break;
//			case 2:
//				break;
//			case 3:
//				break;
//			default:
//				break;
//			}
//		}
//	}
//	
//	public void Button3 ()
//	{
//		if (bolMiddle == false)
//		{
//			switch (intScene)
//			{
//			case 0:
//				break;
//			case 1:
//				break;
//			case 2:
//				break;
//			case 3:
//				break;
//			default:
//				break;
//			}
//		}
//		else
//		{
//			switch (intSceneMiddle)
//			{
//			case 0:
//				break;
//			case 1:
//				break;
//			case 2:
//				break;
//			case 3:
//				break;
//			default:
//				break;
//			}
//		}
//	}
//	
//	public void Button4 ()
//	{
//		if (bolMiddle == false)
//		{
//			switch (intScene)
//			{
//			case 0:
//				break;
//			case 1:
//				break;
//			case 2:
//				break;
//			case 3:
//				break;
//			default:
//				break;
//			}
//		}
//		else
//		{
//			switch (intSceneMiddle)
//			{
//			case 0:
//				break;
//			case 1:
//				break;
//			case 2:
//				break;
//			case 3:
//				break;
//			default:
//				break;
//			}
//		}
//	}
//	
//	public void Button5 ()
//	{
//		if (bolMiddle == false)
//		{
//			switch (intScene)
//			{
//			case 0:
//				break;
//			case 1:
//				break;
//			case 2:
//				break;
//			case 3:
//				break;
//			default:
//				break;
//			}
//		}
//		else
//		{
//			switch (intSceneMiddle)
//			{
//			case 0:
//				break;
//			case 1:
//				break;
//			case 2:
//				break;
//			case 3:
//				break;
//			default:
//				break;
//			}
//		}
//	}
//	#endregion // Button Methods
//	
//	public void StartText ()
//	{
//		ChangeDescriptionText ("You wander into public on your first day of whatever and what not.  Unbeknownst to you, a major change" + 
//			"had occurred to your body.");
//		ChangeAnswer1Text ("Continue");
//		ChangeAnswer2Text ("");
//		ChangeAnswer3Text ("");
//		ChangeAnswer4Text ("");
//		ChangeAnswer5Text ("");
//	}
//	public void Bathroom (int localFocus)
//	{
//		if (localFocus == -2)
//		{
//			ChangeDescriptionText ("Out in public.  Must pee.  Race to the nearest restroom.  Without pausing to think you " + 
//				"step into the men's room and hop up to the single urinal.  You unzip and try to take aim, but you " +
//				"realize too late that you are in the wrong restroom.  You have already created a small puddle before " + 
//				"being able to pause.  Extreme embarassment.");
//			ChangeAnswer1Text ("Quickly clean up and leave.");
//			ChangeAnswer2Text ("");
//			ChangeAnswer3Text ("");
//			ChangeAnswer4Text ("");
//			ChangeAnswer5Text ("");
//		}
//		else if (localFocus == -1)
//		{
//			// This is not going to go well..  How do I handle changes?
//			ChangeDescriptionText ("Out in public.  Must pee.  Race to the nearest restroom.  A moments hesitation is all you " + 
//				"needed to think.  Do I use the urinal or the stall?");
//			// Use the urinal.
//			//  Oh crap, you piss on your shoes and your already abysmal focus drains even further.
//			// Use the stall.
//			//  A clutch decision, and a good one at that.  You may be in the wrong room, but at least the stall is peaceful.
//			ChangeAnswer1Text ("Use the urinal.");
//			ChangeAnswer2Text ("Use the stall.");
//			ChangeAnswer3Text ("");
//			ChangeAnswer4Text ("");
//			ChangeAnswer5Text ("");	
//		}
//		else if (localFocus == 0)
//		{
//			ChangeDescriptionText ("Out in public.  Must pee.  Race to the nearest restroom.  A moments hesitation is all you " + 
//				"needed to think.  Do I use the mens or the womens restroom?");
//			// Use the mens.
//			//  Got some funny looks from the guys in the mens room today.  Not sure what their problem was.
//			// Use the womens.
//			//  Entered only to find a line longer than the Wal-mart checkout line during Christmas time.  You wait, and just as you think you can't hold it anymore, it's your turn.
//			ChangeAnswer1Text ("Use the mens room.");
//			ChangeAnswer2Text ("Use the ladies room.");
//			ChangeAnswer3Text ("");
//			ChangeAnswer4Text ("");
//			ChangeAnswer5Text ("");
//		}
//		else if (localFocus == 1)
//		{
//			ChangeDescriptionText ("Out in public.  Must pee.  Race to the nearest restroom.  You quickly head into the wommen's " + 
//				"stall and get down to business.  While sitting there you mumble aloud to yourself about how " +
//				"strange it was that there were trash cans in the stalls.  You could hear the snide snickers from " +
//				"the ladies standing in front of the mirrors.");
//			ChangeAnswer1Text ("Continue");
//			ChangeAnswer2Text ("");
//			ChangeAnswer3Text ("");
//			ChangeAnswer4Text ("");
//			ChangeAnswer5Text ("");
//		}
//		else if (localFocus == 2)
//		{
//			ChangeDescriptionText ("Out in public.  Must pee.  Race to the nearest restroom.  Straight into the womens rooms.  It was " + 
//				"a glorious release.");
//			ChangeAnswer1Text ("Continue");
//			ChangeAnswer2Text ("");
//			ChangeAnswer3Text ("");
//			ChangeAnswer4Text ("");
//			ChangeAnswer5Text ("");
//		}
//		else
//		{
//			// This shouldn't be possible.
//		}
//	}
//	
//	public void UseUrinal ()
//	{
//		ChangeDescriptionText ("Oh crap, you piss on your shoes and your already abysmal focus drains even further.");
//	}
//	
//	public void UseStall ()
//	{
//		ChangeDescriptionText ("A clutch decision, and a good one at that.  You may be in the wrong room, but at least the stall is peaceful.");
//	}
//	
//	public void UseMensRoom ()
//	{
//		ChangeDescriptionText ("Got some funny looks from the guys in the mens room today.  Not sure what their problem was.");
//	}
//	
//	public void UseLadiesRoom ()
//	{
//		ChangeDescriptionText ("Entered only to find a line longer than the Wal-mart checkout line during Christmas time.  You wait, and just as you think you can't hold it anymore, it's your turn.");
//	}
//	#endregion // Methods
//}
