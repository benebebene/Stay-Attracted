using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portalscript : MonoBehaviour
{

    BoxCollider2D portalcollider;


    // Start is called before the first frame update
    void Start()
    {
        portalcollider = GetComponent<BoxCollider2D>();
    }


    private void OnTriggerEnter2D(Collider2D coll){
        if (coll.gameObject.tag =="Player"){
            Debug.Log("Next level");
            Debug.Log(SceneManager.GetActiveScene().buildIndex);


            // Load Level 1
            if (SceneManager.GetActiveScene().buildIndex == 1){
                SceneManager.LoadScene("Level_2");
            }
            // Load Level 2
            if (SceneManager.GetActiveScene().buildIndex == 2){
                SceneManager.LoadScene("Level_3");
            }
            // Load Level 3
            if (SceneManager.GetActiveScene().buildIndex == 3){
                SceneManager.LoadScene("Level_4");
            }
            // Load Level 4
            if (SceneManager.GetActiveScene().buildIndex == 4){
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}
