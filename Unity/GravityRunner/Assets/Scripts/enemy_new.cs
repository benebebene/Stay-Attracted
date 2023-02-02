using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum MoveType { 
    STATIONARY,
    RIGIDBODY,
    LINEAR
}

public class enemy_new : MonoBehaviour
{
    internal Vector2 StartPos()
    {
        Vector2 pos1 = new Vector2(transform.position.x, transform.position.y);
        return pos1;
    }

    
    
    [SerializeField]
    MoveType moveType;

    
    [SerializeField]
    Vector2 pos2;
    [SerializeField]
    float velocity; // units/second
    private int sign = 1;
    Vector2 direction;


    Rigidbody2D rb;

    Vector2 start_pos;
    


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        start_pos = StartPos();

        switch(moveType) 
        {
            case MoveType.STATIONARY: 
            {
                rb.bodyType = RigidbodyType2D.Static;
                break; 
            }
            case MoveType.RIGIDBODY: 
            {
                rb.bodyType = RigidbodyType2D.Dynamic;
                break; 
            }
            case MoveType.LINEAR: 
            {
                //transform.position = pos1;
                direction = (pos2 - start_pos).normalized;
                rb.bodyType = RigidbodyType2D.Kinematic;
                break; 
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (moveType)
        {
            case MoveType.STATIONARY:
                {
                    break;
                }
            case MoveType.RIGIDBODY:
                {
                    break;
                }
            case MoveType.LINEAR:
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
        else if (sign == -1 && (start_pos - projectXY(transform.position)).magnitude < 0.05)
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
