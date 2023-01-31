using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GravityHandler : MonoBehaviour
{
    float gravityStrength = 9.8f;

    //normalized vectors storing directions relative to current gravity vector
    public Vector2 gravityDown;
    public Vector2 gravityUp;
    public Vector2 gravityLeft;
    public Vector2 gravityRight;

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.gravity = new Vector2(0, 0);
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) ||Input.GetKeyDown(KeyCode.W))
        {
            Physics2D.gravity = new Vector2(0, +gravityStrength);
    
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) ||Input.GetKeyDown(KeyCode.S))
        {
            Physics2D.gravity = new Vector2(0, -gravityStrength);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) ||Input.GetKeyDown(KeyCode.A))
        {
            Physics2D.gravity = new Vector2(-gravityStrength, 0);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) ||Input.GetKeyDown(KeyCode.D))
        {
            Physics2D.gravity = new Vector2(+gravityStrength, 0);
        }
    }

    private void FixedUpdate()
    {
        gravityDown = Physics2D.gravity.normalized;
        gravityUp = -gravityDown;
        gravityLeft = new Vector2(gravityDown.y, gravityDown.x);
        gravityRight = -gravityLeft;
        
    }

    public static Vector2 rotate(Vector2 vector, float angle)
    {
        angle *= Mathf.Deg2Rad;
        return new Vector2(
            vector.x * Mathf.Cos(angle) - vector.y * Mathf.Sin(angle),
            vector.x * Mathf.Sin(angle) + vector.y * Mathf.Cos(angle)
        );
    }

}
