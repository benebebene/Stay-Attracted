using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler
{    
    private CollisionHandler() { }

    

    // assuming that manageCollision() is called by player
    public static void manageCollision(GameObject self, GameObject other)
    {
        if (self.CompareTag("Player") && (other.CompareTag("Spike") || other.CompareTag("Blob")))
        {
            //LevelHandler.gameOver();
        }
    }

}
