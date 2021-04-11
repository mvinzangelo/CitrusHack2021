using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShowLatestEntry : MonoBehaviour
{
    [SerializeField] Data data;
    [SerializeField] TextMeshProUGUI date;
    [SerializeField] TextMeshProUGUI QandA;
    // Start is called before the first frame update
    void Start()
    {
        data = FindObjectOfType<Data>();
        date.text = data.days[data.days.Count - 1].date;
        for (int i = 0; i < 10; i++)
        {
            QandA.text += "Q: " + data.days[data.days.Count - 1].answers[i].quesiton + " - A: " + data.days[data.days.Count - 1].answers[i].userAnswer.answer + '\n';
        }
    }
}
