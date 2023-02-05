using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public static bool playerDead = false;
    public AudioSource dying_sound;
    public AudioSource collect_sound;
    private void OnCollisionEnter2D(Collision2D coll){
        
        if ((coll.gameObject.tag =="Enemy") || (coll.gameObject.tag == "Spike"))
        {
            playerDead = true;
            PlayerInventory.IncreaseDeathCounter();
            Debug.Log("DeathCounter:" + PlayerInventory.deathCounter);
            Time.timeScale = 0f;
            dying_sound.Play();
        }
        
    }
    private void OnTriggerEnter2D(Collider2D coll){
        if ((coll.gameObject.tag == "PortalShard")){
            collect_sound.Play();
            Debug.Log("shard collission!!!");
        }
    }

}
