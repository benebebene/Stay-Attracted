using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour
{

    public bool runningTimer;
    public float currentTime;
    public float maxTime;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = maxTime;
        runningTimer = true;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        if (currentTime <= 0){
            runningTimer = false;      
            PlayerCollision.playerDead = true; 
        }
    }
}
