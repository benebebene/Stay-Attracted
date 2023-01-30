using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AudioScript : MonoBehaviour
{


    public static AudioScript Instance;
    public AudioSource source;
    public AudioClip soundtrack;
    



    void Awake(){
        if (Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else {
            Destroy(gameObject);
        }

    }

    void Start(){
        source.clip= soundtrack;
        source.loop = true;
        source.Play();
    }
    
}
