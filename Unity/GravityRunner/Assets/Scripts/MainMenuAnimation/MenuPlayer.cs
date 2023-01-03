using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MenuPlayer : MonoBehaviour
{ 
    Rigidbody2D rb;

    MenuGravity menuGravity;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        menuGravity = GameObject.Find("MenuGravity").GetComponent<MenuGravity>();
    }

    private void FixedUpdate()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        float gravityPlayerAngle = Vector2.SignedAngle(new Vector2(transform.up.x, transform.up.y), menuGravity.gravityUp);
        rb.angularVelocity = 2 * gravityPlayerAngle;
        //print(Vector2.SignedAngle(menuGravity.gravityUp, new Vector2 (transform.up.x, transform.up.y)));
    }
}

