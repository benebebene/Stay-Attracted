using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionScript : MonoBehaviour
{

    public float fieldOfImpact;

    public GameObject explosionCircle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.G)){

            if (PlayerInventory.numberExplosives > 0)
            {

                PlayerInventory.ExplosiveUsed();
                explosionCircle.transform.position = transform.position;
                explosionCircle.SetActive(true);
                explode();
                Invoke("SetFalse", 0.7f);
            }
            
        }
    }

    void SetFalse(){

        explosionCircle.SetActive(false);
    }

    void explode()
    {

        Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, fieldOfImpact);

        foreach(Collider2D obj in objects){
            
            if (obj.gameObject.tag == "Blob" || obj.gameObject.tag == "Enemy")
            {
                Flash flash = obj.GetComponent<Flash>();
                flash.Flashing();
                
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        print("Drawing Gizmos!");
        Gizmos.color = new Color(1, 1, 0, 0.75F);
        Gizmos.DrawWireSphere(transform.position, fieldOfImpact);
    }
}
