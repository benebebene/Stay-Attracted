using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public static int numberShards { get; set; }

    public static int numberExplosives { get; set; }

    public static int deathCounter = 0;



    public static void ShardCollected()
    {
 
        numberShards++;
    }

    public static void ExplosiveCollected()
    {

        numberExplosives++;
        Debug.Log(numberExplosives);
    }

    public static void ExplosiveUsed()
    {

        numberExplosives--;
        Debug.Log(numberExplosives);
    }
  
   
    public static void IncreaseDeathCounter(){
        deathCounter++;
    }
}

