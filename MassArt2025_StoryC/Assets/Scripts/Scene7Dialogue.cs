using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene7Dialogue : MonoBehaviour {
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
       

        public GameObject ArtPizza;
        public GameObject ArtLighter;

        public GameObject ArtBG1;

        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject NextScene1Button;
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
		
		ArtPizza.SetActive(false);
		ArtLighter.SetActive(false);

		ArtBG1.SetActive(true);
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		Choice2a.SetActive(false);
		Choice2b.SetActive(false);
		NextScene1Button.SetActive(false);
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
        if (primeInt == 1){
                // audioSource1.Play();
        }

        else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "I want food";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 3){
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lunch Lady";
                Char2speech.text = "Cafeteria";
        }
        else if (primeInt == 4){
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lunch Lady";
                Char2speech.text = "What do you want.";

                 // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }




//AFTER CHOICE 1a:
        else if (primeInt == 10){
                Char1name.text = "You";
                Char1speech.text = "I'm really hungry. And a bully stole my milk";
                Char2name.text = "";
                Char2speech.text = "";

        }
        else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lunch Lady";
                Char2speech.text = "Ok loser.";
        }
       else if (primeInt == 12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lunch Lady";
                Char2speech.text = "That's $3.99";
                if (GameHandler.gotMoney == true){
                        GameHandler.gotMoney = false;
                }
                //if (GameHandler.moneyAmt >= 4){
                        //GameHandler.moneyAmt -= 3.99f;
                else {
                       primeInt = 14; 
                }

        }

        else if (primeInt == 13){
                Char1name.text = "YOU";
                Char1speech.text = "Here is my money!";
                //Char1speech.text = "Ok. " + GameHandler.moneyAmt + " left over.";
                Char2name.text = "";
                Char2speech.text = "";
        }

        else if (primeInt == 14){
                ArtPizza.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lunch Lady";
                Char2speech.text = "Here's your peetsa";
                primeInt = 59;
                //update stat: 
                GameHandler.gotPizza = true;
        }

        else if (primeInt == 15){
                Char1name.text = "YOU";
                Char1speech.text = "I don't have any money.";
                //Char1speech.text = "I don't have money. I only have " + GameHandler.moneyAmt + " dollars.";
                Char2name.text = "";
                Char2speech.text = "";
        }

        else if (primeInt == 16){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lunch Lady";
                Char2speech.text = "Get lost.";
                primeInt = 59;
        }



// after choice 1b
       else if (primeInt == 20){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lunch Lady";
                Char2speech.text = "Cute. My nephew likes sharks";
        }

        else if (primeInt == 21){
                Char1name.text = "YOU";
                Char1speech.text = "Ok.";
                Char2name.text = "";
                Char2speech.text = "";
        }

       else if (primeInt == 22){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lunch Lady";
                Char2speech.text = "Ok.";
        }

       else if (primeInt == 23){
                Char1name.text = "YOU";
                Char1speech.text = "Ok.";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true); // function Choice2aFunct() I hate your nephew
                Choice2b.SetActive(true); // function Choice2bFunct() do YOU like sharks
        }


//AFTER choice 2a: after "I hate your nephew"
       else if (primeInt == 30){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lunch Lady";
                Char2speech.text = "I like your style.";

               
        }
       else if (primeInt == 31){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lunch Lady";
                Char2speech.text = "Here take this.";
        }

        else if (primeInt == 32){
                Char1name.text = "YOU";
                Char1speech.text = "Thanks, hoe.";
                Char2name.text = "";
                Char2speech.text = "";
        }

       else if (primeInt == 33){
             ArtLighter.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lunch Lady";
                Char2speech.text = "Here.";
                primeInt = 59;
                //update stat: 
                GameHandler.gotLighter = true;
        }

//AFTER choice 2b: after "Ido YOU liek sharks?
         else if (primeInt == 40){

                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lunch Lady";
                Char2speech.text = "Get lost, kid. I don't have time for your nonsense.";
                NextScene1Button.SetActive(true);
                primeInt = 59;
        }
      
  
        else if (primeInt == 60){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                
                Char1name.text = "YOU";
                Char1speech.text = "back to the hallway";
                Char2name.text = "";
                Char2speech.text = "";

                // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true); // function Choice1aFunct()
        }


      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)

//CHOICE 1: 
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Food! Gimme!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 9; 
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I like sharks";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 19; 
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

//CHOICE 2:
         public void Choice2aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I hate your nephew.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 29; 
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "What about you? Do YOU like sharks?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 39; 
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        

         


        public void SceneChange1(){
               SceneManager.LoadScene("Scene2b");
        }

        /*
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2a");
        }
        */
              
}