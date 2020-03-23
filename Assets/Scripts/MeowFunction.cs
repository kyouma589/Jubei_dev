using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeowFunction : MonoBehaviour
{
    public AudioSource CatMeow;
    public float meowDistance;
    public GameObject meowDestination;
    public Text Dialogue;
    public int meowCounter = 0;
    public bool inRange = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        meowDistance = Vector3.Distance(this.transform.position, meowDestination.transform.position);
        //Debug.Log(meowDistance);

        if (meowDistance <= 2.5 )
        {
            Debug.Log("You can Meow here");
            inRange = true;
            Dialogue.text = "Press 'E' to meow.";

            if (Input.GetKeyDown(KeyCode.E) && CatMeow.isPlaying == false)
            {
                CatMeow.Play();
                meowCounter += 1;
                Dialogue.text = "";


            }

        }

        //else
            //Dialogue.text = "";
        if (meowDistance >= 2.5 && inRange == true)
        {
            Dialogue.text = "";
            inRange = false;
        }
    }
}
