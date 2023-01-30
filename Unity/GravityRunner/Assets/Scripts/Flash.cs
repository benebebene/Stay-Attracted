
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    private GameObject sprite;

    private float delay = 0f;
    private float repeatRate = 0.3f;

    private bool flashBool = false;

    //How many times the flash will be executed
    private int remainingFlashes = 5;
    
    void Start()
    {
        sprite = transform.gameObject;
        Flashing();
    }

    public void Flashing()
    {
        InvokeRepeating("FlashEffect", delay, repeatRate);
    }

    void FlashEffect()
    {
        SpriteRenderer spriteRend = sprite.GetComponent<SpriteRenderer>();
        if (flashBool){
            spriteRend.color = new Color (spriteRend.color.r, spriteRend.color.g, spriteRend.color.b, 1f);
            flashBool = false;
        }
        else 
        {
            spriteRend.color = new Color (spriteRend.color.r, spriteRend.color.g, spriteRend.color.b, 0f);
            flashBool = true;
            remainingFlashes--;
        }
        if (remainingFlashes == 0)
        {
            CancelInvoke("FlashEffect");
            Destroy(sprite);
        }
    }
}
