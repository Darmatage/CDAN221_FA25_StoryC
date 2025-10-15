using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour {
// These are the script variables.
// For more character images / buttons, copy & renumber the variables:
        public int primeInt = 0;        // This integer drives game progress!
        public TMP_Text Char1name;
        public TMP_Text Char1speech;
        public TMP_Text Char2name;
        public TMP_Text Char2speech;
        public TMP_Text Char3name;
        public TMP_Text Char3speech;
        public TMP_Text Char4name;
        public TMP_Text Char4speech;
       //public TMP_Text Char3name;
       //public TMP_Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1a;
        public GameObject ArtChar1b;
        public GameObject ArtChar1c;
        public GameObject ArtChar1d;
        public GameObject ArtChar1e;
        public GameObject ArtChar1f;
        public GameObject ArtCharteacher;
//public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice1c;
        public GameObject Choice1d;
        public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject Choice2c;
        public GameObject Choice3a;
        public GameObject Choice3b;
        public GameObject Choice3c;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
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
             ArtCharteacher.SetActive(false);
             ArtBG1.SetActive(true);
             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
             Choice1c.SetActive(false);
             Choice1d.SetActive(false);
             Choice2a.SetActive(false);
             Choice2b.SetActive(false);
             Choice2c.SetActive(false);
             Choice3a.SetActive(false);
             Choice3b.SetActive(false);
             Choice3c.SetActive(false);
             NextScene1Button.SetActive(false);
             NextScene2Button.SetActive(false);
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
                Char1name.text = "You";
                Char1speech.text = "This class is so boring... Miss Smith is talking about that divorce thing again";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                }
        else if (primeInt == 3){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtCharteacher.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Miss Smith";
                Char3speech.text = "—and I barely get ANYTHING from the Alimony—";
                Char4name.text = "";
                Char4speech.text = "";
        }
        else if (primeInt == 4){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtCharteacher.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = "You";
                Char1speech.text = "And that weird kid keeps staring at me..";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
        else if (primeInt == 5){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                //DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Wierd Kid";
                Char2speech.text = "Do you like me?";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
       else if (primeInt ==6){
                Char1name.text = "YOU";
                Char1speech.text = "Bro I dont even know you";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);

        }
       else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Weird Kid";
                Char2speech.text = "Do you like me?";
                // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
                Choice1c.SetActive(true); // function Choice1cFunct()
                Choice1d.SetActive(true); // function Choice1dFunct()
        }

       // after choice 1c
       else if (primeInt == 13){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Booger Kid";
                Char2speech.text = "Wanna see my booger collection?";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true); 
                Choice2b.SetActive(true); 
                Choice2c.SetActive(true); 
               
        }
      

       // after choice 1a
       else if (primeInt == 20){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Weird Kid";
                Char2speech.text = "Well I dont.";
                primeInt = 3; // so hitting "NEXT" goes to primeInt==20!
        }

           // after choice 1c
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
                Char2name.text = "Weird Kid";
                Char2speech.text = "TEACHER! TEACHER! HE'S BEING ANNOYING!!!";
                nextButton.SetActive(true);
                allowSpace = true;
               
        }
         else if (primeInt == 31){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                ArtCharteacher.SetActive(true);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Miss Smith";
                Char3speech.text = "YOU! I FORGET YOUR NAME. GO TO THE PRINCIPALS OFFICE!";
                NextScene1Button.SetActive(true);
                nextButton.SetActive(false);
                allowSpace = false;
               
        }

        else if (primeInt == 191){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(true);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Booger Kid";
                Char2speech.text = "It's in my locker.";
                Choice3a.SetActive(true);
                Choice3b.SetActive(true);
                Choice3c.SetActive(true);
                nextButton.SetActive(false);
                allowSpace = false;
               
        }
      
  

      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I like sharks";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19; 
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                Choice1d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "No I don't like you.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 6; 
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                Choice1d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
            public void Choice1cFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Yeah, I guess so.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 12; 
                ArtChar1b.SetActive(true);
                ArtChar1a.SetActive(false);
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                Choice1d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
            public void Choice1dFunct(){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(true);
                ArtChar1d.SetActive(false);
                Char1name.text = "YOU";
                Char2name.text = "";
                Char1speech.text = "NO I HATE YOU STOP TALKING TO ME";
                Char2speech.text = "";
                primeInt = 29; 
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                Choice1d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

         public void Choice2aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Sure why not.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 190; 
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "No thats gross";
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 6; 
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
            public void Choice2cFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I like sharks";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 190; 
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        

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


        public void SceneChange1(){
               SceneManager.LoadScene("Scene2b");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2a");
        }
              
}