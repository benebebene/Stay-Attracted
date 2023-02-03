using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SpikeCollision : MonoBehaviour
{
    public AudioSource destroyed;
    private void OnCollisionEnter2D(Collision2D coll){
        
        if (coll.gameObject.tag != "Player" && coll.gameObject.tag != "PortalShard" && coll.gameObject.tag != "Wall" && coll.gameObject.tag != "Spike")
        {
            Destroy(coll.gameObject);
            destroyed.Play();
        }
    }
}
