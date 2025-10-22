using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3Dialogue : MonoBehaviour {
// These are the script variables.
// For more character images / buttons, copy & renumber the variables:
        public int primeInt = 1;        // This integer drives game progress!
        public TMP_Text Char1name;      //YOU
        public TMP_Text Char1speech;
        public TMP_Text Char2name;      //th kd
        public TMP_Text Char2speech;
       public TMP_Text Char3name;       //boogr
       public TMP_Text Char3speech;
        
        public GameObject DialogueDisplay;
        
        public GameObject ArtChar1a; // ath kid
        public GameObject ArtChar1b;
        public GameObject ArtChar1c;
        public GameObject ArtChar1d;

        public GameObject ArtChar2a; // booger kid
        public GameObject ArtChar2b;
        public GameObject ArtChar2c;
        public GameObject ArtChar2d;
        public GameObject ArtChar2e;
        public GameObject ArtChar2f;

//public GameObject ArtChar2;
        public GameObject ArtBG1;
                public GameObject Choice1a;     //be my friend?
                public GameObject Choice1b;     // RAGE!
                public GameObject Choice1c;      // I like sharks
        public GameObject Choice2a;     //I'mnot stupid!
        public GameObject Choice2b;      // I like sharks
                public GameObject Choice3a;     //Grte white
                 public GameObject Choice3b;    //hmmrhead
                public GameObject Choice3c;     //wale
                public GameObject Choice3d;     //I don't like sharks anymore
         public GameObject Choice4a;    //I'mhungry
        public GameObject Choice4b;     // I likesharks
        public GameObject Choice4c;     // I aloo need to tinkle 

        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextScene3Button;
        public GameObject NextScene4Button;
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
             
             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
             Choice1c.SetActive(false);

             Choice2a.SetActive(false);
             Choice2b.SetActive(false);

             Choice3a.SetActive(false);
             Choice3b.SetActive(false);
             Choice3c.SetActive(false);
             Choice3d.SetActive(false);

             Choice4a.SetActive(false);
             Choice4b.SetActive(false);
             Choice4c.SetActive(false);

             NextScene1Button.SetActive(false);
             NextScene2Button.SetActive(false);
             NextScene3Button.SetActive(false);
             NextScene4Button.SetActive(false);

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
                Char1speech.text = "Ok. The gym. I need to find a weapon here.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                ArtChar1c.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Athletic Kid";
                Char2speech.text = "HEY! What are you doing on my court?";
                //gameHandler.AddPlayerStat(1);

        }
        else if (primeInt == 4){
               
                DialogueDisplay.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Oh... fignewtons.";
                Char2name.text = "";
                Char2speech.text = "";
                
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Athletic Kid";
                Char2speech.text = "Did you hear me? What are you doing on my court?";
                // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
                Choice1c.SetActive(true); // function Choice1bFunct()
        }

//AFTER CHOICE 1:
       // after choice 1a
       else if (primeInt == 20){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Athletic Kid";
                Char2speech.text = "No. You're smelly and gross and weird and stupid";
                 // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true);
                Choice2b.SetActive(true);
              //  NextScene1Button.SetActive(true);
        }

       // after choice 1b
       else if (primeInt == 30){
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Athletic Kid";
                Char2speech.text = "You've done it now cretin! I'm gonna pummel you!";
        }
       else if (primeInt == 31){
                ArtChar1d.SetActive(false);
                ArtChar1b.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Agh! Not the dodge ball!";
                Char2name.text = "";
                Char2speech.text = "";
                
        }
        else if (primeInt == 32){
                ArtChar1b.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Owwww! My face!";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }
      // after choice 1c
       //goes to 60 


//AFTER CHOICE 2:
       // after choice 2a
       else if (primeInt == 50){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "YOU";
                Char1speech.text = "I'm not stupid!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 51){
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Athletic Kid";
                Char2speech.text = "You've done it now cretin! I'm gonna pummel you!";
        }
       else if (primeInt == 52){
                ArtChar1d.SetActive(false);
                ArtChar1b.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "Agh! Not the dodge ball!";
                Char2name.text = "";
                Char2speech.text = "";
                
        }
        else if (primeInt == 53){
                ArtChar1b.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Owwww! My face!";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       // after choice 2b
       else if (primeInt == 60){
                ArtChar1c.SetActive(false);
                ArtChar1a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Athletic Kid";
                Char2speech.text = "Did you say, sharks?";
        }
        else if (primeInt == 61){
                Char1name.text = "YOU";
                Char1speech.text = "Um... Yeah?";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 62){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Athletic Kid";
                Char2speech.text = "Well...";
        }
        else if (primeInt == 63){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Athletic Kid";
                Char2speech.text = "Well... yeah.";
        }
        else if (primeInt == 64){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Athletic Kid";
                Char2speech.text = "Well... yeah. I like sharks too.";
        }
        else if (primeInt == 65){
                Char1name.text = "YOU";
                Char1speech.text = "Hazzah!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 66){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Athletic Kid";
                Char2speech.text = "What sharks are you into?";    
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                Choice3a.SetActive(true);
                Choice3b.SetActive(true);
                Choice3c.SetActive(true);
                Choice3d.SetActive(true);
              //  NextScene2Button.SetActive(true);
        }
//AFTER CHOICE 3:
       // after choice 3a, 3b,3c
       else if (primeInt == 70){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Athletic Kid";
                Char2speech.text = "I like sand sharks. I think they are cool.";
        }
        else if (primeInt == 71){

                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Athletic Kid";
                Char2speech.text = "Hhm, you're not so bad.";
        }
       else if (primeInt == 72){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Athletic Kid";
                Char2speech.text = "You can come to the gym anytime.";
        }
        else if (primeInt == 73){

                Char1name.text = "YOU";
                Char1speech.text = "Gee. Thanks!";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 74){
                ArtChar1a.SetActive(false);
                ArtChar1c.SetActive(true);

                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Athletic Kid";
                Char2speech.text = "I need to tinkle now. Hold my dodgeball.";
        }
        else if (primeInt == 75){
                ArtChar1c.SetActive(false);
                GameHandler.gotDodgeball = true;
                Char1name.text = "YOU";
                Char1speech.text = "Whew. That could have gone badly.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 76){
                Char1name.text = "YOU";
                Char1speech.text = "Hey, boogerkid. You can come out now.";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 77){
                ArtChar2a.SetActive(true);
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Booger Kid";
                Char3speech.text = "I wasn't hiding you know.";
        }
        else if (primeInt == 78){
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Booger Kid";
                Char3speech.text = "I just don't like the smell of gym sweat too early in the morning.";
        }
        else if (primeInt == 79){
                ArtChar2b.SetActive(false);
                ArtChar2c.SetActive(true);
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Booger Kid";
                Char3speech.text = "Ok we have our weapon. Now what?";
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                Choice4a.SetActive(true);
                Choice4b.SetActive(true);
                Choice4c.SetActive(true);
                //NextScene1Button.SetActive(true);
        }

       // after choice 3b
          

      // after choice 3c
     
      // after choice 3d
       else if (primeInt == 80){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Athletic Kid";
                Char2speech.text = "...";
        }
        else if (primeInt == 81){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Athletic Kid";
                Char2speech.text = "Whatever.";
                primeInt=71;
        }
       

//AFTER CHOICE 4:
       // after choice 4a
       else if (primeInt == 110){
                //gameHandler.AddPlayerStat(1);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Booger Kid";
                Char3speech.text = "Me too.";
        }
       else if (primeInt == 111){
                Char1name.text = "YOU";
                Char1speech.text = "Race you to the cafeteria!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }

       // after choice 4b
       else if (primeInt == 120){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Booger Kid";
                Char3speech.text = "Maybe there's a shark in the science lab.";
        }
       else if (primeInt == 121){
                Char1name.text = "YOU";
                Char1speech.text = "Really?! Race yah!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene3Button.SetActive(true);
        }
      // after choice 4c
       else if (primeInt == 130){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Booger Kid";
                Char3speech.text = "Can we tinkle together?";
        }
       else if (primeInt == 131){
                Char1name.text = "YOU";
                Char1speech.text = "No.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                // Turn off the "Next" button, turn on "Scene" button/s
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene4Button.SetActive(true);
        }


      
      //Please do NOT delete this final bracket that ends the Next() function:
     }






// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)

//CHOICE 1:
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Wanna be my friend.";
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
                Char1speech.text = "Don't tell me where I can't be!";
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
                primeInt = 59; // so hitting "NEXT" goes to primeInt==60!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }


//CHOICE 2:
        public void Choice2aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I'm not stupid!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 49; // so hitting "NEXT" goes to primeInt==50!
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
  
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice2bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I like sharks.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 59; // so hitting "NEXT" goes to primeInt==60!
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);

                nextButton.SetActive(true);
                allowSpace = true;
        }

//CHOICE 3:
        public void Choice3aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Grate Wites are the best!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 69; // so hitting "NEXT" goes to primeInt==70!
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                Choice3c.SetActive(false);
                Choice3d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice3bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Hammerheds are my favorite!";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 69; // so hitting "NEXT" goes to primeInt==80!
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                Choice3c.SetActive(false);
                Choice3d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice3cFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "Wale.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 69; // so hitting "NEXT" goes to primeInt==90!
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                Choice3c.SetActive(false);
                Choice3d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
       public void Choice3dFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I don't like sharks anymore.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 79; // so hitting "NEXT" goes to primeInt==100!
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                Choice3c.SetActive(false);
                Choice3d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }


//CHOICE 4:
        public void Choice4aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I'm Hungry.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 109; // so hitting "NEXT" goes to primeInt==110!
                Choice4a.SetActive(false);
                Choice4b.SetActive(false);
                Choice4c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice4bFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I like sharks.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 119; // so hitting "NEXT" goes to primeInt==120!
                Choice4a.SetActive(false);
                Choice4b.SetActive(false);
                Choice4c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice4cFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I also need to tinkle.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 129; // so hitting "NEXT" goes to primeInt==130!
                Choice4a.SetActive(false);
                Choice4b.SetActive(false);
                Choice4c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }


//sesen change:
        public void SceneChange1(){
               SceneManager.LoadScene("Scene9");       //nures's offie
        }

        public void SceneChange2(){
                SceneManager.LoadScene("Scene7");     //cafeteria 
        }

        public void SceneChange3(){
                SceneManager.LoadScene("Scene4a");      //science lab
        }

        public void SceneChange4(){
                SceneManager.LoadScene("Scene8");      //bathroom
        }

}