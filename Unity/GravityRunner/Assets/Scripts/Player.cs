using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float runningSpeed = 6f;
    float jumpingForce = 7f;
    Vector2 jumpVector; 
    Rigidbody2D rb;
    BoxCollider2D feet;
    BoxCollider2D[] feetCollisionResults = new BoxCollider2D[5];
    ContactFilter2D contactFilter = new ContactFilter2D();

    GravityHandler gravityHandler;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        feet = transform.GetComponentInChildren<BoxCollider2D>();
        gravityHandler = GameObject.Find("GravityHandler").GetComponent<GravityHandler>();

        jumpVector = Vector2.up * jumpingForce;
    }

    private void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2.Angle(Vector2.up, gravityHandler.gravityUp);
        transform.rotation = Quaternion.Euler(0, 0, Vector2.SignedAngle(Vector2.up, gravityHandler.gravityUp));

        jumpVector = gravityHandler.gravityUp * jumpingForce;

        int countCollisions = feet.OverlapCollider(contactFilter, feetCollisionResults);

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.Space) && countCollisions > 1)
        {
            rb.AddForce(jumpVector, ForceMode2D.Impulse);
        }

        rb.AddForce(horizontalInput * runningSpeed * gravityHandler.gravityRight);

    }
}
