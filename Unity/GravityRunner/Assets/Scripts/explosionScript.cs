using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosionScript : MonoBehaviour
{

    public float fieldOfImpact;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.G)){

            explode();
        }
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
        Gizmos.DrawSphere(transform.position, fieldOfImpact);
    }
}
