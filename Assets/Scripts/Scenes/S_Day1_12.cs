using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class S_Day1_12 : MonoBehaviour
{
	#region "Class Variables"
		public GameObject goBackground = null;
		public Sprite sprite1 = null;
		public Sprite sprite2 = null;
		public Sprite sprite3 = null;
		public Sprite sprite4 = null;
		public Sprite sprite5 = null;
	
		public GameObject goChar = null;
		public Sprite spriteChar1 = null;
		public Sprite spriteChar2 = null;
		public Sprite spriteChar3 = null;
		public Sprite spriteChar4 = null;
		public Sprite spriteChar5 = null;
		public Sprite spriteChar6 = null;
	
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
				ChangeDescriptionText ("Walks to school, Enters first class: History\n First Lee Scene \nLee: ‘Sup dude. \n You: 'Sup.");
				ChangeAnswer1Text ("Continue");
				ChangeAnswer2Text (" ");
				//		ChangeAnswer3Text ("");
				//		ChangeAnswer4Text ("");
				//		ChangeAnswer5Text ("");
		}
	
	#region "Button Events"
		public void btnOneEvent ()
		{
				if (cntr == 0) {
						ChangeDescriptionText ("Lee: How late were you up last night? \nYou: Too late, that LOL game took way longer than it should have."); 
						cntr++;
				} else if (cntr == 2) {
						goChar.GetComponent<SpriteRenderer> ().sprite = spriteChar2;
						ChangeDescriptionText ("Lee: Told you not to do that, you missed the COD smackdown last night.\nYou: I’m sorry I like to expand my horizons in games, not just scream into my headset all night. ");
				} else if (cntr == 3) {
						ChangeDescriptionText ("Class then commences and the MP and Lee part\nLunch, introduce love interest\nMP sits down and starts to eat Lee sits down next to him ");
				} else if (cntr == 4) {

						goBackground.GetComponent<SpriteRenderer> ().sprite = sprite2;
						goChar.GetComponent<SpriteRenderer> ().sprite = spriteChar1;
						ChangeDescriptionText ("Lee: Okay, they have to have better food than this overcooked junk\nYou: Meh, it keeps me awake. ");
				} else if (cntr == 5) {
						goChar.GetComponent<SpriteRenderer> ().sprite = spriteChar2;
						ChangeDescriptionText ("Lee: *whispers* Oh shit dude, Sam is right behind you!\nYou:*panic whisper* really?! ");
				} else if (cntr == 6) {
						goChar.GetComponent<SpriteRenderer> ().sprite = spriteChar1;
						ChangeDescriptionText ("Lee: Nah *laughs* dude you seriously need to make a move.\nYou: Dammit Lee give me some time. ");
				} else if (cntr == 7) {
						ChangeDescriptionText ("Lee: Dude it’s been months since you told me, and you still have cold feet.\nYou: Dude you know we have tons of history, what if I fuck it up and all of it goes down the drains. ");
				} else if (cntr == 8) {
						goChar.GetComponent<SpriteRenderer> ().sprite = spriteChar2;
						ChangeDescriptionText ("Lee: Well here is your next shot, *whispers* even though you will miss\nCut to show Sam walking in the hall ");
				} else if (cntr == 9) {
						goChar.GetComponent<SpriteRenderer> ().sprite = spriteChar3;
						ChangeDescriptionText ("You: *sigh* Hey Sam\n Sam: Hey you, you get the chem homework done. ");
				} else if (cntr == 10) {
						goChar.GetComponent<SpriteRenderer> ().sprite = spriteChar4;
						ChangeDescriptionText ("You: No, I got half way done and couldn’t think any more, ended up playing LOL all night.\nSam: Come on MP I can’t keep carrying your ass through school. ");
				} else if (cntr == 11) {
						goChar.GetComponent<SpriteRenderer> ().sprite = spriteChar3;
						ChangeDescriptionText ("You: You do not!\nSam: *laughs* sure I don’t, anyways I got to go to trig, talk to you later. ");
				} else if (cntr == 12) {
						goChar.GetComponent<SpriteRenderer> ().sprite = spriteChar2;
						ChangeDescriptionText ("Sam Walks off\nLee: Missed again.\nYou: I’M SORRY I DON’T THINK WITH MY DICK 24/7. ");
				} else if (cntr == 13) {
						goChar.GetComponent<SpriteRenderer> ().sprite = spriteChar1;
						goBackground.GetComponent<SpriteRenderer> ().sprite = sprite3;
						ChangeDescriptionText ("Lee: Calm down dude, I’m just giving you shit. I will talk to you after school.\nAfter School Lee\nMP: Why does every day feel like it’s killing me slowly. ");
				} else if (cntr == 14) {
						ChangeDescriptionText ("Lee: You just need to relax, party some, maybe work out. That’s where I’m headed, want to go with?\nMP: Dude, you know I don’t like working out with you, you are such a hard ass. ");
				} else if (cntr == 15) {
						goChar.GetComponent<SpriteRenderer> ().sprite = spriteChar3;
						ChangeDescriptionText ("Lee: Fine, have it your way, just remember to chill out. You stress too much.\nMP: I know. ");
				} else if (cntr == 16) {
						goBackground.GetComponent<SpriteRenderer> ().sprite = sprite4;
						goChar.renderer.enabled = false;
						ChangeDescriptionText ("MP goes home\nMP drops off his stuff, opens up his computer, turns on music, and starts playing on his Playstation 3\nWhich game should I pick? ");
						ChangeAnswer1Text ("Dark Souls");
						ChangeAnswer2Text ("Rock Band ");
				} else if (cntr == 17) {
						Debug.Log ("Load Level1Test from Level1Test");
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().AnxietyUp ();
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().FocusDown ();
						Application.LoadLevel ("MP_Day2_1");
				}
				cntr++;
		}
	
		public void btnTwoEvent ()
		{
				if (cntr == 17) {
						Debug.Log ("Load Level2Test from Level1Test");
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().AnxietyDown ();
						if (GameObject.Find ("Character") != null)
								GameObject.Find ("Character").GetComponent<CC_Character> ().FocusUp ();
						Application.LoadLevel ("MP_Day2_1");
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
