using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JubeiRaycast : MonoBehaviour
{
    // Start is called before the first frame update
    public float RaycastDistance = 3f;


    // Update is called once per frame
    void Update()
    {

        Ray JubeiForward = new Ray(transform.position, transform.forward);

        Debug.DrawRay(JubeiForward.origin, JubeiForward.direction * RaycastDistance, Color.cyan);

        if (Physics.Raycast(JubeiForward, RaycastDistance))
        {

            Debug.Log("Meow");




        }

        else
        {
            Debug.Log("Purrrrr");
        }



    }
}
