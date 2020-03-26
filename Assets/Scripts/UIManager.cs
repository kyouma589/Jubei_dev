using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{

    public FoodInteract FoodInteract;
    public DrainDetect DrainDetect;
    public MeowFunction MeowFunction;
    public MeowFunction MeowFunction2;
    public MeowFunction MeowFunction3;
    public bool reqsMet = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (FoodInteract.eatenCounter ==1 && DrainDetect.sniffCounter >= 1 && (MeowFunction.meowCounter >= 1 || MeowFunction2.meowCounter >=1 || MeowFunction3.meowCounter >= 1))
        {
            Debug.Log("Game ends here");
            reqsMet = true;
        }

    }

   
}
