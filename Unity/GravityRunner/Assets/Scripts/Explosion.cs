using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
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
            
            if (obj.gameObject.tag == "Blob")
            {
                Destroy(obj.gameObject);
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 1, 0, 0.75F);
        Gizmos.DrawWireSphere(transform.position, fieldOfImpact);
    }
}