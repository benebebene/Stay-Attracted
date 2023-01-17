using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum MovementType { 
    STATIONARY,
    RIGIDBODY,
    LINEAR
}

public class Enemy : MonoBehaviour
{
    [SerializeField]
    MovementType movementType;

    [SerializeField]
    Vector2 pos1;
    [SerializeField]
    Vector2 pos2;
    [SerializeField]
    float velocity; // units/second
    private int sign = 1;
    Vector2 direction;


    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        switch(movementType) 
        {
            case MovementType.STATIONARY: 
            {
                rb.bodyType = RigidbodyType2D.Static;
                break; 
            }
            case MovementType.RIGIDBODY: 
            {
                rb.bodyType = RigidbodyType2D.Dynamic;
                break; 
            }
            case MovementType.LINEAR: 
            {
                transform.position = pos1;
                direction = (pos2 - pos1).normalized;
                rb.bodyType = RigidbodyType2D.Kinematic;
                break; 
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (movementType)
        {
            case MovementType.STATIONARY:
                {
                    break;
                }
            case MovementType.RIGIDBODY:
                {
                    break;
                }
            case MovementType.LINEAR:
                {
                    moveLinear();
                    break;
                }
        }
    }

    void moveLinear() 
    {
        if (sign == 1 && (pos2 - projectXY(transform.position)).magnitude < 0.05)
        {
            sign = -1;
        } 
        else if (sign == -1 && (pos1 - projectXY(transform.position)).magnitude < 0.05)
        {
            sign = 1;
        }
        
        rb.velocity = sign * velocity * direction;

    }

    private Vector2 projectXY(Vector3 v)
    {
        return new Vector2(v.x, v.y);
    }
}
