using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GravityHandler : MonoBehaviour
{
    public Vector2 gravityDown;
    public Vector2 gravityUp;
    public Vector2 gravityLeft;
    public Vector2 gravityRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gravityDown = Physics2D.gravity.normalized;
        gravityUp = -gravityDown;
        gravityLeft = new Vector2(gravityDown.y, gravityDown.x);
        gravityRight = -gravityLeft;

        //rotate gravity 90° to the left
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Physics2D.gravity = rotate(Physics2D.gravity, -90);
        }
        //rotate gravity 90° to the right
        else if (Input.GetKeyUp(KeyCode.E))
        {
            Physics2D.gravity = rotate(Physics2D.gravity, +90);
        }
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
