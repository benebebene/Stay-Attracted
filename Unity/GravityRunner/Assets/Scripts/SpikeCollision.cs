using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D coll){
        
        if (coll.gameObject.tag != "Player" && coll.gameObject.tag != "PortalShard")
        {
            Destroy(coll.gameObject);
        }
    }
}
