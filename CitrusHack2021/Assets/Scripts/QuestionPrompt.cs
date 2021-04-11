using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class QuestionPrompt : MonoBehaviour
{
    [SerializeField] CameraMovement cam;
    [SerializeField] Data data;
    [SerializeField] Days dayTemplate;
    Days day;
    bool isActive = false;
    public Question[] questions;
    public GameObject panel;
    int currentQuestion;
    bool pushedBack = false;
    bool pushedDayBack = false;

    // singleton code
    private static QuestionPrompt _instance;

    private void Awake()
    {
        if (_instance == null)
        {

            _instance = this;
            DontDestroyOnLoad(this.gameObject);

            //Rest of your Awake code

        }
        else
        {
            Destroy(this);
        }

        panel.SetActive(false);
    }
    void Start()
    {
        cam = FindObjectOfType<CameraMovement>(); 
        day = Instantiate(dayTemplate);
        day.transform.parent = transform;
        for (int i = 0; i < 10; i++)
        {
            questions[i].askedToday = false;
        }
        currentQuestion = Random.Range(0, 10);
        day.date = System.DateTime.Now.ToString("MM/dd");
    }

    private void Update()
    {

    }
    public void LoadNewQuestion()
    {
        cam = FindObjectOfType<CameraMovement>();
        if (cam.currentPosition == 1)
        {
            questions[currentQuestion].askedToday = true;
            pushedBack = false;
            pushedDayBack = false;
            panel.SetActive(true);
            panel.gameObject.transform.Find("Answer1").GetComponent<Button>().onClick.AddListener(setAnswerToOne);
            panel.gameObject.transform.Find("Answer2").GetComponent<Button>().onClick.AddListener(setAnswerToTwo);
            panel.gameObject.transform.Find("Answer3").GetComponent<Button>().onClick.AddListener(setAnswerToThree);
            panel.gameObject.transform.Find("Answer4").GetComponent<Button>().onClick.AddListener(setAnswerToFour);
            panel.gameObject.transform.Find("Answer5").GetComponent<Button>().onClick.AddListener(setAnswerToFive);

            questions[currentQuestion].userAnswer = null;

            panel.gameObject.transform.Find("Question").GetComponentInChildren<TextMeshProUGUI>().text = questions[currentQuestion].quesiton;

            // change button text
            panel.gameObject.transform.Find("Answer1").GetComponentInChildren<TextMeshProUGUI>().text = questions[currentQuestion].answers[0].answer;
            panel.gameObject.transform.Find("Answer2").GetComponentInChildren<TextMeshProUGUI>().text = questions[currentQuestion].answers[1].answer;
            panel.gameObject.transform.Find("Answer3").GetComponentInChildren<TextMeshProUGUI>().text = questions[currentQuestion].answers[2].answer;
            panel.gameObject.transform.Find("Answer4").GetComponentInChildren<TextMeshProUGUI>().text = questions[currentQuestion].answers[3].answer;
            panel.gameObject.transform.Find("Answer5").GetComponentInChildren<TextMeshProUGUI>().text = questions[currentQuestion].answers[4].answer;
        }
    }

    public void setAnswerToOne()
    {
        questions[currentQuestion].userAnswer = questions[currentQuestion].answers[0];
        if (!pushedBack)
        {
            day.push_back_question(questions[currentQuestion]);
            pushedBack = true;
        }
        panel.SetActive(false);
        if (!allQuestionsAsked())
        {
            currentQuestion = Random.Range(0, 10);
            while (questions[currentQuestion].askedToday == true)
            {
                currentQuestion = Random.Range(0, 10);
            }
        }
    }
    public void setAnswerToTwo()
    {
        questions[currentQuestion].userAnswer = questions[currentQuestion].answers[1];
        if (!pushedBack)
        {
            day.push_back_question(questions[currentQuestion]);
            pushedBack = true;
        }
        panel.SetActive(false);
        if (!allQuestionsAsked())
        {
            currentQuestion = Random.Range(0, 10);
            while (questions[currentQuestion].askedToday == true)
            {
                currentQuestion = Random.Range(0, 10);
            }
        }
    }
    public void setAnswerToThree()
    {
        questions[currentQuestion].userAnswer = questions[currentQuestion].answers[2];
        if (!pushedBack)
        {
            day.push_back_question(questions[currentQuestion]);
            pushedBack = true;
        }
        panel.SetActive(false);
        if (!allQuestionsAsked())
        {
            currentQuestion = Random.Range(0, 10);
            while (questions[currentQuestion].askedToday == true)
            {
                currentQuestion = Random.Range(0, 10);
            }
        }
    }
    public void setAnswerToFour()
    {
        questions[currentQuestion].userAnswer = questions[currentQuestion].answers[3];
        if (!pushedBack)
        {
            day.push_back_question(questions[currentQuestion]);
            pushedBack = true;
        }
        panel.SetActive(false);
        if (!allQuestionsAsked())
        {
            currentQuestion = Random.Range(0, 10);
            while (questions[currentQuestion].askedToday == true)
            {
                currentQuestion = Random.Range(0, 10);
            }
        }
    }
    public void setAnswerToFive()
    {
        questions[currentQuestion].userAnswer = questions[currentQuestion].answers[4];
        if (!pushedBack)
        {
            day.push_back_question(questions[currentQuestion]);
            pushedBack = true;
        }
        panel.SetActive(false);
        if (!allQuestionsAsked())
        {
            currentQuestion = Random.Range(0, 10);
            while (questions[currentQuestion].askedToday == true)
            {
                currentQuestion = Random.Range(0, 10);
            }
        }
    }

    public bool allQuestionsAsked()
    {
        int counter = 0;
        for (int i = 0; i < 10; i++)
        {
            if (questions[i].askedToday == true)
            {
                counter++;
            }
        }
        if (counter == 10)
        {
            if (!pushedDayBack)
            {
                data.push_back_day(day);
                pushedDayBack = true;
                day = Instantiate(dayTemplate);
                day.transform.parent = gameObject.transform;
                day.date = System.DateTime.Now.ToString("MM/dd");
                for (int i = 0; i < 10; i++)
                {
                    questions[i].askedToday = false;
                }
                currentQuestion = Random.Range(0, 10);
            }
            return true;
        }
        return false;
    }

    public void setPlantActive()
    {
        isActive = true;
    }

    public void deactivatePlantScene()
    {
        isActive = false;
    }
}
