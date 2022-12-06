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
            if (SceneManager.GetActiveScene().buildIndex == 0){
                SceneManager.LoadScene("Level_2");
            }
            else {
                SceneManager.LoadScene("Level_1");
            }
            
        

        }
    }

}
