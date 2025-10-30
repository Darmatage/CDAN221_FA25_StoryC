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
        public GameObject ArtChar1g;
        public GameObject ArtChar1i;
        public GameObject ArtChar1j;
        public GameObject ArtChar1h;
        public GameObject ArtChar1s;
        public GameObject ArtChar2a;
        public GameObject ArtChar2b;
        public GameObject ArtChar3a;
        //public GameObject ArtCharteacher;
//public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject Choice1c;

        public GameObject Choice2a;
        public GameObject Choice2b;
        public GameObject Choice2c;
        public GameObject Choice2d;
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
             ArtChar1g.SetActive(false);
             ArtChar1h.SetActive(false);
             ArtChar1s.SetActive(false);
             ArtChar2a.SetActive(false);
             ArtChar2b.SetActive(false);
             ArtChar1i.SetActive(false);
        ArtChar1j.SetActive(false);
        ArtChar3a.SetActive(false);
             //ArtCharteacher.SetActive(false);
             ArtBG1.SetActive(true);
             Choice1a.SetActive(false);
             Choice1b.SetActive(false);
             Choice1c.SetActive(false);
             Choice2a.SetActive(false);
             Choice2b.SetActive(false);
             Choice2c.SetActive(false);
             Choice2d.SetActive(false);
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
                Char1speech.text = "This is it.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";

//GameHandler.gotDodgeball = true;
//GameHandler.sharkfreed = true;
//GameHandler.gotSnot = true;
//GameHandler.gaveMaryJane = true;
                
                }
                else if (primeInt == 3){
                
                Char1name.text = "YOU";
                Char1speech.text = "The playground.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                }
                else if (primeInt == 4){
                
                Char1name.text = "YOU";
                Char1speech.text = "This is my last chance to get my milk back.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                }
                else if (primeInt == 5){
                
                Char1name.text = "YOU";
                Char1speech.text = "The Bully is right over there... laughing at a kid who just fell off the swing.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                }
                else if (primeInt == 6){
        
                ArtChar1d.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "HA! Look at that loser he's getting SNOT all over his face!";
                }
                else if (primeInt == 7){
                ArtChar1b.SetActive(true);
                ArtChar1d.SetActive(false);
                ArtChar2a.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Booger Kid";
                Char2speech.text = "STOP LAUGHING AT ME!";
                Char3name.text = "";
                Char3speech.text = "";
                }
                else if (primeInt == 8){
                ArtChar1b.SetActive(false);
                ArtChar1h.SetActive(true);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "BEAT IT LOSER!";
                }
                else if (primeInt == 9){
                ArtChar1d.SetActive(true);
                ArtChar1h.SetActive(false);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "HAHAHAHAHAHAHAHAHA!";
                }
                else if (primeInt == 10){
                ArtChar1a.SetActive(false);
                ArtChar1h.SetActive(false);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "I need to get my milk back...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                }
                else if (primeInt == 11){
                ArtChar1a.SetActive(false);
                ArtChar1h.SetActive(false);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Hey.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                }
                else if (primeInt == 12){
                ArtChar1d.SetActive(true);
                ArtChar1h.SetActive(false);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "HAHAHAHA!";
                }
                else if (primeInt == 13){
                ArtChar1d.SetActive(true);
                ArtChar1h.SetActive(false);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "I don't think he heard me...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                }
                else if (primeInt == 14){
                ArtChar1d.SetActive(false);
                ArtChar1a.SetActive(true);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "HEY!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                }
                else if (primeInt == 15){
                ArtChar1d.SetActive(false);
                ArtChar1a.SetActive(true);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Uh oh... I think I was too loud.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                }
                else if (primeInt == 16){
                ArtChar1g.SetActive(true);
                ArtChar1a.SetActive(false);
                ArtChar2a.SetActive(false);
                ArtChar2b.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "What do you want, dork?";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true);
                Choice1c.SetActive(true);
                }



      

       // after choice 1a
       else if (primeInt == 20){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1e.SetActive(true);
                ArtChar1d.SetActive(false);
                
                ArtChar1f.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "Shut up loser!!! ";
        }
        else if (primeInt == 21){
                Char1name.text = "YOU";
                Char1speech.text = "You're the loser.";
                Char3name.text = "";
                Char3speech.text = "";
                ArtChar1a.SetActive(true);
                ArtChar1e.SetActive(false);
        }
        else if (primeInt == 22){
                Char1name.text = "YOU";
                Char1speech.text = "Now give me back my milk.";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 23){
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "Come n' get it!";


                
                ArtChar1c.SetActive(true);
                ArtChar1a.SetActive(false);
                 // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true); // function Choice2aFunct()
                Choice2b.SetActive(true); // function Choice2bFunct()
                Choice2c.SetActive(true);
                Choice2d.SetActive(true); // function Choice2bFunct()

        }

// AFTER choice 1b
       else if (primeInt == 30){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "You're so annoying with the sharks bro shut up.";
        }
         else if (primeInt == 31){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(true);
                ArtChar1f.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "I like sharks.";
                Char3name.text = "";
                Char3speech.text = "";
   
        }
        else if (primeInt == 32){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1g.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "Im going to beat you up now.";

                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);    
        }


// AFTER choice 2a
       else if (primeInt == 40){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                ArtChar1g.SetActive(false);
                if (GameHandler.gotDodgeball == true){
                        Char1name.text = "YOU";
                        Char1speech.text = "Hah! I got this dodgeball from the gym!";
                } 
                else
                {
                        Char1name.text = "YOU";
                        Char1speech.text = "Lets fight. Pear-head.";   
                        primeInt=46;
                }
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
         else if (primeInt == 41){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                ArtChar1g.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "EAT RUBBER!";
                Char3name.text = "";
                Char3speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 42){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(true);
                ArtChar1f.SetActive(false);
                ArtChar1g.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "OW! That's not fair!";
                Char2name.text = "";
                Char2speech.text = "";
        }

       else if (primeInt == 43){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                ArtChar1g.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "You should have thought about that before you took my milk, pear-head...";
                Char3name.text = "";
                Char3speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }

                
       else if (primeInt == 44){
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                ArtChar1g.SetActive(false);

                ArtChar1i.SetActive(true);
                ArtChar1j.SetActive(false);
                
                
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "OW!";
                Char2name.text = "";
                Char2speech.text = "";
        }

       else if (primeInt == 45){
                
                ArtChar1i.SetActive(false);
                ArtChar1j.SetActive(true);
                
                
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "OW! OW! OW! OW!";
                Char2name.text = "";
                Char2speech.text = "";
        }

       else if (primeInt == 46){

                ArtChar1i.SetActive(false);
                ArtChar1j.SetActive(false);
                
                
                Char1name.text = "YOU";
                Char1speech.text = "[You pelt the bully with the dodgeball until he is knocked out]";
                Char3name.text = "";
                Char3speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                 // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);   
        }

//if youdon't have the dodgeball:
       else if (primeInt == 47){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                ArtChar1g.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "Okay nerd.";
                Char2name.text = "";
                Char2speech.text = "";
        }

       else if (primeInt == 48){
        ArtChar1a.SetActive(false);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                ArtChar1g.SetActive(true);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "This'll be fun...";
                Char2name.text = "";
                Char2speech.text = "";
                 // Turn off the "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);   
        }



// AFTER choice 2b
       else if (primeInt == 50){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                
                Char1name.text = "YOU";
                Char1speech.text = "WHHEEEEE";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }

  else if (primeInt == 51){
                
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "Hey.";
                
  }
  else if (primeInt == 52){
                
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "WHHEEEEE";
                Char3name.text = "";
                Char3speech.text = "";
                
  }
  else if (primeInt == 53){
                
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(true);
                ArtChar1f.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "HEY. GET OFF THAT SLIDE DORK.";
                
                
  }
   else if (primeInt == 54){
                
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "Uh oh... out of slide.";
                Char3name.text = "";
                Char3speech.text = "";
                
                
  }
  else if (primeInt == 55){
                
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                ArtChar1g.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "You have fun?";
                primeInt = 31;
                
  }
  else if (primeInt == 301){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "You're so annoying with the sharks-";
        }
         else if (primeInt == 302){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "What's that noise....?";
   
        }
         else if (primeInt == 303){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                ArtChar1s.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "I like sharks.";
                Char3name.text = "";
                Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);

        }
        else if (primeInt == 401){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                ArtChar1g.SetActive(true);
                Char1name.text = "YOU";
                Char1speech.text = "No one answered....";
                Char3name.text = "";
                Char3speech.text = "";
        
                
                primeInt = 31;

        }
        else if (primeInt == 601){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(true);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "EW GET OFF ME LOSER!";

        }
        else if (primeInt == 602){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                
                Char1name.text = "YOU";
                Char1speech.text = "I thought you might need a hug...";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 31;

        }
        

        else if (primeInt == 621){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(true);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "EW YOU HAVE BOOGERS ON YOUR HANDS!";

        }
        else if (primeInt == 622){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "You got snot all over me...";

        }
        else if (primeInt == 623){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                
                Char1name.text = "YOU";
                Char1speech.text = "Mmmm Boogers.";
                Char3name.text = "";
                Char3speech.text = "";

        }
        else if (primeInt == 623){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(true);
                ArtChar1f.SetActive(false);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "THATS IT.";

        }
        else if (primeInt == 624){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(true);
                ArtChar1f.SetActive(false);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "IM GONNA BEA-";

        }
        else if (primeInt == 625){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "AHCHOO!";

        }
        else if (primeInt == 626){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "Actually... I dont feel so good...";

        }
        else if (primeInt == 627){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "[Drops Dead]";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);   

        }
        else if (primeInt == 801){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "???";
                Char4speech.text = "Whats going on here?";

        }
        else if (primeInt == 802){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar3a.SetActive(true);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "Lunch Lady";
                Char4speech.text = "Was just about to light that bone. Hey is this kid bothering you?";

        }
        else if (primeInt == 803){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar3a.SetActive(true);
                
                Char1name.text = "YOU";
                Char1speech.text = "He took my milk!";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";

        }
        else if (primeInt == 804){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar3a.SetActive(true);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "Lunch Lady";
                Char4speech.text = "Alright kid. Lets get your milk back...";

        }
        else if (primeInt == 805){
                //gameHandler.AddPlayerStat(1);
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                ArtChar3a.SetActive(true);
                
                Char1name.text = "";
                Char1speech.text = "";
                Char3name.text = "BULLY";
                Char3speech.text = "Uh... I want an adult.";
                Char4name.text = "";
                Char4speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);   

        }


        

    
      
  

      //Please do NOT delete this final bracket that ends the Next() function:
     }


        public void Choice1aFunct(){
                
                
                Char1name.text = "YOU";
                Char1speech.text = "I'm going to beat U up!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 19; 
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                ArtChar1g.SetActive(false);
                ArtChar1a.SetActive(true);
                allowSpace = true;

        
        }

        public void Choice1bFunct() {
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                ArtChar1g.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "I like sharks.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
                        
                if (GameHandler.sharkfreed == false){
                     primeInt = 29;   
                }
                else{
                     primeInt = 300;   
                }

        }
        public void Choice1cFunct() {
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                ArtChar1g.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "TEACHER TEACHER! HELP ME BEAT UP THIS BULLY.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
                        
                if (GameHandler.gaveMaryJane == false){
                     primeInt = 400;
                }
                else{
                     primeInt = 800;
                }

}



 public void Choice2aFunct(){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                ArtChar1g.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "You're DEAD!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 39; 
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                Choice2c.SetActive(false);
                Choice2d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                ArtChar1g.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "I am going to use the slide!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 49; 
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                Choice2c.SetActive(false);
                Choice2d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
            public void Choice2cFunct(){
                
                ArtChar1a.SetActive(false);
                ArtChar1b.SetActive(true);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                ArtChar1g.SetActive(false);
                Char1name.text = "YOU";
                Char1speech.text = "I like sharks.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 29;
                
                ArtChar1h.SetActive(false);
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                Choice2c.SetActive(false);
                Choice2d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2dFunct(){
                
                ArtChar1a.SetActive(true);
                ArtChar1b.SetActive(false);
                ArtChar1c.SetActive(false);
                ArtChar1d.SetActive(false);
                ArtChar1e.SetActive(false);
                ArtChar1f.SetActive(false);
                ArtChar1g.SetActive(false);
                
                Char1name.text = "YOU";
                Char1speech.text = "[You give the bully a big hug]";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                  if (GameHandler.gotSnot == false){
                     primeInt = 600;   
                }
                else{
                     primeInt = 620;   
                }
                Choice2d.SetActive(false);
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                Choice2c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }



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