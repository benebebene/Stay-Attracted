using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public static bool playerDead = false;

    private void OnCollisionEnter2D(Collision2D coll){
        if ((coll.gameObject.tag =="Spike") || (coll.gameObject.tag == "Blob") || (coll.gameObject.tag == "Bat") || (coll.gameObject.tag == "Robo")){
            playerDead = true;
            Time.timeScale = 0f;
        }
    }

}
