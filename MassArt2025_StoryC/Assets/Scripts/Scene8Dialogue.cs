using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene8Dialogue : MonoBehaviour {
// These are the script variables.
// For more character images / buttons, copy & renumber the variables:
        public int primeInt = 1;        // This integer drives game progress!
        public TMP_Text Char1name;      //YOU
        public TMP_Text Char1speech;
        public TMP_Text Char2name;      //teenager
        public TMP_Text Char2speech;
       public TMP_Text Char3name;       //bully
       public TMP_Text Char3speech;
        
        public GameObject DialogueDisplay;
        
        public GameObject ArtChar2a; // teenager
        public GameObject ArtChar2b;
        public GameObject ArtChar2c;
        public GameObject ArtChar2d;
        public GameObject ArtChar2e;

        public GameObject ArtChar3a; // bully
        public GameObject ArtChar3b;
        public GameObject ArtChar3c;
        public GameObject ArtChar3d;
        public GameObject ArtChar3e;
        public GameObject ArtChar3f;
        public GameObject ArtChar3g;
        public GameObject ArtChar3h;

        public GameObject ArtItem1a;
        public GameObject ArtItem2a;

//public GameObject ArtChar2;
        public GameObject ArtBG1;
                public GameObject Choice1a;     
                public GameObject Choice1b;     
                public GameObject Choice1c;      
     

        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextScene3Button;
        public GameObject NextScene4Button;
	public GameObject NextScene5Button;
        
        public GameObject nextButton;
       //public AudioSource audioSource1;
        private bool allowSpace = true;

// Set initial visibility. Added images or buttons need to also be SetActive(false);
        void Start(){                       
             DialogueDisplay.SetActive(false);
             
             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
             Choice1c.SetActive(false);

             ArtChar2a.SetActive(false);
             ArtChar2b.SetActive(false);
             ArtChar2c.SetActive(false);
             ArtChar2d.SetActive(false);
             ArtChar2e.SetActive(false);
             
             ArtChar3a.SetActive(false);
             ArtChar3b.SetActive(false);
             ArtChar3c.SetActive(false);
             ArtChar3d.SetActive(false);
             ArtChar3e.SetActive(false);
             ArtChar3f.SetActive(false);
             ArtChar3g.SetActive(false);
             ArtChar3h.SetActive(false);

             ArtItem1a.SetActive(false);
             ArtItem2a.SetActive(false);

             NextScene1Button.SetActive(false);
             NextScene2Button.SetActive(false);
             NextScene3Button.SetActive(false);
             NextScene4Button.SetActive(false);
	     NextScene5Button.SetActive(false);

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
                Char1speech.text = "(Finally... now I just have to find my favorite toilet.)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                
                Char1name.text = "YOU";
                Char1speech.text = "(What is that sme-)";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);

        }
        else if (primeInt == 4){
               
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "(WHO)";
                Char2name.text = "";
                Char2speech.text = "";
                
        }
       else if (primeInt == 5){
                Char1name.text = "YOU";
                Char1speech.text = "(WHO IS)";
                Char2name.text = "";
                Char2speech.text = "";
                
        }
        else if (primeInt == 6){
                Char1name.text = "YOU";
                Char1speech.text = "(WHO IS THAT!)";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off the "Next" button, turn on "Choice" buttons
                

        }
          else if (primeInt == 7){
                ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Teenager";
                Char2speech.text = "Yo man, you got a light?";
                // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                
                Choice1b.SetActive(true); // function Choice1bFunct()
                Choice1c.SetActive(true); // function Choice1cFunct()
                if (GameHandler.gotLighter == true){
			Choice1a.SetActive(true);// function Choice1aFunct()
		}
                else{
                        Choice1a.SetActive(false);
                }
        }
		
		
        else if (primeInt == 50){
                ArtChar3a.SetActive(true);
                ArtChar2d.SetActive(false);
                ArtChar2e.SetActive(false);
                ArtItem1a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = ""; 
                Char3name.text = "Bully";
                Char3speech.text = "Aren't you the twerp that I took milk from?";
        }
        else if (primeInt == 51){
               
                Char1name.text = "YOU";
                Char1speech.text = "Give me my milk back.";
                Char2name.text = "";
                Char2speech.text = ""; 
                Char3name.text = "";
                Char3speech.text = "";
        }

        else if (primeInt == 52){
                ArtChar3a.SetActive(false);
                ArtChar3b.SetActive(true);

                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = ""; 
                Char3name.text = "Bully";
                Char3speech.text = "NO!";
        }

        else if (primeInt == 53){
                ArtChar3b.SetActive(false);
                ArtChar3e.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = ""; 
                Char3name.text = "Bully";
                Char3speech.text = "And...";
        }
        else if (primeInt == 54){
              
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = ""; 
                Char3name.text = "Bully";
                Char3speech.text = "And... I'm gonna beat you up again";
        }
        else if (primeInt == 55){
                ArtChar3e.SetActive(false);
                ArtChar3g.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Teenager";
                Char2speech.text = "Nah man..."; 
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 56){
                ArtChar3g.SetActive(false);
                ArtChar3d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Teenager";
                Char2speech.text = "You're gonna give this kid his milk back..."; 
                Char3name.text = "";
                Char3speech.text = "";
                NextScene3Button.SetActive(true);
                nextButton.SetActive(false);
                allowSpace = false;    
        }


//WIN

        else if (primeInt == 60){
                ArtChar3a.SetActive(true);
                ArtChar2d.SetActive(false);
               
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = ""; 
                Char3name.text = "Bully";
                Char3speech.text = "Aren't you the twerp that I took milk from?";
        }
        else if (primeInt == 61){
                
                Char1name.text = "YOU";
                Char1speech.text = "Give me my milk back.";
                Char2name.text = "";
                Char2speech.text = ""; 
                Char3name.text = "";
                Char3speech.text = "";
        }

        else if (primeInt == 62){
                ArtChar3a.SetActive(false);
                ArtChar3b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = ""; 
                Char3name.text = "Bully";
                Char3speech.text = "NO!";
        }

        else if (primeInt == 63){
                ArtChar3b.SetActive(false);
                ArtChar3e.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = ""; 
                Char3name.text = "Bully";
                Char3speech.text = "And...";
        }
        else if (primeInt == 64){
                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = ""; 
                Char3name.text = "Bully";
                Char3speech.text = "And... I'm gonna beat you up again";
        }
        else if (primeInt == 65){
                ArtChar3e.SetActive(false);
                ArtChar3a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Teenager";
                Char2speech.text = "That runt kicked me in the balls! Lets get him!"; 
                Char3name.text = "";
                Char3speech.text = "";
                NextScene4Button.SetActive(true);
                nextButton.SetActive(false);
                allowSpace = false;
        }


//Lose


        else if (primeInt == 70){
                ArtChar3a.SetActive(true);
                ArtChar2c.SetActive(false);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = ""; 
                Char3name.text = "Bully";
                Char3speech.text = "Aren't you the twerp that I took milk from?";
        }
        else if (primeInt == 71){
                
                Char1name.text = "YOU";
                Char1speech.text = "Give me my milk back.";
                Char2name.text = "";
                Char2speech.text = ""; 
                Char3name.text = "";
                Char3speech.text = "";
        }

        else if (primeInt == 72){
                ArtChar3a.SetActive(false);
                ArtChar3b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = ""; 
                Char3name.text = "Bully";
                Char3speech.text = "NO!";
        }

        else if (primeInt == 73){
                ArtChar3b.SetActive(false);
                ArtChar3e.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = ""; 
                Char3name.text = "Bully";
                Char3speech.text = "And...";
        }
        else if (primeInt == 74){
               
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = ""; 
                Char3name.text = "Bully";
                Char3speech.text = "And... I'm gonna beat you up again";
        }
        else if (primeInt == 75){
                ArtChar3e.SetActive(false);
                ArtChar3g.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Teenager";
                Char2speech.text = "Nah man, that's messed up bro. You can't take little dude's milk like that bro."; 
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 76){
                ArtChar3g.SetActive(false);
                ArtChar3d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Teenager";
                Char2speech.text = "Get lost, loser."; 
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 77){
                
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = ""; 
                Char3name.text = "Bully";
                Char3speech.text = "Frick!";
        }
        else if (primeInt == 78){
                ArtChar3d.SetActive(false);
                ArtChar2d.SetActive(true);
                ArtChar2e.SetActive(true);
                ArtItem2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Teenager";
                Char2speech.text = "Here little dude. I got an extra."; 
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 79){
                
                GameHandler.gotMaryJane = true;

                Char1name.text = "YOU";
                Char1speech.text = "(MARY JANE ADDED TO INVENTORY)";
                Char2name.text = "";
                Char2speech.text = ""; 
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene5Button.SetActive(true);
                
        }


//AFTER CHOICE 1:
       // after choice 1a
       else if (primeInt == 20){
                GameHandler.gotLighter = false;
                ArtChar2a.SetActive(false);
                ArtChar2d.SetActive(true);
                ArtChar2e.SetActive(true);
                ArtItem1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Teenager";
                Char2speech.text = "Right on dude! Just what I needed after a long day of studies!";     
                primeInt=49;  
        }
        //After 1b
        else if (primeInt == 30){
                ArtChar2a.SetActive(false);
                ArtChar2d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Teenager";
                Char2speech.text = "Aww what the heck! That kills man!";
                primeInt=59;  
        }
        //After 1c
        else if (primeInt == 40){
                ArtChar2a.SetActive(false);
                ArtChar2c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Teenager";
                Char2speech.text = "Right on dude! That's wicked cool!";
                primeInt=69;  
        }
    }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)

//CHOICE 1:
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Could you use this?";
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
                Char1speech.text = "I CAN'T TALK TO STRANGERS!";
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

    //Scene change
        public void SceneChange1(){
               SceneManager.LoadScene("Scene7");       //Cafeteria
        }

        public void SceneChange2(){
                SceneManager.LoadScene("Scene10");     //Playground
        }
        public void SceneChange3(){
                SceneManager.LoadScene("EndWin");     //WIN
        }
        public void SceneChange4(){
                SceneManager.LoadScene("EndLose");     //LOSE
        }
 	public void SceneChange5(){
               SceneManager.LoadScene("Scene7a");       //Cafeteria7a

}
	}