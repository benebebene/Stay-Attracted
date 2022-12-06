using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public GameObject gameOverScreen;

    private void OnTriggerEnter2D(Collider2D coll){
        if ((coll.gameObject.tag =="Spike") || (coll.gameObject.tag == "Blob")){
            Time.timeScale = 0f;
            gameOverScreen.SetActive(true);
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

