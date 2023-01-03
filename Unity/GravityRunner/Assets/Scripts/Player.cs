using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{ 
    Rigidbody2D rb;

    GravityHandler gravityHandler;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gravityHandler = GameObject.Find("GravityHandler").GetComponent<GravityHandler>();
    }

   


    // Update is called once per frame
    void Update()
    {
        float gravityPlayerAngle = Vector2.SignedAngle(new Vector2(transform.up.x, transform.up.y), gravityHandler.gravityUp);
        rb.angularVelocity = 2 * gravityPlayerAngle;
        //print(Vector2.SignedAngle(gravityHandler.gravityUp, new Vector2 (transform.up.x, transform.up.y)));
    }
}
