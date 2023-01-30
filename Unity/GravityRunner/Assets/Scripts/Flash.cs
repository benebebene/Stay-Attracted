using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    private bool flashBool = true;
    private int flashCounter = 11;
    private GameObject sprite;
    void Start()
    {
        sprite = transform.gameObject;
    }

    public void Flashing()
    {
        InvokeRepeating("FlashEffect", 0f, 0.3f);
    }

    void FlashEffect()
    {
        SpriteRenderer spriteRend = sprite.GetComponent<SpriteRenderer>();
        if (flashBool){
            spriteRend.color = new Color (spriteRend.color.r, spriteRend.color.g, spriteRend.color.b, 1f);
            flashBool = false;
            flashCounter--;
        }
        else 
        {
            spriteRend.color = new Color (spriteRend.color.r, spriteRend.color.g, spriteRend.color.b, 0f);
            flashBool = true;
            flashCounter--;
        }
        if (flashCounter == 0)
        {
            CancelInvoke("FlashEffect");
            Destroy(sprite);
        }
    }
}
