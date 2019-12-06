using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomNumber : MonoBehaviour
{
    public int number0;
    public int number1;
    public int number2;
    public int number3;
    public int number4;
    public int number5;
    public int number6;
    public int number7;
    public int number8;
    public int number9;
    public int number100;
    public void Random10()
    {
        number0 = Random.Range(0, 10);
        number1 = Random.Range(0, 10);
        number2 = Random.Range(0, 10);
        number3 = Random.Range(0, 10);
        number4 = Random.Range(0, 10);
        number5 = Random.Range(0, 10);
        number6 = Random.Range(0, 10);
        number7 = Random.Range(0, 10);
        number8 = Random.Range(0, 10);
        number9 = Random.Range(0, 10);
        number100 = number0 + number1 + number2 + number3 + number4 + number5 + number6 + number7 + number8 + number9;
        Debug.Log(number100);
    }
    public void Random1010()
    {
        number1 = 0;
        for (int i = 0; i < 10; i++)
        {
            number0 = 0;
            Random10();
            number1 += number0;
            
        }
        Debug.Log(number0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
