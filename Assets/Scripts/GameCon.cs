using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCon : MonoBehaviour
{
    public Button okbutton;

    public InputField answerField;

    void Start()
    {
        print("hello");
    }

    public void printName()
    {
        print(answerField.text);
    }

    void Update()
    {
        

    }
}
