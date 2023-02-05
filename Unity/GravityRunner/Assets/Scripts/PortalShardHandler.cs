using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalShardHandler : MonoBehaviour
{

    public AudioSource collected;
    void Start()
    {
        PlayerInventory.numberShards = 0;
    }    
    private void OnTriggerEnter2D(Collider2D other){
    
        if(other.gameObject.tag == "Player"){
            collected.Play();
            PlayerInventory.ShardCollected();
            gameObject.SetActive(false);

        }

          
    }
}

