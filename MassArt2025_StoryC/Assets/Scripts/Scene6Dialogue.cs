using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6Dialogue : MonoBehaviour {   

        public int primeInt = 1;        // This integer drives game progress!
        public TMP_Text Char1name;      //YOU
        public TMP_Text Char1speech;
        public TMP_Text Char2name;    //Hall Monitor  
        public TMP_Text Char2speech;
        public TMP_Text Char3name;    //Jason the comp wiz 
        public TMP_Text Char3speech;
        
        public GameObject DialogueDisplay;
        

        public GameObject ArtChar2a; 
        public GameObject ArtChar2b;
        public GameObject ArtChar2c;
        public GameObject ArtChar2d;
        
        public GameObject ArtChar3a; 
        public GameObject ArtChar3b;

        public GameObject ArtItem1a;

//public GameObject ArtChar2;
        public GameObject ArtBG1;
                public GameObject Choice1a;     
                public GameObject Choice1b;     
                public GameObject Choice1c;
     public GameObject NextScene1Button;
     public GameObject NextScene2Button;
     public GameObject nextButton;
       //public AudioSource audioSource1;
        private bool allowSpace = true;

// Set initial visibility. Added images or buttons need to also be SetActive(false);
        void Start(){  
             DialogueDisplay.SetActive(false);
             ArtChar2a.SetActive(false);
             ArtChar2b.SetActive(false);
             ArtChar2c.SetActive(false);
             ArtChar2d.SetActive(false);

             ArtChar3a.SetActive(false);
             ArtChar3b.SetActive(false);

             ArtItem1a.SetActive(false);

             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
             Choice1c.SetActive(false);


             NextScene1Button.SetActive(false);
             NextScene2Button.SetActive(false);

             ArtBG1.SetActive(true);
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
                Char1speech.text = "The computer wizard is confusing all the kids again.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";

        }
        else if (primeInt == 3){
                ArtChar3a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Jason";
                Char3speech.text = "Okay class, the GAMEHANDLER is the color blue. Does anyone know what it means when a game object is blue in unity?";

        }
        else if (primeInt == 4){
                ArtChar3a.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Everyone is just starting at their computers, most of them are playing Roblox.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";

        }
        else if (primeInt == 5){
                
              ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Hall Monitor";
                Char2speech.text = "I forget why we are here.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 6){
                
                Char1name.text = "YOU";
                Char1speech.text = "Me too.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";

        }
        else if (primeInt == 7){
               
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Hall Monitor";
                Char2speech.text = "Let's play games.";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 8){
                Char1name.text = "YOU";
                Char1speech.text = "Ok.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 9){
               
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Hall Monitor";
                Char2speech.text = "Im bored...";
                Char3name.text = "";
                Char3speech.text = "";
                // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
                Choice1c.SetActive(true); // function Choice1bFunct()
        }
    //AFTER CHOICE 1
         //After Choice 1a

        else if (primeInt == 20){
                ArtChar2a.SetActive(false);
                ArtChar3b.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "WOOOOOO!!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 21){
                ArtItem1a.SetActive(true);
                GameHandler.gotComputerHardDrive = true;
                Char1name.text = "YOU";
                Char1speech.text = "Damn, what a mess...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 22){
                Char1name.text = "YOU";
                Char1speech.text = "(COMPUTER HARD DRIVE ADDED TO INVENTORY)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 23){
                ArtItem1a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Jason";
                Char3speech.text = "...";
        }
        else if (primeInt == 24){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Jason";
                Char3speech.text = "HEY!";
        }
        else if (primeInt == 25){
                ArtChar3b.SetActive(false);
                ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Hall Moniter";
                Char2speech.text = "HEY!";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 26){
                ArtChar2c.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "I need to get the flip out of here!!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
                NextScene2Button.SetActive(true);

        }
        //After choice 1b

        else if (primeInt == 30){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Hall Moniter";
                Char2speech.text = "Me too.";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 31){
             Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Hall Moniter";
                Char2speech.text = "I wonder if it's chiken nuggies today.";
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
        //After choice 1c

        else if (primeInt == 40){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Hall Moniter";
                Char2speech.text = "Ok.";
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); 
                Choice1b.SetActive(true);
        }




    }


// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)

//CHOICE 1:
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "*Jumps on Desk*";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19; // so hitting "NEXT" goes to primeInt==20!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I'm hungry.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29; // so hitting "NEXT" goes to primeInt==30!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice1cFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I like sharks.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 39; // so hitting "NEXT" goes to primeInt==40!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

 //Scene changes

public void SceneChange1(){
                SceneManager.LoadScene("Scene7");     //cafeteria 
        }

public void SceneChange2(){
                SceneManager.LoadScene("Scene8");     //Bathroom
        }




}