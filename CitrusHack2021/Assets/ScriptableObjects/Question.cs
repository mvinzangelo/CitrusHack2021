using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Question", menuName = "Question")]

public class Question : ScriptableObject
{
    public bool typeOfQuestion;
    public string quesiton;
    public Answer[] answers;
    public Answer userAnswer;
    public bool askedToday;

    public void setAnswerToOne()
    {
        userAnswer = answers[0];
    }
    public void setAnswerToTwo()
    {
        userAnswer = answers[1];
    }
    public void setAnswerToThree()
    {
        userAnswer = answers[2];
    }
    public void setAnswerToFour()
    {
        userAnswer = answers[3];
    }
    public void setAnswerToFive()
    {
        userAnswer = answers[4];
    }
}
