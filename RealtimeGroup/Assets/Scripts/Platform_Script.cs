using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Script : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 start;
    public Quaternion rot;
    void Start()
    {
        start = transform.position;
        rot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            if(transform.GetComponent<Rigidbody>().useGravity == false)
            {
                transform.GetComponent<Rigidbody>().useGravity = true;
            }
            
        }
        if(collision.transform.tag == "Platform")
        {
            Physics.IgnoreCollision(transform.GetComponent<Collider>(), collision.transform.GetComponent<Collider>());
        }
        if(collision.transform.tag == "Death_Wall")
        {
            transform.position = start;
            transform.rotation = rot;
            transform.GetComponent<Rigidbody>().useGravity = false;
        }
    }
}
