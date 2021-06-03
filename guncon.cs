using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guncon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    GameObject clone;
    Rigidbody clone_rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {            
            
            clone = Instantiate(bullet, transform.position, Quaternion.Euler(90f + transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0 ));
            clone_rb = clone.GetComponent<Rigidbody>();
            clone_rb.AddForce(transform.forward * 1300f);
        }
      
    }
    public void Poluchatel(float arg) 
    {
        transform.rotation = Quaternion.Euler(0,arg,0);
    }
    
    
    
    
}
