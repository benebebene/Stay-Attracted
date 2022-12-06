using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartOnCollision : MonoBehaviour
{
    public GameObject gameOverScreen;

    private void OnTriggerEnter2D(Collider2D coll){
        if (coll.gameObject.tag =="Player"){
            Time.timeScale = 0f;
            gameOverScreen.SetActive(true);
        }
        else if (coll.gameObject.tag != "Player"){
            Destroy(coll.gameObject);
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
