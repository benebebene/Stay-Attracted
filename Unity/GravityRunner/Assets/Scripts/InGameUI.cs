using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class InGameUI : MonoBehaviour
{
    public GameObject gameOverScreen;

    public GameObject pauseMenu;

    public TextMeshProUGUI deathCounter;

    public KeyCode pauseKey = KeyCode.Escape;
    public KeyCode restart = KeyCode.Space;
    
    public static bool isPaused = false;
    public bool isDead = false;
    public bool introRunning = false;

    //----------------------------------------------------------------------------------------------------------------------
    // Game Over Screen Functions
    //----------------------------------------------------------------------------------------------------------------------
    private void GameOver(){
        
        Time.timeScale = 0f;
        gameOverScreen.SetActive(true);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        Dialogue.restarted = true;
        PlayerInventory.numberShards = 0;
        if (PlayerCollision.playerDead == false){
            PlayerInventory.IncreaseDeathCounter();
        }
        PlayerCollision.playerDead = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    //----------------------------------------------------------------------------------------------------------------------
    // Pause Menu Functions
    //----------------------------------------------------------------------------------------------------------------------

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }


    //----------------------------------------------------------------------------------------------------------------------
    // Overall In-Game UI Functions
    //----------------------------------------------------------------------------------------------------------------------

    // Main-Menu Function used by Game Over Screen and Pause Screen
    public void GoToMainMenu()
    {   
        if (isPaused)
        {
            isPaused = false;
        }
        else {
            PlayerCollision.playerDead = false;
        }
        Time.timeScale = 1f;
        PlayerInventory.deathCounter = 0;
        SceneManager.LoadScene("MainMenu");
    }
    

     // Update is called once per frame
    void Update()
    {   
        //Global Variable from the PlayerCollision-Script
        isDead = PlayerCollision.playerDead;

        introRunning = Dialogue.introRunning;

        deathCounter.text = (PlayerInventory.deathCounter).ToString();

        if (isDead == true){
            GameOver();
        }
        if (Input.GetKeyDown(pauseKey))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else if (!isDead && !introRunning)
            {
                PauseGame();
            }
        }

        //restart on spacebar
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if(Input.GetKeyDown(restart) && !introRunning)
        {
            Restart();
        }
        
    }

}

