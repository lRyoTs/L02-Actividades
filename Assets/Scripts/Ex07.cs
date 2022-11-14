using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex07 : MonoBehaviour
{
    public string operation; //Store "sum", "subtraction", "product", "division"
    public float num1 = 10;
    public float num2 = 4;
    // Start is called before the first frame update
    void Start()
    {
        Calculator(operation, num1, num2);
    }

    private void Calculator(string oper, float num1, float num2) {
        if (oper == "sum")
        {
            Debug.Log($"{num1} + {num2} = {num1+num2}");
        }
        else if (oper == "subtraction")
        {
            Debug.Log($"{num1} - {num2} = {num1 - num2}");
        }
        else if (oper == "product")
        {
            Debug.Log($"{num1} * {num2} = {num1 * num2}");
        }
        else if (oper == "division")
        {
            Debug.Log($"{num1} / {num2} = {num1 / num2}");
        }
        else {
            Debug.Log($"NOT AVAILABLE");
        }

    }
}
