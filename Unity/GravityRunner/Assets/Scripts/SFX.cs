using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioSource destroyed_object;
    public AudioSource portal_sound;
    public AudioSource warp_change_1;
    public AudioSource warp_change_2;
    public AudioSource warp_change_3;
    public AudioSource warp_change_4;
    

    public void playDestroyed_Object(){
        destroyed_object.Play ();
    }
    public void playPortal_Sound(){
        portal_sound.Play ();
    }
    public void playWarp_Change_1(){
        warp_change_1.Play ();
    }
    public void playWarp_Change_2(){
        warp_change_2.Play ();
    }
    public void playWarp_Change_3(){
        warp_change_3.Play ();
    }
    public void playWarp_Change_4(){
        warp_change_4.Play ();
    }
}
