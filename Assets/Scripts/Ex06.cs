using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex06 : MonoBehaviour
{
    public float distTravel;
    public float distTotal;

    // Start is called before the first frame update
    void Start()
    {
        //Check if completed
        if (distTravel >= distTotal)
        {
            Debug.Log($"Congratulations! You have completed the total distance.");
        }
        else {
            Debug.Log($"Oh… You still have {distTotal-distTravel} meters left to complete the total distance.");
        }
    }
}
