using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;



public class agentcon : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject spawnenemy;
    public GameObject bullet;
    GameObject clone;
    Rigidbody clone_rb;
    float distanceToPlayer;
    NavMeshAgent agentt;
    static int ennemy=5;
 
    public float distance=10f;
    void Start()
    {
        agentt=GetComponent<NavMeshAgent>();
        InvokeRepeating("pula", 0.5f, 0.5f);

    }
    void pula()
    {
        
            clone = Instantiate(bullet, transform.position, Quaternion.Euler(90f + transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0 ));
            clone.transform.position=spawnenemy.transform.position;
            clone.transform.SetParent(spawnenemy.transform);

    }

    // Update is called once per frame
    
    void Update()
    {
        distanceToPlayer=Vector3.Distance(transform.position, player.transform.position);
        Debug.DrawRay(transform.position, transform.forward*distance, Color.yellow);
        Debug.DrawRay(transform.position, transform.forward*(-distance), Color.yellow);
        Debug.DrawRay(transform.position, transform.right*(-distance), Color.yellow);
        Debug.DrawRay(transform.position, transform.right*distance, Color.yellow);
        if(distanceToPlayer<=10)
        {
            agentt.SetDestination(player.transform.position);
            clone_rb = clone.GetComponent<Rigidbody>();
            clone_rb.AddForce(transform.forward * 900f);
            
        }
        
        
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="bullet")
        {   
            ennemy=ennemy-1;
            print(ennemy);
            Destroy(gameObject); 
            if(ennemy==0)
            {
                SceneManager.LoadScene("win");
            }
            
        }
        
    }
    
    
}
