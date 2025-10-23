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
        //public TMP_Text Char3name;
        //public TMP_Text Char3speech;

        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
        public GameObject ArtChar1c;
        public GameObject ArtChar2a;
        public GameObject ArtChar2b;

       
        

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
                        Char1speech.text = "The Nurses office";
                        Char2name.text = "";
                        Char2speech.text = "";
                }
                else if (primeInt == 2)
                {
                        ArtChar1a.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Gross ass kid";
                        Char2speech.text = "I'm sick AHHHHHHHHHH!!!!!";
                }
                else if (primeInt == 3)
                {
                        ArtChar1a.SetActive(true);
                        Char1name.text = "YOU";
                        Char1speech.text = "Oh he is sick ew";
                        Char2name.text = "";
                        Char2speech.text = "";

                        // Turn off the "Next" button, turn on "Choice" buttons
                        nextButton.SetActive(false);
                        allowSpace = false;
                        Choice1a.SetActive(true); // function Choice1aFunct()
                        Choice1b.SetActive(true); // function Choice1bFunct()
                }




                //AFTER CHOICE 1a:
                else if (primeInt == 10)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Gross Ass Kid";
                        Char2speech.text = "AHHH CHOOO!!!!";

                }
                else if (primeInt == 11)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Gross Ass Kid";
                        Char2speech.text = "Thank u";
                }
                else if (primeInt == 12)
                {
                        Char1name.text = "Nurse";
                        Char1speech.text = "You get a gold star!";
                        Char2name.text = "";
                        Char2speech.text = "";
                }

                else if (primeInt == 13)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Ok I am leave now.";
                        Char2name.text = "";
                        Char2speech.text = "";
                        // Turn off the "Next" button, turn on "Choice" buttons
                        nextButton.SetActive(false);
                        allowSpace = false;
                       // function Choice2aFunct()

                }

        


                // after choice 1b
                else if (primeInt == 20)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Gross Ass Kid";
                        Char2speech.text = "AHHH CHOOO!!!!";
                }

                else if (primeInt == 21)
                {
                        Char1name.text = "Gross Ass Kid";
                        Char1speech.text = "[SNEEZES into your hands]";
                        Char2name.text = "";
                        Char2speech.text = "";
                }

                else if (primeInt == 22)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Gross ass kid";
                        Char2speech.text = "ew";
                }

                else if (primeInt == 23)
                {
                        Char1name.text = "Nurse";
                        Char1speech.text = "ew";
                        Char2name.text = "";
                        Char2speech.text = "";
                        // Turn off the "Next" button, turn on "Scene" button/s
                        nextButton.SetActive(false);
                        allowSpace = false;
                       
                        
                }


                //AFTER choice 2a: after "I hate your nephew"
              


                


      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)

//CHOICE 1: 
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Give him tissues";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 9; 
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
       

//CHOICE 2:
         public void Choice2aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Hold out your hands";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19; 
                
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