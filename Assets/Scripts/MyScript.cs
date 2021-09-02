using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    int num;
    void Start()
    {
        for (int num = 1; num <= 100; num++)
        {
            print(num);
        }

        for (int num = 1; num <= 100; num++)
        {
            if (num % 2 == 0)
            {
                print(num);
            }
        }
        float x = 1.0f;
        float r = circle(x);


        float circle(float x)
        {
            float result;
            x = 8.0f;
            result = 3.14f * (x * x);
            print(result);
            return result;
        }
    }
}
