using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSpike : MonoBehaviour
{
    Rigidbody2D rb;

    bool introRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        introRunning = Dialogue.introRunning;
        if (introRunning)
        {
            rb.constraints = RigidbodyConstraints2D.FreezePosition;
        }
        else
        {
            rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        }
    }
}
