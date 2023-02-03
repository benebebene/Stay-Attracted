using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialPortal : MonoBehaviour
{
    public AudioSource portalSound;
    BoxCollider2D portalcollider;

    public Object sceneToLoad;

    public GameObject[] portals;
    public GameObject[] psPortals;

    private bool blobDead = false;
    private bool portalAnimated = false;


    // Start is called before the first frame update
    void Start()
    {
        portalcollider = GetComponent<BoxCollider2D>();
       
    }

    void Update()
    {
        Debug.Log(GameObject.Find("Enemy") == null);
        if (GameObject.Find("Enemy") == null && !portalAnimated)
        {
            foreach(GameObject p in portals)
            {
                SpriteRenderer pRend = p.GetComponent<SpriteRenderer>();
                pRend.color = new Color (pRend.color.r, pRend.color.g, pRend.color.b, 1f);   
            }
            
            foreach(GameObject psp in psPortals)
            {
                var emission = psp.GetComponent<ParticleSystem>().emission;
                emission.enabled = true;
            }
            portalAnimated = true;
            blobDead = true;
        }
    }
    

    private void OnTriggerEnter2D(Collider2D coll){
        if (coll.gameObject.tag =="Player" && blobDead){
            portalSound.Play();
            Debug.Log("Next level");
            Debug.Log(SceneManager.GetActiveScene().buildIndex);
            Dialogue.restarted = false;
            SceneManager.LoadScene(sceneToLoad.name);
            // // Load Level 1
            // if (SceneManager.GetActiveScene().buildIndex == 1){
            //     SceneManager.LoadScene("Level_2");
            // }
            // // Load Level 2
            // if (SceneManager.GetActiveScene().buildIndex == 2){
            //     SceneManager.LoadScene("Level_3");
            // }
            // // Load Level 3
            // if (SceneManager.GetActiveScene().buildIndex == 3){
            //     SceneManager.LoadScene("Level_4");
            // }
            // // Load Level 4
            // if (SceneManager.GetActiveScene().buildIndex == 4){
            //     SceneManager.LoadScene("MainMenu");
            // }
        }
    }
}
