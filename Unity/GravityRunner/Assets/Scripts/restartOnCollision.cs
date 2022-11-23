using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartOnCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D coll){
        if (coll.gameObject.tag =="Player"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if (coll.gameObject.tag != "Player"){
            Destroy(coll.gameObject);
        }
    }
}
