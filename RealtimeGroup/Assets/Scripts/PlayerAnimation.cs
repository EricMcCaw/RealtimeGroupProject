using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Movement movement;
    public Animator anim;
    public GameObject playerModel;
    private Rigidbody rb;

    private bool turnedLeft = false, turnedRight = true;

    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<Movement>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.magnitude > 0.1)
        {
            anim.SetBool("Running", true);
        }
        else
            anim.SetBool("Running", false);

        if (!movement.CanJump)
        {
            anim.SetBool("Jump", true);
        }
        else
            anim.SetBool("Jump", false);

        //handle the player rotation
        if (turnedRight)
        {
            if (rb.velocity.x < 0)
            {
                turnedLeft = true;
                turnedRight = false;
                playerModel.transform.rotation = Quaternion.Euler(0, -90, 0);
            }
        }
        else if (turnedLeft)
        {
            if (rb.velocity.x > 0)
            {
                turnedLeft = false;
                turnedRight = true;
                playerModel.transform.rotation = Quaternion.Euler(0, 90, 0);
            }
        }
    }
         
}
