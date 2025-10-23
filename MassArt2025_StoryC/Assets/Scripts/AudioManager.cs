using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour {

        public AudioSource MenuMusic;
        public AudioSource GameMusic1;
        public AudioSource EndWin;
        public AudioSource EndLose;
        public AudioSource EndFight;

        private AudioSource theMusic;
        private static float musicTimeStamp = 0.0f;
        public float currentTimeStamp;

        void Awake(){
                //set the music based on the scene
                if ((SceneManager.GetActiveScene().name == "MainMenu"))
                { theMusic = MenuMusic; }
                else if (SceneManager.GetActiveScene().name == "EndLose")
                { theMusic = EndLose; }
                else if (SceneManager.GetActiveScene().name == "EndWin")
                { theMusic = EndWin; }
                else if (SceneManager.GetActiveScene().name == "Scene10")
                { theMusic = EndFight; }
                else
                {
                        theMusic = GameMusic1;
                }

                //set the time and play:
                theMusic.time = musicTimeStamp;
                theMusic.Play();
        }

        void Update(){
               //keep track of timestamp, to auto-call it in the next scene:
               musicTimeStamp = theMusic.time;
               currentTimeStamp = theMusic.time;
        }

//change timestamp (can be called by door code):
        public void SetTimeStamp(){
               musicTimeStamp = theMusic.time;
        }
}