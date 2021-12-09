using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int curSpeed;
    public int walkSpeed;
    public int runSpeed;
    public Rigidbody rbody;

    void Start()
    {
        curSpeed = walkSpeed;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            curSpeed = runSpeed;
        }
        else
        {
            curSpeed = walkSpeed;
        }

        Vector3 tempVel = Vector3.zero;
        float tempY = rbody.velocity.y;

        if (Input.GetKey(KeyCode.W))
        {
            tempVel += transform.forward * curSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            tempVel -= transform.right * curSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            tempVel -= transform.forward * curSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            tempVel += transform.right * curSpeed;
        }

        rbody.velocity = tempVel;
    }
}
