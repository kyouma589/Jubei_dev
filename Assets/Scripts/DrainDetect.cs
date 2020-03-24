using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrainDetect : MonoBehaviour
{
    public float drainDistance;
    public AudioSource angryCat;
    public GameObject drainDestination;
    public Text Dialogue;
    public int sniffCounter = 0;
    public bool drainRange = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        drainDistance = Vector3.Distance(this.transform.position, drainDestination.transform.position);
        //Debug.Log(drainDistance);

        if (drainDistance <= 2.5)
        {
            Debug.Log("You can sniff here");
            drainRange = true;
            Dialogue.text = "Press 'E' to sniff.";

            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("You have sniffed");
                sniffCounter += 1;
                angryCat.Play();

            }

        }

        //else
          //  Dialogue.text = "";

        if (drainDistance >= 2.5 && drainRange == true)
        {
            Dialogue.text = "";
            drainRange = false;

        }
    }

   



}

