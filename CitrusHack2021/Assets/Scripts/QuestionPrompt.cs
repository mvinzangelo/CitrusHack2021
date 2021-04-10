using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class QuestionPrompt : MonoBehaviour
{
    public Question question;
    public GameObject panel; 
    Button questionText;
    Button a1;
    Button a2;
    Button a3;
    Button a4;
    Button a5;

    private void Awake()
    {
        panel.gameObject.transform.Find("Answer1").GetComponent<Button>().onClick.AddListener(setAnswerToOne);
        panel.gameObject.transform.Find("Answer2").GetComponent<Button>().onClick.AddListener(setAnswerToTwo);
        panel.gameObject.transform.Find("Answer3").GetComponent<Button>().onClick.AddListener(setAnswerToThree);
        panel.gameObject.transform.Find("Answer4").GetComponent<Button>().onClick.AddListener(setAnswerToFour);
        panel.gameObject.transform.Find("Answer5").GetComponent<Button>().onClick.AddListener(setAnswerToFive);
    }
    void Start()
    {
        question.userAnswer = null;

        panel.gameObject.transform.Find("Question").GetComponentInChildren<TextMeshProUGUI>().text = question.quesiton;

        // change button text
        panel.gameObject.transform.Find("Answer1").GetComponentInChildren<TextMeshProUGUI>().text = question.answers[0].answer;
        panel.gameObject.transform.Find("Answer2").GetComponentInChildren<TextMeshProUGUI>().text = question.answers[1].answer;
        panel.gameObject.transform.Find("Answer3").GetComponentInChildren<TextMeshProUGUI>().text = question.answers[2].answer;
        panel.gameObject.transform.Find("Answer4").GetComponentInChildren<TextMeshProUGUI>().text = question.answers[3].answer;
        panel.gameObject.transform.Find("Answer5").GetComponentInChildren<TextMeshProUGUI>().text = question.answers[4].answer;
    }

    public void setAnswerToOne()
    {
        question.userAnswer = question.answers[0];
    }
    public void setAnswerToTwo()
    {
        question.userAnswer = question.answers[1];
    }
    public void setAnswerToThree()
    {
        question.userAnswer = question.answers[2];
    }
    public void setAnswerToFour()
    {
        question.userAnswer = question.answers[3];
    }
    public void setAnswerToFive()
    {
        question.userAnswer = question.answers[4];
    }
}
