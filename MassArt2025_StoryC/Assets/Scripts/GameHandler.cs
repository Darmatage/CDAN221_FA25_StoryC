using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour{



        public static bool gotMaryJane = false;
        public static bool gotCandy = false;
        public static bool gotGoldStar = false;
        public static bool gotSnot = false;
        public static bool gotComputerHardDrive = false;
        public static bool gotDodgeball = false; //GameHandler.gotLighter
        public static bool gotLighter = false; //GameHandler.gotLighter
        public static bool gotPizza = false; //GameHandler.gotPizza
        public static bool gotMoney = false; //GameHandler.gotMoney
        public static float scene1annoyanceAmt = 0f; //GameHandler.moneyAmt
        // public GameObject textGameObject;

        // void Start () { UpdateScore (); }

        void Update(){
        //NOTE: delete this quit functionality when a Pause Menu is added!
                // if (Input.GetKey("escape")){
                //         Application.Quit();
                // }

                // Stat tester:
                //if (Input.GetKey("p")){
                //       Debug.Log("Player Stat = " + playerStat1);
                //}
        }

        // void UpdateScore () {
        //        Text scoreTemp = textGameObject.GetComponent<Text>();
        //        scoreTemp.text = "Score: " + score; }

        public void StartGame(){
                SceneManager.LoadScene("Scene1");
        }

        public void OpenCredits(){
                SceneManager.LoadScene("Credits");
        }

        public void RestartGame(){
                SceneManager.LoadScene("MainMenu");
        }

        public void QuitGame(){
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
        }
}
