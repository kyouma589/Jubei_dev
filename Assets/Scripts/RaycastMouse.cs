using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastMouse : MonoBehaviour
{
    // Start is called before the first frame update

    public float maxRaycastdistance = 1000f;
    public GameObject brush;

    // Update is called once per frame
    void Update()
    {
        //1. Define a ray
        //screen point to ray
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);


        //2. Max raycast distance

        //3. Visualize the raycast

        Debug.DrawRay(camRay.origin, camRay.direction * maxRaycastdistance, Color.cyan);

        //4a. Define object detection
        RaycastHit hitObject;

        //4. detecting the object

        if (Physics.Raycast(camRay, out hitObject, maxRaycastdistance))
        {
            //5. When hit, spawn something useful (spawn)
            brush.transform.position = hitObject.point;

            //5.1 paint!
            if (Input.GetMouseButton(0))
            {
               GameObject paint = Instantiate(brush, hitObject.point, Quaternion.identity);
                paint.transform.SetParent(hitObject.transform);
            }

            //while hovering spin the canvas
            hitObject.transform.Rotate(new Vector3(0, 0, 35 * Time.deltaTime));

        }
    }
}
