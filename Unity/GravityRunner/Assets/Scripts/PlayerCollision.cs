using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public GameObject gameOverScreen;

    private void OnCollisionEnter2D(Collision2D coll){
        if ((coll.gameObject.tag =="Spike") || (coll.gameObject.tag == "Blob") || (coll.gameObject.tag == "Bat") || (coll.gameObject.tag == "Robo")){
            Time.timeScale = 0f;
            gameOverScreen.SetActive(true);
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Exit()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}

