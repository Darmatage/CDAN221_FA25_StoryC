using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5Dialogue : MonoBehaviour {
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
        public GameObject ArtChar1d;
        
//public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject ChoiceILikeSharks;
        public GameObject ChoiceCry;
        public GameObject ChoiceEat;
        
        public GameObject SceneBathroom;
        public GameObject SceneCafeteria;
        public GameObject nextButton;
       //public AudioSource audioSource1;
        private bool allowSpace = true;

// Set initial visibility. Added images or buttons need to also be SetActive(false);
        void Start(){  
             DialogueDisplay.SetActive(false);
             ArtChar1a.SetActive(false);
             ArtChar1b.SetActive(false);
             ArtChar1c.SetActive(false);
             ArtChar1d.SetActive(false);
        
             ArtBG1.SetActive(true);
             ChoiceILikeSharks.SetActive(false);
             ChoiceCry.SetActive(false);
             ChoiceEat.SetActive(false);

             SceneBathroom.SetActive(false);
             SceneCafeteria.SetActive(false);
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
        if (primeInt == 1){
                // audioSource1.Play();
        }
        else if (primeInt == 2){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "He has been talking for like a million hours now...";
                Char2name.text = "";
                Char2speech.text = "";
                
                }
                else if (primeInt == 3){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "King Principal";
                Char2speech.text = "Blah blah blah iresponsible blah blah blah unthinkable blah blah blah unruly-";
                
                }
                else if (primeInt == 4){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "I wonder what's for lunch today...";
                Char2name.text = "";
                Char2speech.text = "";

                }
                else if (primeInt == 5){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "King Principal";
                Char2speech.text = "HEY! Were you even listening to me?";
                
                }
                else if (primeInt == 6){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Yes?";
                Char2name.text = "";
                Char2speech.text = "";
                
                }
                else if (primeInt == 7){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "King Principal";
                Char2speech.text = "Explain yourself!";
                
                }
                else if (primeInt == 8){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
                
                }
                else if (primeInt == 9){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(true);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "King Principal";
                Char2speech.text = "Why. Were. You. Sent. Here?";
                
                }
       
      
  

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void ChoiceILikeSharksFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I like sharks";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19; 
                ChoiceILikeSharks.SetActive(false);
                ChoiceCry.SetActive(false);
                ChoiceEat.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void ChoiceCryFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "No I don't like you.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 6; 
                ChoiceILikeSharks.SetActive(false);
                ChoiceCry.SetActive(false);
                ChoiceEat.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
            public void ChoiceEatFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah, I guess so.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 12; 
                ArtChar1b.SetActive(true);
                ArtChar1a.SetActive(false);
                ChoiceILikeSharks.SetActive(false);
                ChoiceCry.SetActive(false);
                ChoiceEat.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
           

        public void SceneBathroomFunct(){
               SceneManager.LoadScene("Scene2b");
        }
        public void SceneCafeteriaFunct(){
                SceneManager.LoadScene("Scene2a");
        }
              
}