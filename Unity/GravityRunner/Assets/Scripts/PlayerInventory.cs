using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int numberShards { get; private set; }

    public void ShardCollected(){

        numberShards++;
    }
}
