using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class MenuHandler : MonoBehaviour
{
    
    //--------------------------------------------
    //MAIN MENU GUI
    //--------------------------------------------
    public static string playGameSceneName = "bene02_easy";

    public void StartGame()
    {
      
        SceneManager.LoadScene(playGameSceneName);
    }

    public void StartTutorial()
    {
     
        SceneManager.LoadScene("01-Gravity");
    }

    public void LevelSelection()
    {

        SceneManager.LoadScene("LevelSelection");
    }
    
    

    

}






    





