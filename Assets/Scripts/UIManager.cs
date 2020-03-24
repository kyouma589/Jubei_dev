using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    FoodInteract FoodInteract;
    DrainDetect DrainDetect;
    MeowFunction MeowFunction;
    public bool reqsMet = false;

    // Start is called before the first frame update
    void Start()
    {
        FoodInteract = GetComponent<FoodInteract>();
        DrainDetect = GetComponent<DrainDetect>();
        MeowFunction = GetComponent<MeowFunction>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (FoodInteract.eatenCounter ==1 && DrainDetect.sniffCounter <= 1 && MeowFunction.meowCounter <= 1)
        {
            Debug.Log("Game ends here");
            reqsMet = true;
        }

    }

   
}
