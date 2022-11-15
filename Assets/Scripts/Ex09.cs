using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex09 : MonoBehaviour
{
    public bool wantsVegetarianOption = false;

    // Start is called before the first frame update
    void Start()
    {
        if (!wantsVegetarianOption)
        {
            Debug.Log("Non-vegetarian option coming soon");
        }
        else {
            Debug.Log("Vegetarian option coming soon");
        }
    }
}
