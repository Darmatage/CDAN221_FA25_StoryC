using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2aDialogue : MonoBehaviour {
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
        public GameObject ArtChar2a;
        public GameObject ArtChar2b;
        public GameObject ArtChar2c;
        public GameObject ArtChar2d;
        public GameObject ArtChar2e;
        public GameObject ArtChar2f;
        public GameObject ArtChar2g;

//public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject ChoiceGiveBoogers;
        public GameObject ChoiceDontGiveBoogers;
        public GameObject ChoiceKillHim;
        public GameObject ChoiceGetMoney;
        public GameObject ChoiceILikeSharks;
        public GameObject SceneGym;
        public GameObject SceneLab;
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
             ArtChar2a.SetActive(false);
             ArtChar2b.SetActive(false);
             ArtChar2c.SetActive(false);
             ArtChar2d.SetActive(false);
             ArtChar2e.SetActive(false);
             ArtChar2f.SetActive(false);
             ArtChar2g.SetActive(false);
             ArtBG1.SetActive(true);
             ChoiceGiveBoogers.SetActive(false);
             ChoiceDontGiveBoogers.SetActive(false);
             ChoiceKillHim.SetActive(false);
             ChoiceGetMoney.SetActive(false);
             ChoiceILikeSharks.SetActive(false);
             SceneGym.SetActive(false);
             SceneLab.SetActive(false);
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
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Nobody is in the hallways. Not even that dorky hallmonitor...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 3){
                ArtChar1a.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Hey Booger kid where's your locker?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";

        }
       else if (primeInt == 4){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Booger Kid";
                Char2speech.text = "Thats not my name.";
                Char3name.text = "";
                Char3speech.text = "";
        }

       else if (primeInt == 5){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Booger Kid";
                Char2speech.text = "My locker is right here. Look at this!";
                Char3name.text = "";
                Char3speech.text = "";
        }

        else if (primeInt == 6){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Is that jar filled with your-";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }

       else if (primeInt == 7){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Booger Kid";
                Char2speech.text = "Yup. Isn't it cool?";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 8){
                ArtChar1a.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Booger Kid";
                Char2speech.text = "Here! You can hold it!";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 9){
                ArtChar1a.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Gee. Thanks.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        
        else if (primeInt == 10){
                ArtChar1a.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "???";
                Char3speech.text = "HEY DORKS.";
        }
        else if (primeInt == 11){
                ArtChar2g.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Bully";
                Char3speech.text = "Whats in that Jar? Give it to me.";
         }
        else if (primeInt == 12){
                ArtChar1c.SetActive(true);
                ArtChar2g.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Booger Kid";
                Char2speech.text = "NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO";
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                ChoiceGiveBoogers.SetActive(true);
                ChoiceDontGiveBoogers.SetActive(true);
        }

       

      //after choice 1:
        
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
                Char3speech.text = "HA HA HA! THESE ARE DISGUSTING!";
        
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
                Char3speech.text = "THESE ARE DISGUSTING!";
        
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
                Char3speech.text = "Give me something of yours.";
        
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
                Char1speech.text = "Hey Booger kid. He's Gone.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        
        }

        else if (primeInt == 32){
                ArtChar1b.SetActive(true);
                ArtChar1d.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2f.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Booger Kid";
                Char2speech.text = "HE TOOK YOUR STUFF! WHAT ARE YOU GOING TO DO?";
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                ChoiceKillHim.SetActive(true);
                ChoiceGetMoney.SetActive(true);
                ChoiceILikeSharks.SetActive(true);

        }
        else if (primeInt == 101){
                ArtChar1b.SetActive(true);
                ArtChar1d.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2f.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Booger Kid";
                Char2speech.text = "NO WAY!";
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(true);
                allowSpace = true;
                ChoiceKillHim.SetActive(false);
                ChoiceGetMoney.SetActive(false);
                ChoiceILikeSharks.SetActive(false);

        }
        else if (primeInt == 102){
                ArtChar1b.SetActive(true);
                ArtChar1d.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2f.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Booger Kid";
                Char2speech.text = "HE'S WAY TOO OP!";
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(true);
                allowSpace = true;
                ChoiceKillHim.SetActive(false);
                ChoiceGetMoney.SetActive(false);
                ChoiceILikeSharks.SetActive(false);

        }
        else if (primeInt == 103){
                ArtChar1b.SetActive(true);
                ArtChar1d.SetActive(false);
                ArtChar2c.SetActive(false);
                ArtChar2f.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "I need a weapon then. Like a fork or like a ball or something.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(true);
                allowSpace = true;
                ChoiceKillHim.SetActive(false);
                ChoiceGetMoney.SetActive(false);
                ChoiceILikeSharks.SetActive(false);

                }
        else if (primeInt == 104){
                ArtChar1b.SetActive(false);
                ArtChar1a.SetActive(true);
                ArtChar2c.SetActive(false);
                ArtChar2f.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Booger Kid";
                Char2speech.text = "The Gym has balls.";
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                SceneGym.SetActive(true);
        
        

        }
        else if (primeInt == 111){
                ArtChar1b.SetActive(false);
                ArtChar1a.SetActive(true);
                ArtChar2c.SetActive(false);
                ArtChar2f.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Booger Kid";
                Char2speech.text = "The lunch ladies have a TON of money. Maybe if you ask they'll give you some.";
                Char3name.text = "";
                Char3speech.text = "";
                
                
        
        

        }
        else if (primeInt == 112){
                ArtChar1b.SetActive(false);
                ArtChar1a.SetActive(true);
                ArtChar2c.SetActive(false);
                ArtChar2f.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "If not I can just take some...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                SceneCafeteria.SetActive(true);
                
        
        

        }
        
        else if (primeInt == 121){
                ArtChar1b.SetActive(false);
                ArtChar1a.SetActive(true);
                ArtChar2c.SetActive(false);
                ArtChar2f.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Booger Kid";
                Char2speech.text = "Yes... a shark might be able to help you get your milk back...";
                Char3name.text = "";
                Char3speech.text = "";
                
        }

        else if (primeInt == 122){
                ArtChar1b.SetActive(false);
                ArtChar1a.SetActive(true);
                ArtChar2c.SetActive(false);
                ArtChar2f.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Booger Kid";
                Char2speech.text = "I think the science lab has a shark tank.";
                Char3name.text = "";
                Char3speech.text = "";
                
        }
        else if (primeInt == 123){
                ArtChar1b.SetActive(false);
                ArtChar1a.SetActive(true);
                ArtChar2c.SetActive(false);
                ArtChar2f.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "I like sharks.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                SceneLab.SetActive(true);
                
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
                Char3speech.text = "Then give me something of yours.";
                }



     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void ChoiceGiveBoogersFunct(){
                ArtChar2a.SetActive(true);
                ArtChar2g.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Here! Just leave me alone.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19; // so hitting "NEXT" goes to primeInt==20!
                ChoiceGiveBoogers.SetActive(false);
                ChoiceDontGiveBoogers.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void ChoiceDontGiveBoogersFunct(){
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(true);
                ArtChar2a.SetActive(true);
                ArtChar2g.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "You can't have them. They belong to Booger Kid.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 59; // so hitting "NEXT" goes to primeInt==30!
                ChoiceGiveBoogers.SetActive(false);
                ChoiceDontGiveBoogers.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void ChoiceKillHimFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "We should cut his head off and eat his brains.";
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
                Char1speech.text = "If I can get some money i'll just buy more milk.";
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
        public void SceneGymFunct(){
               SceneManager.LoadScene("Scene3");
        }
        public void SceneLabFunct(){
                SceneManager.LoadScene("Scene4a");
        }
         public void SceneCafeteriaFunct(){
                SceneManager.LoadScene("Scene7");
        }
             
}