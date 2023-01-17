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

    public void StartGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
    

    

}






    





