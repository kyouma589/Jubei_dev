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

    public float RaycastDetect = 1f;

    // Start is called before the first frame update
    void Start()
    {
        thisRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray JubeiJump = new Ray(transform.position, -transform.up);

        Debug.DrawRay(JubeiJump.origin, JubeiJump.direction * RaycastDetect, Color.magenta);

        // UP AND DOWN ON THE CONTRLLER
        forwardBackward = Input.GetAxis("Vertical");

        //Right and Left for controller
        rightLeft = Input.GetAxis("Horizontal");

        if (Physics.Raycast(JubeiJump, RaycastDetect))
        {

            if (Input.GetButtonDown("Jump"))
            {

                thisRigidbody.AddForce((transform.up * JumpForce), ForceMode.Impulse);
            }

        }



    }

    private void FixedUpdate()
    {
        //anything with rigidbody should go in fixed update
        thisRigidbody.AddForce((transform.forward) * forwardBackward * speed, ForceMode.Impulse);

      
        thisRigidbody.AddTorque(new Vector3(0, rightLeft * rotationSpeed, 0), ForceMode.Impulse);

    }
}
