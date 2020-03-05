using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JubeiMoveScript : MonoBehaviour
{
    public Rigidbody thisRigidbody;

    public float forwardBackward;
    public float rightLeft;
    public float rotationSpeed = 5f;
    public float JumpForce = 2f;

    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        thisRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // UP AND DOWN ON THE CONTRLLER
        forwardBackward = Input.GetAxis("Vertical");

        //Right and Left for controller
        rightLeft = Input.GetAxis("Horizontal");

        



    }

    private void FixedUpdate()
    {
        //anything with rigidbody should go in fixed update
        thisRigidbody.AddForce((transform.forward) * forwardBackward * speed, ForceMode.Impulse);

        if (Input.GetButtonDown("Jump"))
        {

            thisRigidbody.AddForce((transform.up * JumpForce), ForceMode.Impulse);
        }
        thisRigidbody.AddTorque(new Vector3(0, rightLeft * rotationSpeed, 0), ForceMode.Impulse);

    }
}
