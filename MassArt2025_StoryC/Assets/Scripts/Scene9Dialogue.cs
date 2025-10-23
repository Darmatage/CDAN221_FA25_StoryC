using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene9Dialogue : MonoBehaviour {
// These are the script variables.
// For more character images / buttons, copy & renumber the variables:
        public int primeInt = 0;        // This integer drives game progress!
        public TMP_Text Char1name;
        public TMP_Text Char1speech;
        public TMP_Text Char2name;
        public TMP_Text Char2speech;
        public TMP_Text Char3name;
        public TMP_Text Char3speech;
        //public TMP_Text Char3name;
        //public TMP_Text Char3speech;

        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
        public GameObject ArtChar1c;
        public GameObject ArtChar2a;
        public GameObject ArtChar2b;
        public GameObject ArtSnot;

       
        

        public GameObject ArtBG1;

        public GameObject Choice1a;
        public GameObject Choice1b;
        
        public GameObject NextSceneBathroom;
        public GameObject NextSceneCafeteria;
        //public GameObject NextScene2Button;
        public GameObject nextButton;
       //public AudioSource audioSource1;
        private bool allowSpace = true;


// Set initial visibility. Added images or buttons need to also be SetActive(false);
	void Start(){  
		DialogueDisplay.SetActive(false);
		ArtChar1a.SetActive(false);
		ArtChar1b.SetActive(false);
		ArtChar1c.SetActive(false);
		ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(false);
                ArtSnot.SetActive(false);
		

		ArtBG1.SetActive(true);
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		
		NextSceneBathroom.SetActive(false);
                NextSceneCafeteria.SetActive(false);
		//NextScene2Button.SetActive(false);
		nextButton.SetActive(true);
	}

// Use the spacebar as a faster "Next" button:
	void Update(){        
		if (allowSpace == true){
			if (Input.GetKeyDown("space")){
				Next();
			}

		// secret debug code: go back 1 Story Unit, if NEXT is visible
			if (Input.GetKeyDown("p")) {
				primeInt -= 2;
					Next();
			}
		}
	}

//Story Units! The main story function.
//Players hit [NEXT] to progress to the next primeInt:
	public void Next(){
		primeInt += 1;
                if (primeInt == 0)
                {
                        // audioSource1.Play();
                }

                else if (primeInt == 1)
                {
                        DialogueDisplay.SetActive(true);
                        Char1name.text = "YOU";
                        Char1speech.text = "Where am I? This looks like...";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "";
                        Char3speech.text = "";
                        
                }
                else if (primeInt == 2)
                {
                        DialogueDisplay.SetActive(true);
                        Char1name.text = "YOU";
                        Char1speech.text = "The nurses office...";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "";
                        Char3speech.text = "";
                }
                else if (primeInt == 3)
                {       
                        ArtChar2a.SetActive(true);
                        DialogueDisplay.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "Nurse";
                        Char3speech.text = "You got beat up bad kid. You trip or something?";
                }
                else if (primeInt == 4)
                {
                        DialogueDisplay.SetActive(true);
                        Char1name.text = "YOU";
                        Char1speech.text = "No. I got beat up.";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "";
                        Char3speech.text = "";
                }
                else if (primeInt == 5)
                {       
                        ArtChar2a.SetActive(true);
                        DialogueDisplay.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "Nurse";
                        Char3speech.text = "Huh. Well if you feel fine you can head out.";
                }
                else if (primeInt == 6)
                {
                        ArtChar2a.SetActive(false);
                        DialogueDisplay.SetActive(true);
                        Char1name.text = "YOU";
                        Char1speech.text = "I have to get my milk back.";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "";
                        Char3speech.text = "";
                }
                else if (primeInt == 7)
                {
                        ArtChar1a.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Gross ass kid";
                        Char2speech.text = "I'm sick AHHHHHHHHHH!!!!!";
                        Char3name.text = "";
                        Char3speech.text = "";
                }
                else if (primeInt == 8)
                {       
                        
                        Char1name.text = "YOU";
                        Char1speech.text = "EW WHAT THE FLIP!";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "";
                        Char3speech.text = "";

                        // Turn off the "Next" button, turn on "Choice" buttons
                        //nextButton.SetActive(false);
                       // allowSpace = false;
                       //Choice1a.SetActive(true); // function Choice1aFunct()
                        //Choice1b.SetActive(true); // function Choice1bFunct()
                }
                else if (primeInt == 9)
                {
                        ArtChar1a.SetActive(false);
                        ArtChar1b.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Gross ass kid";
                        Char2speech.text = "Ah";
                        Char3name.text = "";
                        Char3speech.text = "";
                }
                else if (primeInt == 10)
                {
                        ArtChar1a.SetActive(true);
                        ArtChar1b.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Gross ass kid";
                        Char2speech.text = "Ah...";
                        Char3name.text = "";
                        Char3speech.text = "";
                }
                else if (primeInt == 11)
                {
                        ArtChar1a.SetActive(false);
                        ArtChar1b.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Gross ass kid";
                        Char2speech.text = "Ah...AHHH";
                        Char3name.text = "";
                        Char3speech.text = "";
                }
                else if (primeInt == 12)
                {
                        ArtChar1a.SetActive(true);
                        ArtChar1b.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Gross ass kid";
                        Char2speech.text = "Ah...AHHH...";
                        Char3name.text = "";
                        Char3speech.text = "";
                }
                else if (primeInt == 13)
                {
                        ArtChar1a.SetActive(false);
                        ArtChar1b.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Gross ass kid";
                        Char2speech.text = "Ah...AHHH...AHHHHH";
                        Char3name.text = "";
                        Char3speech.text = "";
                }
                else if (primeInt == 14)
                {
                        ArtChar1a.SetActive(false);
                        ArtChar1b.SetActive(true);
                        Char1name.text = "YOU";
                        Char1speech.text = "I CANT DODGE IT WHAT DO I DO?";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "";
                        Char3speech.text = "";
                        
                        nextButton.SetActive(false);
                        allowSpace = false;
                        Choice1a.SetActive(true); // function Choice1aFunct()
                        Choice1b.SetActive(true); // function Choice1bFunct()
                }
                else if (primeInt == 91)
                {
                        ArtChar1a.SetActive(false);
                        ArtChar1b.SetActive(false);
                        ArtChar1c.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "[He blows his nose into the tissue]";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "";
                        Char3speech.text = "";
                }
                else if (primeInt == 92)
                {
                        ArtChar1a.SetActive(true);
                        ArtChar1b.SetActive(false);
                        ArtChar1c.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Gross ass kid";
                        Char2speech.text = "Thanks.";
                        Char3name.text = "";
                        Char3speech.text = "";
                }
                else if (primeInt == 93)
                {
                        ArtChar1a.SetActive(false);
                        ArtChar2b.SetActive(true);
                        ArtChar1c.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "Nurse";
                        Char3speech.text = "Here kid! That was nice. \n[She sticks a gold star sticker to your shirt]";
                        GameHandler.gotGoldStar = true; 
                }
                else if (primeInt == 94)
                {
                        ArtChar1a.SetActive(false);
                        ArtChar2b.SetActive(false);
                        ArtChar1c.SetActive(false);
                        ArtSnot.SetActive(false);
                        Char1name.text = "YOU";
                        Char1speech.text = "I need to get my milk back.";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "";
                        Char3speech.text = "";
                        nextButton.SetActive(false);
                        allowSpace = false;
                        NextSceneBathroom.SetActive(true);
                        NextSceneCafeteria.SetActive(true);
                }

                 else if (primeInt == 101)
                {
                        ArtChar1a.SetActive(false);
                        ArtChar1b.SetActive(false);
                        ArtChar1c.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "[You hold out your hands and your hand gets filled with the sick ass kid's boogers.]";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "";
                        Char3speech.text = "";
                }
                else if (primeInt == 102)
                {
                        ArtChar1a.SetActive(true);
                        ArtChar1b.SetActive(false);
                        ArtChar1c.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Gross ass kid";
                        Char2speech.text = "Ew.";
                        Char3name.text = "";
                        Char3speech.text = "";
                }
                else if (primeInt == 103)
                {
                        ArtChar1a.SetActive(false);
                        ArtChar2a.SetActive(true);
                        ArtChar1c.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "Nurse";
                        Char3speech.text = "Ew.";
                }
                else if (primeInt == 104)
                {
                        ArtChar1a.SetActive(false);
                        ArtChar2a.SetActive(false);
                        ArtChar1c.SetActive(false);
                        ArtSnot.SetActive(true);
                        Char1name.text = "YOU";
                        Char1speech.text = "*SNOT OBTAINED*";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "";
                        Char3speech.text = "";
                        primeInt = 93;

                        GameHandler.gotSnot = true; 

                }


                //AFTER CHOICE 1a:
              

           

        


                // after choice 1b
               


                //AFTER choice 2a: after "I hate your nephew"
              
//[You hold out your hands and your hand gets filled with the sick ass kid's boogers.]

                


      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)

//CHOICE 1: 
        public void Choice1aFunct(){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Gross ass kid";
                Char2speech.text = "AHHHHHCHOOOOOOOOOOOOOO";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 90; 
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
       

//CHOICE 2:
         public void Choice2aFunct(){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Gross ass kid";
                Char2speech.text = "AHHHHHCHOOOOOOOOOOOOOO";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 100; 
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
      

        

         


        public void SwitchSceneBathroom(){
               SceneManager.LoadScene("Scene8");
        }

        public void SwitchSceneCafeteria(){
               SceneManager.LoadScene("Scene7");
        }

       
       
              
}