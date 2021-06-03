using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headcon : MonoBehaviour
{
    // Start is called before the first frame update
    Transform head_tr;
    float MouseX;
    float MouseY;
    public GameObject cam;
    public GameObject gun;
    public GameObject lhand;
    public float sens = 3f;
    RaycastHit hit_object;
    void Start()
    {
        head_tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        MouseX = MouseX + Input.GetAxis("Mouse X") * sens;
        MouseY = MouseY - Input.GetAxis("Mouse Y") * sens;
        MouseY = Mathf.Clamp(MouseY, -90, 90);
        head_tr.rotation = Quaternion.Euler(MouseY, MouseX, 0);
        FindObjectOfType<bodycon>().Poluchatel(MouseX);
        FindObjectOfType<guncon>().Poluchatel(MouseX);
        Debug.DrawRay(transform.position, transform.forward*3f, Color.red);

        if(Physics.Raycast(transform.position, transform.forward, out hit_object ,3f))//позиция направление цель длина
        {
            if(hit_object.collider.gameObject.tag=="gun")
            {
                
                if(Input.GetKeyDown("e"))
                {
                    gun.SetActive(false);
                    lhand.SetActive(true);
                   
                    
                    
                }
            }
        }
    }
    
}
