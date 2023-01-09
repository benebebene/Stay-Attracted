using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalShardHandler : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
    
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null){
            
            playerInventory.ShardCollected();
            gameObject.SetActive(false);
        }    
    }
}

