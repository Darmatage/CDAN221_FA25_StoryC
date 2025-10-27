using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameHandler_tree : MonoBehaviour {

      public TMP_Text scoreText;
      public static int playerScore = 0;

      void Start(){
            UpdateScore();
      }

      public void AddScore(int points){
            playerScore += points;
            if (playerScore <0){
                  playerScore = 0;
            }
            UpdateScore();
      }

      void UpdateScore(){
            
            if (SceneManager.GetActiveScene().name == "EndScene") {
                  scoreText.text = "FINAL SCORE: " + playerScore;
            }
            else {
                  scoreText.text = "SCORE: " + playerScore;
            }

            
      }


        public void RestartGame(){
                playerScore = 0;
                SceneManager.LoadScene("CatchGame");
        }

        public void QuitGame(){
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
        }

}