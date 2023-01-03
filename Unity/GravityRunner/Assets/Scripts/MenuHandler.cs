using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class MenuHandler : MonoBehaviour
{
    
    //--------------------------------------------
    //MAIN MENU GUI
    //--------------------------------------------

    public void StartGame()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }
    

    //--------------------------------------------
    //FLOATING PLAYER ANIMATION
    //--------------------------------------------
    public float gravityStrength = 1f;

    private float nextActionTime = 0.0f;
    public float period = 5f;

    private int rand = 0;

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
         

        if (Time.time > nextActionTime) 
        {
            nextActionTime += period;
            // execute block of code here
            rand = Random.Range(0,20);
            if (rand <= 5)
            {
                Physics2D.gravity = new Vector2(0, +gravityStrength);
            }
            if (rand > 5 && rand <= 10)
            {
                Physics2D.gravity = new Vector2(0, -gravityStrength);
            }
            if (rand > 10 && rand <= 15)
            {
                Physics2D.gravity = new Vector2(-gravityStrength, 0);
            }
            if (rand > 15 && rand <= 20)
            {
            Physics2D.gravity = new Vector2(+gravityStrength, 0);
            }
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






    





