using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextBlink : MonoBehaviour
{
    public TextMeshProUGUI Text;
    private float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
           if(timer >= 0.5)
           {
                   Text.color = Color.red;
           }
           if(timer >= 1)
           {
                   Text.color = Color.white;
                   timer = 0;
           }
        
    }
}
