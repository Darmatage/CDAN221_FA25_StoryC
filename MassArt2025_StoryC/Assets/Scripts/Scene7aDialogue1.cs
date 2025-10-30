using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene7aDialogue : MonoBehaviour {
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
        //public GameObject ArtChar1b;
        //public GameObject ArtChar1c;
       

        public GameObject ArtPizza;
        public GameObject ArtLighter;

        public GameObject ArtBG1;

        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice2a;
        public GameObject Choice2b;
	public GameObject Choice3a;
	public GameObject Choice3b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public AudioSource audioSource1;
        private bool allowSpace = true;


// Set initial visibility. Added images or buttons need to also be SetActive(false);
	void Start(){  
		DialogueDisplay.SetActive(false);
		ArtChar1a.SetActive(false);
		//ArtChar1b.SetActive(false);
		//ArtChar1c.SetActive(false);
		
		ArtPizza.SetActive(false);
		ArtLighter.SetActive(false);

		ArtBG1.SetActive(true);
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		Choice2a.SetActive(false);
		Choice2b.SetActive(false);
		Choice3a.SetActive(false);
		Choice3b.SetActive(false);
		NextScene1Button.SetActive(false);
		NextScene2Button.SetActive(false);
		nextButton.SetActive(true);
	}
	void Awake() {
    // Hide art
    if (ArtLighter != null) ArtLighter.SetActive(false);
    if (ArtPizza != null) ArtPizza.SetActive(false);

    // Hide choices
    if (Choice1a != null) Choice1a.SetActive(false);
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
	NextScene2Button.SetActive(false);
        }

        else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "I'm lost now I think.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 3){
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lunch Lady";
                Char2speech.text = "You lost, kid?";
        }
        else if (primeInt == 4){
                ArtChar1a.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "I am.";
                Char2name.text = "";
                Char2speech.text = "";

     	}
        else if (primeInt == 5){
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lunch Lady";
                Char2speech.text = "Oh.";
 	}
        else if (primeInt == 6){
                ArtChar1a.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
 	}
        else if (primeInt == 7){
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lunch Lady";
                Char2speech.text = "...";
 	}
        else if (primeInt == 8){
		ArtLighter.SetActive(true);
                ArtChar1a.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Do you want this.";
                Char2name.text = "";
                Char2speech.text = "";
 	}
        else if (primeInt == 9){
		GameHandler.gaveMaryJane = true;
		ArtLighter.SetActive(false);
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lunch Lady";
                Char2speech.text = "Yes. I want that. Thanks kid.";

        }




//AFTER CHOICE 1a:
        else if (primeInt == 10){
                Char1name.text = "You";
                Char1speech.text = "Ok I wanna go play now";
                Char2name.text = "";
                Char2speech.text = "";
		SceneManager.LoadScene("Scene10"); // Go to Scene 10

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
               // stop the "Next" button and show new choices
    		nextButton.SetActive(false);
   		allowSpace = false;
  		Choice3a.SetActive(true); // Go to Scene 8
		Choice3b.SetActive(true); // Go to Scene 10
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
		ArtLighter.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lunch Lady";
                Char2speech.text = "Here take this.";
        }

        else if (primeInt == 32){
		ArtLighter.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Thanks, hoe.";
                Char2name.text = "";
                Char2speech.text = "";
        }

       else if (primeInt == 33){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lunch Lady";
                Char2speech.text = "Now, get lost twerp.";
                //update stat: 
                GameHandler.gotLighter = true;
		
   		// stop the "Next" button and show new choices
    		nextButton.SetActive(false);
   		allowSpace = false;
  		Choice3a.SetActive(true); // Go to Scene 8
		Choice3b.SetActive(true); // Go to Scene 10

        }

//AFTER choice 2b: after "Ido YOU liek sharks?
         else if (primeInt == 40){

                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Lunch Lady";
                Char2speech.text = "Get lost, kid. I don't have time for your nonsense.";
                primeInt = 59;

               	// stop the "Next" button and show new choices
    		nextButton.SetActive(false);
   		allowSpace = false;
  		Choice3a.SetActive(true); // Go to Scene 8
		Choice3b.SetActive(true); // Go to Scene 10
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

        

         	//CHOICE 3:
	public void Choice3aFunct(){
   		Char1name.text = "YOU";
   		Char1speech.text = "I need to tinkle";
   		Char2name.text = "";
   		Char2speech.text = "";
    		Choice3a.SetActive(false);
    		Choice3b.SetActive(false);
    		SceneManager.LoadScene("Scene8"); // Go to Scene 8
	}

	public void Choice3bFunct(){
  		Char1name.text = "YOU";
    		Char1speech.text = "I want to play now.";
    		Char2name.text = "";
    		Char2speech.text = "";
    		Choice3a.SetActive(false);
    		Choice3b.SetActive(false);
    		SceneManager.LoadScene("Scene10"); // Go to Scene 10
	}


        public void SceneChange1(){
               SceneManager.LoadScene("Scene10");
        }

        /*
        public void SceneChange2(){
                SceneManager.LoadScene("Scene8");
        }
        */
              
}