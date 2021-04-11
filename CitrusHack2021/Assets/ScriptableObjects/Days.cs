using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Days : MonoBehaviour
{
    // singleton code
    private static Days _instance;

    void Awake()
    {

    }

    public string date = System.DateTime.Now.ToString("MM/dd");
    public List<Question> answers;
    public int physicalIndex;
    public int mentalIndex;
    public int totalIndex;
    public FRQ FRQ;

    public void push_back_question(Question userQuestion)
    {
        Question userAnswer = Instantiate(userQuestion);
        answers.Add(userAnswer);
        if (userQuestion.typeOfQuestion)
        {
            mentalIndex += userAnswer.userAnswer.pointValue;
        }
        else
        {
            physicalIndex += userAnswer.userAnswer.pointValue;
        }
        totalIndex += userAnswer.userAnswer.pointValue;
    }

    public void push_back_FRQ(FRQ userFRQ)
    {
        FRQ FRQCopy = Instantiate(userFRQ);
        FRQ = FRQCopy;
    }

    public void setDate()
    {
        date = System.DateTime.Now.ToString("MM/dd");
    }

    public void Start()
    {
        
    }
}
