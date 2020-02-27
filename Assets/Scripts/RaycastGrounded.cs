using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastGrounded : MonoBehaviour
{
    // Start is called before the first frame update

    public float castingDistance = 4f;

    // Update is called once per frame
    void Update()
    {
        //1. Declare a ray. At the point of origin and point it DOWN
        Ray myRay = new Ray(transform.position, Vector3.down);

        //2. Set the Max distance

        //3. Draw a debug ine that shows the ray
        Debug.DrawRay(myRay.origin, myRay.direction * castingDistance, Color.magenta);

        //4. Shoot the raycast
        if (Physics.Raycast(myRay, castingDistance))
        {
            Debug.Log("Hit Ground");
        
        }

        else
        {
            transform.Rotate(0, 5f, 0);
        }
    }
}
