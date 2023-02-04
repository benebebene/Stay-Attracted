using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portalscript : MonoBehaviour
{
    public AudioSource portalSound;
    BoxCollider2D portalcollider;

    [SerializeField]
    private int maxNumberShards;

    private float multFactor;
    private int shards;

    public string sceneToLoad;

    public GameObject[] portals;
    public GameObject[] psPortals;


    // Start is called before the first frame update
    void Start()
    {
        portalcollider = GetComponent<BoxCollider2D>();
        maxNumberShards = GameObject.FindGameObjectsWithTag("PortalShard").Length;
        multFactor = ((100f / maxNumberShards) / 255f);
        shards = PlayerInventory.numberShards;
    }

    void Update()
    {
        //New Shard got collected
        if (PlayerInventory.numberShards > shards)
        {
            foreach(GameObject p in portals)
            {
                SpriteRenderer pRend = p.GetComponent<SpriteRenderer>();
                pRend.color = new Color (pRend.color.r, pRend.color.g, pRend.color.b, pRend.color.a + multFactor);
                
            }
            shards = PlayerInventory.numberShards;
            Debug.Log(shards);

        }

        if (shards == maxNumberShards && shards > 0)
        {
            foreach(GameObject psp in psPortals)
            {
                var emission = psp.GetComponent<ParticleSystem>().emission;
                emission.enabled = true;
                
            }
            //Avoid Looping
            shards = shards + 1;
        }

    }
    

    private void OnTriggerEnter2D(Collider2D coll){
        if (coll.gameObject.tag =="Player" && PlayerInventory.numberShards >= maxNumberShards){
            portalSound.Play();
            Debug.Log("Next level");
            Debug.Log(SceneManager.GetActiveScene().buildIndex);
            Dialogue.restarted = false;
            MenuHandler.playGameSceneName = sceneToLoad;
            SceneManager.LoadScene(sceneToLoad);
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
