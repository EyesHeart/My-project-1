using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameCon : MonoBehaviour
{
    public Button okbutton;

    public InputField answerInputbox;

    public Text displayText;

    string[]answers;

    string[]questions;

    int currentQuestionNumber = 0;
    
    int currentAnswerNumber = 0;

    void Start()
    {
        answers = new string[5];
        questions = new string[]
        {
            "What your nickname?",
            "Dad or Mom?",
            "What your favorite food?",
            "What your favorite Celebrity?",
            "What your favorite place to travel ?",
            "What your favorite sport ?",
            "What your favorite Game Genre ?",
            "What your favorite movie ?",
            "What your favorite TV show ?",
            "What your favorite Season ?",
            "What your favorite Animal ?",
            "What your favorite holiday ?",
            "What your favorite song ?",
            "What your favorite Video Game ?",
            "What your favorite Character form Game/Movie ?",
            "Marvel or DC ?",
            "Console or Pc or Mobile ?",
            "Single Player or Multiplayer ?",
            "City or Country ?",
            "Ghost or Monster ?",
            "Coke or Pepsi ?"
        };

        displayText.text = questions[currentQuestionNumber];
    }

    public void printName()
    {
        answers[currentAnswerNumber] = answerInputbox.text;
        answerInputbox.text = "";

        currentAnswerNumber = currentAnswerNumber + 1;
        currentQuestionNumber = Random.Range(1,questions.Length);

        if(currentAnswerNumber <= 4)
        {
            displayText.text = questions[currentQuestionNumber];
        }
      else
        {
            displayText.text = answers[0] +
                " like " + answers[1] +
                " and he love " + answers[2]+
                " and he interested in " + answers[3] + 
                " and he like " + answers[4] + ".";

            okbutton.gameObject.SetActive(false);
            answerInputbox.gameObject.SetActive(false);

        }
    }
    void Update()
    {
        

    }
}
