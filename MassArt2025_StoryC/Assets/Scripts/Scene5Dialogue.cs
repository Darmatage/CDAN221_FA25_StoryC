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
                ChoiceILikeSharks.SetActive(true);
                ChoiceCry.SetActive(true);
                ChoiceEat.SetActive(true);
                nextButton.SetActive(false);
                allowSpace = false;
                
                }

                else if (primeInt == 19){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(true);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "King Principal";
                Char2speech.text = "Why. Were. You. Sent. Here?";
                ChoiceILikeSharks.SetActive(true);
                ChoiceCry.SetActive(true);
                ChoiceEat.SetActive(true);
                nextButton.SetActive(false);
                allowSpace = false;
                
                }

                else if (primeInt == 30){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "King Principal";
                Char2speech.text = "Ok. Name 5 sharks.";
                
                
                }
                else if (primeInt == 31){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Grate white, hammerhed, whale...";
                Char2name.text = "";
                Char2speech.text = "";
                
                
                }
                else if (primeInt == 32){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "King Principal";
                Char2speech.text = "Ok.";
                }
                else if (primeInt == 33){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Red shark, blue shark";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 48; 
                
                
                }
                
                
                

                else if (primeInt == 40){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "King Principal";
                Char2speech.text = "Ew. Stop that.";
                ChoiceILikeSharks.SetActive(false);
                ChoiceCry.SetActive(false);
                ChoiceEat.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;

                }

                else if (primeInt == 41){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "King Principal";
                Char2speech.text = "I said stop.";
                ChoiceILikeSharks.SetActive(false);
                ChoiceCry.SetActive(false);
                ChoiceEat.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;

                }

                else if (primeInt == 42){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "King Principal";
                Char2speech.text = "If you stop crying you can have this candy.";
                ChoiceILikeSharks.SetActive(false);
                ChoiceCry.SetActive(false);
                ChoiceEat.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
                }

                else if (primeInt == 43){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "*Candy added to inventory*";
                Char2name.text = "";
                Char2speech.text = "";
                ChoiceILikeSharks.SetActive(false);
                ChoiceCry.SetActive(false);
                ChoiceEat.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
                }
                else if (primeInt == 44){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Can I have some money too?";
                Char2name.text = "";
                Char2speech.text = "";
                GameHandler.gotMoney = true;
                GameHandler.gotCandy = true;
                }
                else if (primeInt == 45){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "King Principal";
                Char2speech.text = "Why?";
                
                }
                else if (primeInt == 46){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "You made me cry.";
                Char2name.text = "";
                Char2speech.text = "";
                
                }
                else if (primeInt == 47){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "King Principal";
                Char2speech.text = "Ok. \n *5 bucks added to inventory*";
                
                }

                else if (primeInt == 48){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Is that all?";
                Char2name.text = "";
                Char2speech.text = "";
                
                }
                else if (primeInt == 49){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(true);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "King Principal";
                Char2speech.text = "Go back to class.";
                
                
                }
                else if (primeInt == 50){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(true);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "As if...";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                
                SceneBathroom.SetActive(true);
                SceneCafeteria.SetActive(true);
        }
                else if (primeInt == 70){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "King Principal";
                Char2speech.text = "Unbelievable, I can't believe you've done this. Unacceptable. Treason even.";
                
                
                
        }
        else if (primeInt == 71){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Mmmmmm yummy pens";
                Char2name.text = "";
                Char2speech.text = "";
                
                
                
        }
        else if (primeInt == 72){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(true);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "King Principal";
                Char2speech.text = "Detention.";
                
                
                
        }
        else if (primeInt == 73){
                SceneManager.LoadScene("EndLose");
        }
       
       
      
  

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void ChoiceILikeSharksFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I like sharks";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29; 
                ChoiceILikeSharks.SetActive(false);
                ChoiceCry.SetActive(false);
                ChoiceEat.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void ChoiceCryFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "[You cry and get a bunch of snot all over your face]";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 39; 
                ChoiceILikeSharks.SetActive(false);
                ChoiceCry.SetActive(false);
                ChoiceEat.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
            public void ChoiceEatFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "[You eat all of his pens. The red ones don't taste like cherry... and you are still hungry.]";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 69; 
                ArtChar1b.SetActive(false);
                ArtChar1a.SetActive(false);
                ArtChar1c.SetActive(true);
                ArtChar1d.SetActive(false);
                ChoiceILikeSharks.SetActive(false);
                ChoiceCry.SetActive(false);
                ChoiceEat.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
                SceneBathroom.SetActive(false);
                SceneCafeteria.SetActive(false);
        }
        
           

        public void SceneBathroomFunct(){
               SceneManager.LoadScene("Scene8");
        }
        public void SceneCafeteriaFunct(){
                SceneManager.LoadScene("Scene7b");
        }
              
}