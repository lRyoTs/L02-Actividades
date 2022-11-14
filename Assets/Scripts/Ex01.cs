using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex01 : MonoBehaviour
{
    //Variables
    public float num = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Check if number is greater than 0
        if (num > 0) {
            Debug.Log($"The number {num} is positive");
        } else if (num < 0) { //Check if number lower than 0
            Debug.Log($"The number {num} is negative");
        } else { //num is 0
            Debug.Log($"The number {num} is zero");
        }
    }
}
