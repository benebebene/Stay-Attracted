using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameUI : MonoBehaviour
{
    public GameObject gameOverScreen;

    public GameObject pauseMenu;

    public KeyCode pauseKey = KeyCode.Escape;
    public KeyCode restart = KeyCode.Space;
    
    public static bool isPaused = false;
    public bool isDead = false;

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
        SceneManager.LoadScene("MainMenu");
    }
    

     // Update is called once per frame
    void Update()
    {   
        //Global Variable from the PlayerCollision-Script
        isDead = PlayerCollision.playerDead;

        if (isDead == true){
            GameOver();
        }
        if (Input.GetKeyDown(pauseKey))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

        //restart on spacebar
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if(Input.GetKeyDown(restart))
        {
            //Application.LoadLevel(currentScene);
            SceneManager.LoadScene(currentScene);
            ResumeGame();
        }
        
    }

}

