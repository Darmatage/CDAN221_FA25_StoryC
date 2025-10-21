using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene10Dialogue : MonoBehaviour {
// These are the script variables.
// For more character images / buttons, copy & renumber the variables:
        public int primeInt = 1;        // This integer drives game progress!
        public TMP_Text Char1name;
        public TMP_Text Char1speech;
        public TMP_Text Char2name;
        public TMP_Text Char2speech;
        public TMP_Text Char3name;
        public TMP_Text Char3speech;
        //public TMP_Text Char4name;
        //public TMP_Text Char4speech;
       //public TMP_Text Char3name;
       //public TMP_Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
        public GameObject ArtChar1c;
        public GameObject ArtChar1d;
        public GameObject ArtChar1e;
        public GameObject ArtChar1f;
        //public GameObject ArtCharteacher;
//public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;

        public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject Choice2c;
        /*

        public GameObject Choice3a;
        public GameObject Choice3b;
        public GameObject Choice3c;
        */
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextScene3Button;
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
             ArtChar1f.SetActive(false);
             //ArtCharteacher.SetActive(false);
             ArtBG1.SetActive(true);
             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
             
        
             Choice2a.SetActive(false);
             Choice2b.SetActive(false);
             Choice2c.SetActive(false);
             /*
             Choice3a.SetActive(false);
             Choice3b.SetActive(false);
             Choice3c.SetActive(false);
             */
             NextScene1Button.SetActive(false);
             NextScene2Button.SetActive(false);
              NextScene3Button.SetActive(false);
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
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "This is it.The playground.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                }
        else if (primeInt == 3){
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BULLY";
                Char2speech.text = "HEY!";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BULLY";
                Char2speech.text = "There you are...";
                Char3name.text = "";
                Char3speech.text = "";
        }

        else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BULLY";
                Char2speech.text = "I'm gonna beat u up again!";
                Char3name.text = "";
                Char3speech.text = "";
        }

       else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "Aw, geez...";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()


        }
      

       // after choice 1a
       else if (primeInt == 20){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(true);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BULLY";
                Char2speech.text = "Shut up loser!!! ";
        }
        else if (primeInt == 21){
                Char1name.text = "YOU";
                Char1speech.text = "You're the loser.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 22){
                Char1name.text = "YOU";
                Char1speech.text = "Now give me back my milk.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 23){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BULLY";
                Char2speech.text = "Come n' get it!";
                 // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true); // function Choice2aFunct()
                Choice2b.SetActive(true); // function Choice2bFunct()
                Choice2c.SetActive(true); // function Choice2bFunct()

        }

// AFTER choice 1b
       else if (primeInt == 30){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(true);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BULLY";
                Char2speech.text = "DAMN YOU AND YOUR FRIKEN' SHARKS!";
        }
         else if (primeInt == 31){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "YOU";
                Char1speech.text = "Uh-oh";
                Char2name.text = "";
                Char2speech.text = "";

                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);    
        }


// AFTER choice 2a
       else if (primeInt == 40){
                if (GameHandler.gotdodgeball == true){
                        Char1name.text = "YOU";
                        Char1speech.text = "Hah! I got this dodgeball from the gym!";
                } 
                else
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Fists up, caveman!";   
                        primeInt=46;
                }
                Char2name.text = "";
                Char2speech.text = "";
        }
         else if (primeInt == 41){
                Char1name.text = "YOU";
                Char1speech.text = "EAT RUBBER!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 42){
                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BULLY";
                Char2speech.text = "ACK! That's not fair!";
        }

       else if (primeInt == 43){
                
                Char1name.text = "YOU";
                Char1speech.text = "All's fair on the playground...";
                Char2name.text = "";
                Char2speech.text = "";
        }


       else if (primeInt == 44){
                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BULLY";
                Char2speech.text = "OW!";
        }

       else if (primeInt == 45){
                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BULLY";
                Char2speech.text = "OW! OW! OW! OW!";
        }

       else if (primeInt == 46){
                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BULLY";
                Char2speech.text = "Here's your milk! I'm telling!";
                 // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);   
        }

//if youdon't have the dodgeball:
       else if (primeInt == 47){
                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BULLY";
                Char2speech.text = "You look weak nerd.";
        }

       else if (primeInt == 48){
                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BULLY";
                Char2speech.text = "This'll be fun...";
                 // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);   
        }



// AFTER choice 2b
       else if (primeInt == 50){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(true);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                
                Char1name.text = "YOU";
                Char1speech.text = "WHHEEEEE";
                Char2name.text = "";
                Char2speech.text = "";
        }

  else if (primeInt == 51){
                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BULLY";
                Char2speech.text = "Hey! Don't ignore me loser!";
  }

         else if (primeInt == 52){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "BULLY";
                Char2speech.text = "Gotcha!";

                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);    
        }


    
      
  

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "NO! I'm going to beat U up!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19; 
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;

                GameHandler.scene1annoyanceAmt += 1;

                if (GameHandler.scene1annoyanceAmt > 3) {
                        ArtChar1c.SetActive(true);
                        ArtChar1a.SetActive(false);
                        primeInt = 29;
                } else {
                        primeInt = 19;
                }
        }

        public void Choice1bFunct() {
                Char1name.text = "YOU";
                Char1speech.text = "I love sharks.";
                Char2name.text = "";
                Char2speech.text = "";
                
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
                        primeInt = 29;

        }



 public void Choice2aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "You're DEAD!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 39; 
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I am going to use the slide!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 49; 
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
            public void Choice2cFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I like sharks soooo much!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }



/*
         public void Choice3aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Whatever gets me out of this class.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 290; 
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                Choice3c.SetActive(false);
                NextScene2Button.SetActive(true);
                nextButton.SetActive(false);
                allowSpace = false;
        }
        public void Choice3bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "[YOU BITE DOWN HARD ON BOOGER KIDS LEG]";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29;
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(true); 
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                Choice3c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
            public void Choice3cFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I like sharks";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29; 
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(true);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                Choice3c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
*/

        public void SceneChange1(){
               SceneManager.LoadScene("EndWin"); //end win-- got yur milk
        }
        public void SceneChange2(){
                SceneManager.LoadScene("EndLose"); //end lose-- nomilk,loseteeth
        }
        public void SceneChange3(){
                SceneManager.LoadScene("Scene2a");
        }
              
}