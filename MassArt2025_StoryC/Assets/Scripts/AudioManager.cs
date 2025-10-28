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
		string thisScene = SceneManager.GetActiveScene().name;
		if ((thisScene == "MainMenu") || (thisScene == "Credits"))
		{
			theMusic = MenuMusic; //39 seconds long
								  
			//check for music clip length problems, to prevent error: "invaid seek position"
			if (musicTimeStamp < theMusic.clip.length)
			{
				//make the music continuous: set time for main menu & credits scenes:
				theMusic.time = musicTimeStamp;
			}
		}
		else if (thisScene == "EndLose")
		{
			theMusic = EndLose; //25 seconds long
		}
		else if (thisScene == "EndWin")
		{
			theMusic = EndWin; //49 seconds long

		}
		else if (thisScene == "Scene10")
		{
			theMusic = EndFight; //46 sconds long
		}
		else
		{
			theMusic = GameMusic1; // 33 seconds long
			//check for music clip length problems, to prevent error: "invaid seek position"
			if (musicTimeStamp < theMusic.clip.length)
			{
				//make the music continuous: set the time for game scenes:
				theMusic.time = musicTimeStamp;
			}
		}

		//play:
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