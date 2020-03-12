using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodInteract : MonoBehaviour
{
    FoodInstantiate FoodInstantiate;
    public GameObject destinationFood;
    public float distanceToFood;
    public Text Dialogue;
  


    // Start is called before the first frame update
    void Start()
    {
        FoodInstantiate = GetComponent<FoodInstantiate>();
    }

    // Update is called once per frame
    void Update()
    {

        distanceToFood = Vector3.Distance(this.transform.position, destinationFood.transform.position);
        Debug.Log(distanceToFood);

        if (distanceToFood <= 2 && FoodInstantiate.foodBowlFill.activeSelf == true)
        {
            Debug.Log("hello");
            Dialogue.text = "Press 'E' to eat food.";

            if (Input.GetKeyDown(KeyCode.E))
            {
                //if (FoodInstantiate != null)
                //{
                FoodInstantiate.foodBowlFill.SetActive(false);

                //}
            }

        }

        else
            Dialogue.text = "";
       

    }
}
