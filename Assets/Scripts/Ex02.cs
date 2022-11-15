using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex02 : MonoBehaviour
{
    public int year = 2000;
    // Start is called before the first frame update
    void Start()
    {
        string horoscope = getChineseHoros(year); //Store chinese horoscope

        //Display message
        Debug.Log($"Year {year} is {horoscope} in Chinese Horoscope");
    }

    //Get chinese horoscope by year returns a String
    public string getChineseHoros(int year) {
        string[] chiHoroscope = { "Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Goat"};

        return chiHoroscope[year % 12];
    }
}
