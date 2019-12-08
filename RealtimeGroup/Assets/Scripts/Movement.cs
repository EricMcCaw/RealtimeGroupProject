using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSp;
    protected Rigidbody Rb;
    public bool CanJump;
    public Vector3 start;
    public int Playernum;
    // Start is called before the first frame update
    void Start()
    {
        CanJump = true;
        Rb = transform.GetComponent<Rigidbody>();
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        GetInputs();
        Jump();
    }

    public void Jump()
    {
        if(Input.GetAxis("Jump"+ Playernum) != 0 && CanJump)
        {
            Rb.AddForce(new Vector3(0,800,0));
            CanJump = false;
        }
    }
    public void GetInputs(float x = 0, float z = 0)
    {
        Vector3 dz;

        if (x == 0 && z == 0)
        {
            dz = Input.GetAxis("Horizontal" + Playernum) * transform.forward;
        }
        else
        {
            dz = x * transform.forward;
        }
        Vector3 inputs = dz;

        //moving using rb still checks collisions without feeling like a slip n slide 
        if (!CanJump)
        {
            Vector3 movement = inputs.normalized * movementSp / 2 * Time.deltaTime;
            Rb.AddForce(movement);
        }
        else
        {
            Vector3 movement = inputs.normalized * movementSp * Time.deltaTime;
            Rb.AddForce(movement);
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Platform" || collision.gameObject.tag == "Player")
        {
            CanJump = true;
        }
        if(collision.gameObject.tag == "Death_Wall")
        {
            transform.position = start;
        }
    }


}
