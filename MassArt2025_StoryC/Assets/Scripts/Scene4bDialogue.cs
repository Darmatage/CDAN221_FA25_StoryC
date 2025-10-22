using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4bDialogue : MonoBehaviour {
// These are the script variables.
// For more character images / buttons, copy & renumber the variables:
        public int primeInt = 1;        // This integer drives game progress!
        public TMP_Text Char1name;
        public TMP_Text Char1speech;
        public TMP_Text Char2name;
        public TMP_Text Char2speech;
        public TMP_Text Char3name;
        public TMP_Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ImageChar1a;
        public GameObject ImageChar1b;
        public GameObject ImageChar2a;
        public GameObject ImageChar2b;
        public GameObject ImageChar2c;
        
//public GameObject ArtChar2;
        public GameObject ImageBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice1c;
        public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject Choice3a;
        public GameObject Choice3b;
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
        
             ImageChar1a.SetActive(false);
             ImageChar1b.SetActive(false);
             ImageChar2a.SetActive(false);
             ImageChar2b.SetActive(false);
             ImageChar2c.SetActive(false);
             
             ImageBG1.SetActive(true);
             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
             Choice1c.SetActive(false);
             Choice2a.SetActive(false);
             Choice2b.SetActive(false);
             Choice3a.SetActive(false);
             Choice3b.SetActive(false);
             NextScene1Button.SetActive(false);
             NextScene2Button.SetActive(false);
             NextScene3Button.SetActive(false);
             NextScene4Button.SetActive(false);
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
                if (primeInt == 1)
                {
                        // audioSource1.Play();
                }

                else if (primeInt == 2)
                {
                        ImageChar1a.SetActive(true);
             
                        DialogueDisplay.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "Hall Monitor";
                        Char3speech.text = "Lets see if the legends are true...";
                }
                else if (primeInt == 3)
                {
                        ImageChar1a.SetActive(false);
                        ImageChar2a.SetActive(true);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Breath Kid";
                        Char2speech.text = "...";
                        Char3name.text = "";
                        Char3speech.text = "";
                }
                else if (primeInt == 4)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "... ";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "";
                        Char3speech.text = "";
                }
                else if (primeInt == 5)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "... Hey, Breath Kid";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "";
                        Char3speech.text = "";
                }

                else if (primeInt == 6)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Breath Kid";
                        Char2speech.text = "...";
                        Char3name.text = "";
                        Char3speech.text = "";
                }
                else if (primeInt == 7)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Um, that's a cool eraser fort. Did you make it?";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "";
                        Char3speech.text = "";
                }
                else if (primeInt == 8)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Breath Kid";
                        Char2speech.text = "*nods head*";
                        Char3name.text = "";
                        Char3speech.text = "";
                }
                else if (primeInt == 9)
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Why are you holding your breath? Did something spill in the science closet?";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "";
                        Char3speech.text = "";
                }
                else if (primeInt == 10)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Breath Kid";
                        Char2speech.text = "...";
                        Char3name.text = "";
                        Char3speech.text = "";
                }
                else if (primeInt == 11)
                {
                        ImageChar2c.SetActive(false);
                        ImageChar2a.SetActive(true);
                        Char1name.text = "YOU";
                        Char1speech.text = "What should I do...?";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "";
                        Char3speech.text = "";
                        // Turn off the "Next" button, turn on "Choice" buttons
                        nextButton.SetActive(false);
                        allowSpace = false;
                        Choice1a.SetActive(true); // function Choice1aFunct(): Destroy His eraser fort
                        Choice1b.SetActive(true); // function Choice1bFunct(): Hold your breath
                        Choice1c.SetActive(true); // function Choice1cFunct(): I like sharks!
                }
                
                else if (primeInt == 31)
                {
                        ImageChar2a.SetActive(true);
                        ImageChar2b.SetActive(false);
                        ImageChar2c.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Breath Kid";
                        Char2speech.text = "...";
                        Char3name.text = "";
                        Char3speech.text = "";
                        // Turn off the "Next" button, turn on "Choice" buttons
                        nextButton.SetActive(false);
                        allowSpace = false;
                        Choice2a.SetActive(true); // function Choice1aFunct(): Free Shark
                        Choice2b.SetActive(true); // function Choice1bFunct(): Eat Shark
                }
                 else if (primeInt == 40)
                {
                        ImageChar1a.SetActive(true);
                        ImageChar2a.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "Hall Monitor";
                        Char3speech.text = "Excelsior! You have freed the shark. Perhaps he will repay your kindness in the future.";
                        // Turn off the "Next" button, turn on "Scene" button/s
                        nextButton.SetActive(false);
                        allowSpace = false;
                        NextScene2Button.SetActive(true);
                }
                else if (primeInt == 41)
                {
                        ImageChar1a.SetActive(true);
                 
                        ImageChar2a.SetActive(false);
                        ImageChar2b.SetActive(false);
                        ImageChar2c.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "Hall Monitor";
                        Char3speech.text = "Now where will you go next?";
                        // Turn off the "Next" button, turn on "Choice" buttons
                        nextButton.SetActive(false);
                        allowSpace = false;
                        Choice3a.SetActive(true); // function Choice1aFunct(): Hungry
                        Choice3b.SetActive(true); // function Choice1bFunct(): Tinkle
                }
             
                else if (primeInt == 21)
                {
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Breath Kid";
                        Char2speech.text = "...";
                        Char3name.text = "";
                        Char3speech.text = "";
                        // Turn off the "Next" button, turn on "Scene" button/s
                        nextButton.SetActive(false);
                        allowSpace = false;
                        NextScene1Button.SetActive(true);
                }
               
                else if (primeInt == 51)
                {
                        
                        
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "Hall Monitor";
                        Char3speech.text = "Likewise. Let us feast.";
                        // Turn off the "Next" button, turn on "Scene" button/s
                        nextButton.SetActive(false);
                        allowSpace = false;
                        NextScene2Button.SetActive(true);
                }
                else if (primeInt == 61)
                {
                        
                        
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "Hall Monitor";
                        Char3speech.text = "I have a job to do. Tinkle by yourself.";
                        // Turn off the "Next" button, turn on "Scene" button/s
                        nextButton.SetActive(false);
                        allowSpace = false;
                        NextScene3Button.SetActive(true);
                }
                 else if (primeInt == 101)
                {
                        
                        ImageChar2c.SetActive(true);
                        ImageChar2a.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "Breath Kid";
                        Char2speech.text = "STOP!";
                        Char3name.text = "";
                        Char3speech.text = "";// Turn off the "Next" button, turn on "Scene" button/s
                        
                }
                else if (primeInt == 102)
                {
                        ImageChar1b.SetActive(true);
                        ImageChar2c.SetActive(false);
                        ImageChar2a.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "Hall Monitor";
                        Char3speech.text = "YOU CAN'T DO THAT!";// Turn off the "Next" button, turn on "Scene" button/s
                        
                }
                else if (primeInt == 103)
                {
                        ImageChar1b.SetActive(true);
                        ImageChar2c.SetActive(false);
                        ImageChar2a.SetActive(false);
                        Char1name.text = "";
                        Char1speech.text = "";
                        Char2name.text = "";
                        Char2speech.text = "";
                        Char3name.text = "Hall Monitor";
                        Char3speech.text = "You are coming with me.";// Turn off the "Next" button, turn on "Scene" button/s
                        NextScene4Button.SetActive(true);
                }


      //Please do NOT delete this final bracket that ends the Next() function:
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void Choice1aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "[You raise your hands over your head and prepare to smash Breath Kid's eraser fort.]";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 100; // so hitting "NEXT" goes to primeInt==100!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct()
        {
                Char1name.text = "YOU";
                Char1speech.text = "*After a few seconds you pass out.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 20; // so hitting "NEXT" goes to primeInt==21!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1cFunct(){
                ImageChar2c.SetActive(false);
                ImageChar2b.SetActive(true);
                ImageChar2a.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Breath Kid";
                Char2speech.text = "[Points over at an aquarium on a shelf. There is a small shark swimming inside.]";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 30; // so hitting "NEXT" goes to primeInt==31!
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "*glass shatters. the shark is no longer there";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 39; 
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
                GameHandler.sharkfreed = true;
        }
        public void Choice2bFunct()
        {
                Char1name.text = "";
                Char1speech.text = "*the shark is no longer there.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 101; // so hitting "NEXT" goes to primeInt==41!
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice3aFunct(){
                Char1name.text = "YOU";
                Char1speech.text = "I'm hungry. Let's go get food.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 50; // so hitting "NEXT" goes to primeInt==50!
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice3bFunct()
        {
                Char1name.text = "YOU";
                Char1speech.text = "I need to tinkle";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 60; // so hitting "NEXT" goes to primeInt==61!
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void SceneChange1(){
               SceneManager.LoadScene("Scene9a");
        }
        public void SceneChange2()
        {
                SceneManager.LoadScene("Scene7");
        }
        public void SceneChange3(){
                SceneManager.LoadScene("Scene8a");
        }
        public void SceneChangePrincipal(){
                SceneManager.LoadScene("Scene5");
        }




}