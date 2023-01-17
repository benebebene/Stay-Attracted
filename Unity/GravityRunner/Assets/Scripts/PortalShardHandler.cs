using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalShardHandler : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other){
    
        if(other.gameObject.tag == "Player"){

            PlayerInventory.ShardCollected();
            gameObject.SetActive(false);

        }

          
    }
}

