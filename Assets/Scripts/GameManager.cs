using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject[] cubePrefabs;
    private float SpawnRangeXLeft = -5f;
    private float SpawnRangeXRight = 11f;
    private float SpawnPosY = 7f;
    private float spawnDelay = 1f;
    private float spawnInterval = .2f;

    private float score;

    public bool gameOver = true;
       
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI finalScoreText;
    

    public GameObject gameOverUi;
    public GameObject mainMenuUi;
    public GameObject credits;


    

    // Start is called before the first frame update
    void Start()
    {    
        InvokeRepeating("SpawnCubes", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        AddScore();
        
    }

    void AddScore()
    {
        if (gameOver == false)
        {
            score += Time.deltaTime;
            scoreText.text = "Score: " + Mathf.Round(score * 100) / 100.0;
        }
    }

    void SpawnCubes()
    {  
        if(gameOver == false )
        {
            int cubeIndex = Random.Range(0, cubePrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(SpawnRangeXLeft, SpawnRangeXRight), SpawnPosY, 0);
            Instantiate(cubePrefabs[cubeIndex], spawnPos, transform.rotation);
        }
        
        if(gameOver == true)
        {
            GameOver();
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        gameOverUi.SetActive(false);
        
    }

    
    void GameOver()
    {
        gameOverUi.SetActive(true);
        finalScoreText.text = "Score: " + Mathf.Round(score * 100) / 100.0;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        gameOver = false;
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void Credits()
    {
        credits.SetActive(true);
        mainMenuUi.SetActive(false);
    }

    public void CreditsBack()
    {
        credits.SetActive(false);
        mainMenuUi.SetActive(true);
    }
        
}
