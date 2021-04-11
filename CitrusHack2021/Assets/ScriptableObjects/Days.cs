using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Days", menuName = "Days")]
public class Days : ScriptableObject
{
    public void Awake()
    {
        setDate();
    }

    public string date;
    public List<Question> answers;
    public int physicalIndex;
    public int mentalIndex;
    public int totalIndex;
    public FRQ FRQ;

    public void push_back_question(Question userQuestion)
    {
        Question userAnswer = userQuestion;
        answers.Add(userAnswer);
        if (userQuestion.typeOfQuestion)
        {
            mentalIndex++;
        }
        else
        {
            physicalIndex++;
        }
        totalIndex++;
    }

    public void push_back_FRQ(FRQ userFRQ)
    {
        FRQ = userFRQ;
    }

    public void setDate()
    {
        date = System.DateTime.Now.ToString("MM/dd");
    }
}
