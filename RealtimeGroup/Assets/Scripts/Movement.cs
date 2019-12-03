using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSp;
    protected Rigidbody Rb;
    // Start is called before the first frame update
    void Start()
    {
       
        Rb = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GetInputs();
    }

    public void GetInputs(float x = 0, float z = 0)
    {
        Vector3 dz;

        if (x == 0 && z == 0)
        {
            dz = Input.GetAxis("Horizontal") * transform.forward;
            
        }
        else
        {
            dz = x * transform.forward;
        }
        Vector3 inputs = dz;

        //moving using rb still checks collisions without feeling like a slip n slide 
        Vector3 movement = inputs.normalized * movementSp * Time.deltaTime;
        Rb.AddForce(movement);
        //Rb.MovePosition(movement);


    }
}
