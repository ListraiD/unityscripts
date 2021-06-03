using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodycon : MonoBehaviour
{
    // Start is called before the first frame update
    
    float x;
    float y;
    Rigidbody rb;
    public GameObject gun;
    public GameObject rhand;
    public GameObject lhand;
    RaycastHit hit_object;
    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        rb.velocity=transform.forward * y * 20f;
        transform.Rotate(0,x,0);
        Debug.DrawRay(transform.position, transform.forward*3f, Color.red);

        if(Physics.Raycast(transform.position, transform.forward, out hit_object ,3f))//позиция направление цель длина
        {
            if(hit_object.collider.gameObject.tag=="gun")
            {
                
                if(Input.GetKeyDown("e"))
                {
                    gun.transform.position=rhand.transform.position;
                    gun.transform.SetParent(rhand.transform);
                    gun.GetComponent<BoxCollider>().enabled=false;
                    
                    
                }
            }
        }
    }
    public void Poluchatel(float arg) 
    {
        transform.rotation = Quaternion.Euler(0,arg,0);
    }
    
    
}
