using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TreeSpawner : MonoBehaviour {

    // Object variables
    public GameObject treePrefab;
    public GameObject eviltreeprefab;
    public Transform[] spawnPoints;
    private int rangeEnd;
    private Transform spawnPoint;
    public GameObject timeText;
    public GameObject gameOverText;

    // Timing variables
    public float spawnRangeStart = 0.5f;
    public float spawnRangeEnd = 1.2f;

    private float spawnTimer = 0f;
    private float evilSpawnTimer = 0f;
    private float gameTimer = 0f;

    public int gameTime = 20;

    void Start() {
        rangeEnd = spawnPoints.Length - 1;
        gameOverText.SetActive(false);
        UpdateTime();
    }

    void FixedUpdate() {
        float timeToSpawn = Random.Range(spawnRangeStart, spawnRangeEnd);
        float timeToSpawnEvil = Random.Range(spawnRangeStart * 4f, spawnRangeEnd * 4f); // 4x slower

        spawnTimer += Time.fixedDeltaTime;
        evilSpawnTimer += Time.fixedDeltaTime;
        gameTimer += Time.fixedDeltaTime;

        if (spawnTimer >= timeToSpawn) {
            spawnTree();
            spawnTimer = 0f;
        }

        if (evilSpawnTimer >= timeToSpawnEvil) {
            spawnEvilTree();
            evilSpawnTimer = 0f;
        }

        if (gameTimer >= 1f) {
            gameTime -= 1;
            gameTimer = 0f;
            UpdateTime();

            if (gameTime <= 0) {
				gameTime = 0;
				GameHandler.playedCatchGame = true;
				GameHandler.catchGameScore = GameHandler_tree.playerScore;
                SceneManager.LoadScene("Scene6");
            }
        }
    }

    void spawnTree() {
        int SPnum = Random.Range(0, rangeEnd);
        spawnPoint = spawnPoints[SPnum];

        if (gameTime > 0) {
            Instantiate(treePrefab, spawnPoint.position, Quaternion.identity);
        }
    }

    void spawnEvilTree() {
        int SPnum = Random.Range(0, rangeEnd);
        spawnPoint = spawnPoints[SPnum];

        if (gameTime > 0) {
            Instantiate(eviltreeprefab, spawnPoint.position, Quaternion.identity);
        }
    }

    public void UpdateTime() {
        Text timeTextB = timeText.GetComponent<Text>();
        timeTextB.text = "TIME: " + gameTime;
    }
}
