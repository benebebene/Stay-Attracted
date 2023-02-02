using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Kann bei Game Over be nutzt werden
public class ExplosionItemHandler : MonoBehaviour
{
    void Start()
    {
        PlayerInventory.numberExplosives = 0;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Player")
        {

            PlayerInventory.ExplosiveCollected();
            gameObject.SetActive(false);

        }


    }
}
