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
    public bool foodEaten = false;
    public bool foodRange = false;
    public int eatenCounter = 0;
    
  


    // Start is called before the first frame update
    void Start()
    {
        FoodInstantiate = GetComponent<FoodInstantiate>();
    }

    // Update is called once per frame
    void Update()
    {

        distanceToFood = Vector3.Distance(this.transform.position, destinationFood.transform.position);
        //Debug.Log(distanceToFood);

        if (distanceToFood <= 2.5 && FoodInstantiate.foodBowlFill.activeSelf == true)
        {
            Debug.Log("hello");
            foodRange = true;
            Dialogue.text = "Press 'E' to eat food.";

            if (Input.GetKeyDown(KeyCode.E))
            {
                //if (FoodInstantiate != null)
                //{
                FoodInstantiate.foodBowlFill.SetActive(false);
                foodEaten = true;
                eatenCounter += 1;
                //}
            }

        }

       if (distanceToFood >= 2.5 && foodEaten == true && foodRange == true)
        {
            Dialogue.text = "";
            foodRange = false;

        }
       

    }
}
