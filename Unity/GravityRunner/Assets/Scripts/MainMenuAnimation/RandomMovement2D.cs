 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 public class RandomMovement2D : MonoBehaviour
 {
     Rigidbody2D rig;
     public float defaultSpeed=100;
     public float slowSpeed=10;
     // Start is called before the first frame update
     void Start()
     {
         rig = GetComponent<Rigidbody2D>();
         float rotation = Random.Range(0,360);
         transform.eulerAngles = new Vector3(0,0,rotation);
         Invoke("AddForce",0.1f);
        
     }
 
     void AddForce()
     {
         rig.AddRelativeForce(new Vector2(0,defaultSpeed));
     }
 
     // Update is called once per frame
     void Update()
     {
         if(rig.velocity.magnitude>defaultSpeed)
         {
             rig.AddRelativeForce(new Vector2(0,-slowSpeed));
         } else if(rig.velocity.magnitude<defaultSpeed)
         {
             rig.AddRelativeForce(new Vector2(0,slowSpeed/2));
         }
 
         
     }
 }
