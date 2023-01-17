using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public static int numberShards { get; private set; }

    public static void ShardCollected(){

        numberShards++;
    }
}
