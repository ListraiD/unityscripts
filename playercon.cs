using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="enemy")
        {
            print("ti popal");
        }
    }
    
}
