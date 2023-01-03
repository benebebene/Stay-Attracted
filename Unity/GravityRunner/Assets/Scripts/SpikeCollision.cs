using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D coll){
        Destroy(coll.gameObject);
    }
}
