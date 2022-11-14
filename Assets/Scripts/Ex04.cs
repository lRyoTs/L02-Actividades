using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex04 : MonoBehaviour
{
    public float bases;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        if((bases > 0) && (height > 0)) {
            Debug.Log($"The area of the triangle with base={bases} and height={height} is {getTriangleArea(bases,height)}");
        }
    }

    //Function that gets the area of the triangle return a float value
    float getTriangleArea(float bases, float height) {
        float result; //Store result form the operation

        //Get area of the triangle
        result = (bases * height) / 2; //Triangle's area == (b*h)/2
        
        return result;
    }
}
