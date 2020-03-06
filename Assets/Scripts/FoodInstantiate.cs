using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodInstantiate : MonoBehaviour
{
    // <summary>
    // Start with bowl empty
    // Bowl gets fill
    // Eat and empty bowl
    
    public GameObject foodBowlFill;
    public GameObject foodBowlEmpty;

    // Start is called before the first frame update
    void Start()
    {
        foodBowlEmpty.SetActive(true);
        foodBowlFill.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        foodBowlFill.SetActive(true);
        foodBowlEmpty.SetActive(false);
        Debug.Log("food bowl is now full " + other.name);
        GetComponent<BoxCollider>().enabled = false;
    }
}
