using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public static bool playerDead = false;

    private void OnCollisionEnter2D(Collision2D coll){
        if ((coll.gameObject.tag =="Enemy") || (coll.gameObject.tag == "Spike"))
        {
            playerDead = true;
            PlayerInventory.IncreaseDeathCounter();
            Debug.Log("DeathCounter:" + PlayerInventory.deathCounter);
            Time.timeScale = 0f;
        }
    }

}
