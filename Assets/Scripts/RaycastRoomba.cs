using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastRoomba : MonoBehaviour
{
    // Start is called before the first frame update

    public float maxRayDistance = 2f;
    public float roombaSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        //1. Ray
        Ray roombRay = new Ray(transform.position, transform.forward);

        //2.define maximum raycasr distance\

        Debug.DrawRay(roombRay.origin, roombRay.direction * maxRayDistance, Color.blue);

        if(Physics.Raycast(roombRay, maxRayDistance))
        {

            int randomNumber = Random.Range(0, 100);
            if (randomNumber < 50)
            {
                transform.Rotate(0, 90, 0);
            }

            if (randomNumber>=50)
            {
                transform.Rotate(0, -90, 0);
            }

        }

        else
        {
            transform.Translate(0, 0, Time.deltaTime * roombaSpeed);
        }
    }
}
