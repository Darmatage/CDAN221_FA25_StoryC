using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2bDialogue : MonoBehaviour {
// These are the script variables.
// For more character images / buttons, copy & renumber the variables:
        public int primeInt = 0;        // This integer drives game progress!
        public TMP_Text Char1name;
        public TMP_Text Char1speech;
        public TMP_Text Char2name;
        public TMP_Text Char2speech;
        public TMP_Text Char3name;
        public TMP_Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
        public GameObject ArtChar1c;
        public GameObject ArtChar1d;
        public GameObject ArtChar1e;
        public GameObject ArtChar2a;
        public GameObject ArtChar2b;
        public GameObject ArtChar2c;
        public GameObject ArtChar2d;
        public GameObject ArtChar2e;
        public GameObject ArtChar2f;
        public GameObject ArtChar2g;
        public GameObject ArtChar2h;

//public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject ChoiceGiveMoney;
        public GameObject ChoiceDontGiveMoney;
        public GameObject ChoiceKillHim;
        public GameObject ChoiceGetMoney;
        public GameObject ChoiceILikeSharks;
        public GameObject ScenePrincipal;
        public GameObject SceneLab;
        public GameObject SceneCLab;
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
             ArtChar1e.SetActive(false);
             ArtChar2a.SetActive(false);
             ArtChar2b.SetActive(false);
             ArtChar2c.SetActive(false);
             ArtChar2d.SetActive(false);
             ArtChar2e.SetActive(false);
             ArtChar2f.SetActive(false);
             ArtChar2g.SetActive(false);
             ArtChar2h.SetActive(false);
             ArtBG1.SetActive(true);
             ChoiceGiveMoney.SetActive(false);
             ChoiceDontGiveMoney.SetActive(false);
             ChoiceKillHim.SetActive(false);
             ChoiceGetMoney.SetActive(false);
             ChoiceILikeSharks.SetActive(false);
             ScenePrincipal.SetActive(false);
             SceneLab.SetActive(false);
             SceneCLab.SetActive(false);
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
                      primeInt -= 1;
                      Next();
                 }
             }
        }

//Story Units! The main story function.
//Players hit [NEXT] to progress to the next primeInt:
public void Next(){
        primeInt += 1;
        if (primeInt == 0){
                // audioSource1.Play();
        }
        else if (primeInt == 1){
                ArtChar1a.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Stupid teacher... stupid weird kid...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 2){
                ArtChar1a.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "I don't even know where the principal's office is-";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 3){
                ArtChar1d.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Hall Monitor";
                Char2speech.text = "YOU! STOP RIGHT THERE! YOURE VIOLATING SCHOOL POLICY!";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 4){
                ArtChar1a.SetActive(true);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Im just trying to get to the principal's offi-";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 5){
                ArtChar1a.SetActive(true);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Hall Monitor";
                Char2speech.text = "You are in the hall without a hall pass! That is against the law so I am forced to take you to the PRINCIPAL'S OFFICE!";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 6){
                ArtChar1a.SetActive(true);
                ArtChar1d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "???";
                Char3speech.text = "HEY DORKS.";
        }
        else if (primeInt == 7){
                ArtChar1a.SetActive(false);
                ArtChar1e.SetActive(true);
                ArtChar2g.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Bully";
                Char3speech.text = "Give me your lunch money.";
        }
        else if (primeInt == 8){
                ArtChar1b.SetActive(true);
                ArtChar1e.SetActive(false);
                ArtChar2g.SetActive(false);
                ArtChar2b.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Hall Monitor";
                Char2speech.text = "NO! BAD! YOU ARE BAD!";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 9){
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(true);
                ArtChar2h.SetActive(true);
                ArtChar2b.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 10){
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar2h.SetActive(false);
                ArtChar2g.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Bully";
                Char3speech.text = "Now. Where were we?";
                ChoiceGiveMoney.SetActive(true);
                ChoiceDontGiveMoney.SetActive(true);
                nextButton.SetActive(false);
                allowSpace = false;
        
        }
        else if (primeInt == 20){
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2a.SetActive(false);
                ArtChar2d.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Bully";
                Char3speech.text = "HA HA HA! THANKS FOR THE MONEY LOSER!";
        
        }
        else if (primeInt == 21){
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2b.SetActive(true);
                ArtChar2d.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Bully";
                Char3speech.text = "...";
        
        }
        else if (primeInt == 22){
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2b.SetActive(false);
                ArtChar2e.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Bully";
                Char3speech.text = "THIS ISN'T EVEN ENOUGH TO BUY MILK";
        
        }
        
        
        else if (primeInt == 23){
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2g.SetActive(true);
                ArtChar2e.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Bully";
                Char3speech.text = "Give me something else.";
        
        }

        else if (primeInt == 24){
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2g.SetActive(true);
                ArtChar2e.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "I don't-";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        
        }
        else if (primeInt == 25){
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2g.SetActive(false);
                ArtChar2f.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Bully";
                Char3speech.text = "[PUMMELS YOU TO THE GROUND AND TAKES MILK FROM YOUR POCKET]";
                
        
        }
        else if (primeInt == 26){
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2c.SetActive(true);
                ArtChar2f.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Ow... Give it BACK!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        
        }
        else if (primeInt == 27){
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2g.SetActive(false);
                ArtChar2f.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Bully";
                Char3speech.text = "HAHAHA! YOU'RE SUCH A LOSER! THIS IS MY MILK NOW!";
        
        }
        else if (primeInt == 28){
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2f.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Bully";
                Char3speech.text = "Thanks! Friggin' dorks. HA HA HA ha ha ha... ha";
        
        }
        else if (primeInt == 29){
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2f.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Bully";
                Char3speech.text = "ha";
        
        }
        else if (primeInt == 30){
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2f.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "You're not welcome...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        
        }
        else if (primeInt == 31){
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2f.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Hey... Hall monitor. Are you okay?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                }
        else if (primeInt == 32){
                ArtChar1a.SetActive(true);
                ArtChar1d.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2f.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Hall Monitor";
                Char2speech.text = "I'm fine...my armor protected me from that beast.";
                Char3name.text = "";
                Char3speech.text = "";
        
        }
        else if (primeInt == 33){
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2f.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "I need to get my milk back.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 34){
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2f.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Hall Monitor";
                Char2speech.text = "I think we should tell an adult. What do you think we should do?";
                Char3name.text = "";
                Char3speech.text = "";
                ChoiceKillHim.SetActive(true);
                ChoiceGetMoney.SetActive(true);
                ChoiceILikeSharks.SetActive(true);
                nextButton.SetActive(false);
                allowSpace = false;

        }
        else if (primeInt == 60){
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(false);
                ArtChar2g.SetActive(false);
                ArtChar2e.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Bully";
                Char3speech.text = "Oh yeah?";
                }
        else if (primeInt == 61){
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2g.SetActive(true);
                ArtChar2e.SetActive(false);
                DialogueDisplay.SetActive(true);
                primeInt = 23;
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Bully";
                Char3speech.text = "Then I'm taking something else.";
                }
                else if (primeInt == 101){
                ArtChar1a.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(true);
                ArtChar2g.SetActive(false);
                ArtChar2e.SetActive(false);
                DialogueDisplay.SetActive(true);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Hall Monitor";
                Char2speech.text = "THAT'S ILLEGAL!";
                Char3name.text = "";
                Char3speech.text = "";
                }
                else if (primeInt == 102){
                ArtChar1a.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(true);
                ArtChar2g.SetActive(false);
                ArtChar2e.SetActive(false);
                DialogueDisplay.SetActive(true);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Hall Monitor";
                Char2speech.text = "I'm taking you to the PRINCIPAL'S OFFICE.";
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                ScenePrincipal.SetActive(true);
                }
               //after money option
               else if (primeInt == 111){
                ArtChar1a.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2g.SetActive(false);
                ArtChar2e.SetActive(false);
                DialogueDisplay.SetActive(true);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Hall Monitor";
                Char2speech.text = "How do you get money?";
                Char3name.text = "";
                Char3speech.text = "";
                }
                else if (primeInt == 112){
                ArtChar1a.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2g.SetActive(false);
                ArtChar2e.SetActive(false);
                DialogueDisplay.SetActive(true);
                
                Char1name.text = "YOU";
                Char1speech.text = "My mom makes money on the computer.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                }
                else if (primeInt == 113){
                ArtChar1a.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2g.SetActive(false);
                ArtChar2e.SetActive(false);
                DialogueDisplay.SetActive(true);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Hall Monitor";
                Char2speech.text = "We should go to the computer lab then.";
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                SceneCLab.SetActive(true);
                }
                else if (primeInt == 121){
                ArtChar1a.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2g.SetActive(false);
                ArtChar2e.SetActive(false);
                DialogueDisplay.SetActive(true);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Hall Monitor";
                Char2speech.text = "Hmmm.... A shark would be a powerful mount...";
                Char3name.text = "";
                Char3speech.text = "";
                }
                else if (primeInt == 122){
                ArtChar1a.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2g.SetActive(false);
                ArtChar2e.SetActive(false);
                DialogueDisplay.SetActive(true);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Hall Monitor";
                Char2speech.text = "Assuming you have a license to have a shark.";
                Char3name.text = "";
                Char3speech.text = "";
                
                }
                else if (primeInt == 123){
                ArtChar1a.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2g.SetActive(false);
                ArtChar2e.SetActive(false);
                DialogueDisplay.SetActive(true);
                
                Char1name.text = "YOU";
                Char1speech.text = "I have a shark license.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                
                }
                else if (primeInt == 124){
                ArtChar1a.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2g.SetActive(false);
                ArtChar2e.SetActive(false);
                DialogueDisplay.SetActive(true);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Hall Monitor";
                Char2speech.text = "Awesome! Lets go to the Science Lab then. I heard there's a shark in there.";
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                SceneLab.SetActive(true);
                }

     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void ChoiceGiveMoneyFunct(){
                ArtChar2a.SetActive(true);
                ArtChar2g.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Here! Just leave me alone.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 19; // so hitting "NEXT" goes to primeInt==20!
                ChoiceGiveMoney.SetActive(false);
                ChoiceDontGiveMoney.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void ChoiceDontGiveMoneyFunct(){
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar2a.SetActive(true);
                ArtChar2g.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "You can't have it. It's my lunch money.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 59; // so hitting "NEXT" goes to primeInt==30!
                ChoiceGiveMoney.SetActive(false);
                ChoiceDontGiveMoney.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void ChoiceKillHimFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "We should pull his arms and legs off and kick his body down the stairs.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 100; // so hitting "NEXT" goes to primeInt==30!
                ChoiceKillHim.SetActive(false);
                ChoiceGetMoney.SetActive(false);
                ChoiceILikeSharks.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
                }
        public void ChoiceGetMoneyFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I need more money then i'll just buy some milk.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 110; // so hitting "NEXT" goes to primeInt==30!
                ChoiceKillHim.SetActive(false);
                ChoiceGetMoney.SetActive(false);
                ChoiceILikeSharks.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
                }
        public void ChoiceILikeSharksFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I like sharks.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 120; // so hitting "NEXT" goes to primeInt==30!
                ChoiceKillHim.SetActive(false);
                ChoiceGetMoney.SetActive(false);
                ChoiceILikeSharks.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
                
        }
        public void SceneCLabFunct(){
               SceneManager.LoadScene("Scene6");
        }
        public void SceneLabFunct(){
                SceneManager.LoadScene("Scene4b");
        }
        public void ScenePrincipalFunct(){
                SceneManager.LoadScene("Scene5");
        }

}