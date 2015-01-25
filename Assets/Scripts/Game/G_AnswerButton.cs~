//using System.Collections;
//using UnityEngine;
//
//public class G_AnswerButton : MonoBehaviour
//{
//	#region "Class Variables"
//	public int intNumber = 0;
//	private GameObject goGameController;
//	#endregion // Class Variables
//	
//	
//	#region "Events"
//	void Start ()
//	{
//		goGameController = GameObject.Find ("GameController");
//	}
//	
//	#region "Mouse Events"
//	void OnMouseDown ()
//	{
//		Debug.Log ("G_AnswerButton OnMouseDown()");
//		if (intNumber == 1)
//		{
//			goGameController.GetComponent<G_GameController> ().Button1 ();
//		}
//		else if (intNumber == 2)
//		{
//			goGameController.GetComponent<G_GameController> ().Button2 ();
//		}
//		else if (intNumber == 3)
//		{
//			goGameController.GetComponent<G_GameController> ().Button3 ();
//		}
//		else if (intNumber == 4)
//		{
//			goGameController.GetComponent<G_GameController> ().Button4 ();
//		}
//		else if (intNumber == 5)
//		{
//			goGameController.GetComponent<G_GameController> ().Button5 ();
//		}
//		else
//		{
//			// It shouldn't be possible to get here.
//		}
//	}
//	#endregion // Mouse Events
//	#endregion // Events
//}
//
////
////using System.Collections;
////using UnityEngine;
////using UnityEngine.UI;
////
////public class G_GameController : MonoBehaviour
////{
////	#region "Class Variables"
////	public Text txtText = null;
////	public Text txtAnswer1 = null;
////	public Text txtAnswer2 = null;
////	public Text txtAnswer3 = null;
////	public Text txtAnswer4 = null;
////	public Text txtAnswer5 = null;
////	
////	//	public Button btnAnswer1 = null;
////	//	public Button btnAnswer2 = null;
////	//	public Button btnAnswer3 = null;
////	//	public Button btnAnswer4 = null;
////	//	public Button btnAnswer5 = null;
////	
////	private GameObject btnAnswer11 = null;
////	private GameObject btnAnswer22 = null;
////	private GameObject btnAnswer33 = null;
////	private GameObject btnAnswer44 = null;
////	private GameObject btnAnswer55 = null;
////	#endregion
////	
////	#region "Events"
////	// Use this for initialization
////	void Start ()
////	{
////		// Unable to properly pull Text fields in through code for some reason.  Doing so in the editor.
////		//btnAnswer1 = GameObject.Find ("Button1");
////		btnAnswer11 = GameObject.Find("Button11");
////		btnAnswer22 = GameObject.Find("Button22");
////		btnAnswer33 = GameObject.Find("Button33");
////		btnAnswer44 = GameObject.Find("Button44");
////		btnAnswer55 = GameObject.Find("Button55");
////	}
////	
////	// Update is called once per frame
////	void Update ()
////	{
////		if (Input.GetKeyDown (KeyCode.Escape) == true)
////		{
////			// TODO Add a messagebox type thing to pop up and ask the player if they want to quit.  If yes, quit to main menu.  If no, return.
////			Debug.Log ("Escape has been pressed.");
////		}
////	}
////	#endregion // Events
////	
////	#region "Methods"
////	private void ChangeAnswer1Text (string localText)
////	{
////		Debug.Log (" changer answer text 1: " + btnAnswer1.onClick.GetPersistentEventCount ().ToString () + "     " + btnAnswer1.onClick.GetPersistentMethodName (0).ToString ());
////		txtAnswer1.text = localText;
////		btnAnswer1.onClick.RemoveAllListeners ();
////		btnAnswer1.onClick.RemoveAllListeners ();
////		Debug.Log (" changer answer text 1: " + btnAnswer1.onClick.GetPersistentEventCount ().ToString () + "     " + btnAnswer1.onClick.GetPersistentMethodName (0).ToString ());
////	}
////	
////	private void ChangeAnswer2Text (string localText)
////	{
////		txtAnswer2.text = localText;
////		btnAnswer2.onClick.RemoveAllListeners ();
////	}
////	
////	private void ChangeAnswer3Text (string localText)
////	{
////		txtAnswer3.text = localText;
////		btnAnswer3.onClick.RemoveAllListeners ();
////	}
////	
////	private void ChangeAnswer4Text (string localText)
////	{
////		txtAnswer4.text = localText;
////		btnAnswer4.onClick.RemoveAllListeners ();
////	}
////	
////	private void ChangeAnswer5Text (string localText)
////	{
////		txtAnswer5.text = localText;
////		btnAnswer5.onClick.RemoveAllListeners ();
////	}
////	
////	private void ChangeDescriptionText (string localText)
////	{
////		txtText.text = localText;
////	}
////	
////	void buttonSetup (Button button)
////	{
////		//Remove the existing events
////		button.onClick.RemoveAllListeners ();
////		//Add your new event using lambda notation
////		button.onClick.AddListener (handleButton);
////	}
////	
////	void handleButton ()
////	{
////		Debug.Log ("Button pressed!");	
////	}
////	
////	public void DoNothing ()
////	{
////		
////	}
////	
////	public void Bathroom (int localFocus)
////	{
////		if (localFocus == -2)
////		{
////			ChangeDescriptionText ("Out in public.  Must pee.  Race to the nearest restroom.  Without pausing to think you " + 
////			                       "step into the men's room and hop up to the single urinal.  You unzip and try to take aim, but you " +
////			                       "realize too late that you are in the wrong restroom.  You have already created a small puddle before " + 
////			                       "being able to pause.  Extreme embarassment.");
////			ChangeAnswer1Text ("");
////			ChangeAnswer2Text ("");
////			ChangeAnswer3Text ("");
////			ChangeAnswer4Text ("");
////			ChangeAnswer5Text ("Quickly clean up and leave.");
////			
////			btnAnswer1.onClick.AddListener (DoNothing);
////			btnAnswer2.onClick.AddListener (DoNothing);
////			btnAnswer3.onClick.AddListener (DoNothing);
////			btnAnswer4.onClick.AddListener (DoNothing);
////			btnAnswer5.onClick.AddListener (DoNothing);
////			
////		}
////		else if (localFocus == -1)
////		{
////			// This is not going to go well..  How do I handle changes?
////			ChangeDescriptionText ("Out in public.  Must pee.  Race to the nearest restroom.  A moments hesitation is all you " + 
////			                       "needed to think.  Do I use the urinal or the stall?");
////			// Use the urinal.
////			//  Oh crap, as you piss on your shoes and your already abysmal focus drains even further.
////			// Use the stall.
////			//  A clutch decision, and a good one at that.  You may be in the wrong room, but at least the stall is peaceful.
////			ChangeAnswer1Text ("");
////			ChangeAnswer2Text ("");
////			ChangeAnswer3Text ("");
////			ChangeAnswer4Text ("Use the urinal.");
////			ChangeAnswer5Text ("Use the stall.");	
////			
////			btnAnswer1.onClick.AddListener (DoNothing);
////			btnAnswer2.onClick.AddListener (DoNothing);
////			btnAnswer3.onClick.AddListener (DoNothing);
////			btnAnswer4.onClick.AddListener (UseUrinal);
////			btnAnswer5.onClick.AddListener (UseStall);
////		}
////		else if (localFocus == 0)
////		{
////			ChangeDescriptionText ("Out in public.  Must pee.  Race to the nearest restroom.  A moments hesitation is all you " + 
////			                       "needed to think.  Do I use the mens or the womens restroom?");
////			// Use the mens.
////			//  Got some funny looks from the guys in the mens room today.  Not sure what their problem was.
////			// Use the womens.
////			//  Entered only to find a line longer than the Wal-mart checkout line during Christmas time.  You wait, and just as you think you can't hold it anymore, it's your turn.
////			ChangeAnswer1Text ("");
////			ChangeAnswer2Text ("");
////			ChangeAnswer3Text ("");
////			ChangeAnswer4Text ("Use the mens room.");
////			ChangeAnswer5Text ("Use the ladies room.");
////			
////			btnAnswer1.onClick.AddListener (DoNothing);
////			btnAnswer2.onClick.AddListener (DoNothing);
////			btnAnswer3.onClick.AddListener (DoNothing);
////			btnAnswer4.onClick.AddListener (UseMensRoom);
////			btnAnswer5.onClick.AddListener (UseLadiesRoom);
////		}
////		else if (localFocus == 1)
////		{
////			ChangeDescriptionText ("Out in public.  Must pee.  Race to the nearest restroom.  You quickly head into the wommen's " + 
////			                       "stall and get down to business.  While sitting there you mumble aloud to yourself about how " +
////			                       "strange it was that there were trash cans in the stalls.  You could hear the snide snickers from " +
////			                       "the ladies standing in front of the mirrors.");
////			ChangeAnswer1Text ("");
////			ChangeAnswer2Text ("");
////			ChangeAnswer3Text ("");
////			ChangeAnswer4Text ("");
////			ChangeAnswer5Text ("Continue");
////			
////			btnAnswer1.onClick.AddListener (DoNothing);
////			btnAnswer2.onClick.AddListener (DoNothing);
////			btnAnswer3.onClick.AddListener (DoNothing);
////			btnAnswer4.onClick.AddListener (DoNothing);
////			btnAnswer5.onClick.AddListener (DoNothing);
////		}
////		else if (localFocus == 2)
////		{
////			ChangeDescriptionText ("Out in public.  Must pee.  Race to the nearest restroom.  Straight into the womens rooms.  It was " + 
////			                       "a glorious release.");
////			ChangeAnswer1Text ("");
////			ChangeAnswer2Text ("");
////			ChangeAnswer3Text ("");
////			ChangeAnswer4Text ("");
////			ChangeAnswer5Text ("Continue");
////			
////			btnAnswer1.onClick.AddListener (DoNothing);
////			btnAnswer2.onClick.AddListener (DoNothing);
////			btnAnswer3.onClick.AddListener (DoNothing);
////			btnAnswer4.onClick.AddListener (DoNothing);
////			btnAnswer5.onClick.AddListener (DoNothing);
////		}
////		else
////		{
////			// This shouldn't be possible.
////		}
////	}
////	
////	public void UseUrinal ()
////	{
////		ChangeDescriptionText ("Oh crap, as you piss on your shoes and your already abysmal focus drains even further.");
////	}
////	
////	public void UseStall ()
////	{
////		ChangeDescriptionText ("A clutch decision, and a good one at that.  You may be in the wrong room, but at least the stall is peaceful.");
////	}
////	
////	public void UseMensRoom ()
////	{
////		ChangeDescriptionText ("Got some funny looks from the guys in the mens room today.  Not sure what their problem was.");
////	}
////	
////	public void UseLadiesRoom ()
////	{
////		ChangeDescriptionText ("Entered only to find a line longer than the Wal-mart checkout line during Christmas time.  You wait, and just as you think you can't hold it anymore, it's your turn.");
////	}
////	#endregion // Methods
////}
