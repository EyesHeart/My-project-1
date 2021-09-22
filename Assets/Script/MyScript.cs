using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    int num;
    void Start()
    {
        PrintNum();
    }
    void PrintNum()
    {
        int n = 1;
        while (n <= 100)
        {
            print(n);
            n = n + 2;
        }
    }
}
