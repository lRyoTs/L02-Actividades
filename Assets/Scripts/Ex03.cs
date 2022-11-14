using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex03 : MonoBehaviour
{
    public int num = 23; //Store number
    // Start is called before the first frame update
    
    void Start()
    {
        if (num % 5 == 0)
        { //Check number divide by 5 return 0
            Debug.Log($"The number {num} is divisible by 5");
        }
        else {
            Debug.Log($"The number {num} is not divisible by 5");
        }
    }
}
