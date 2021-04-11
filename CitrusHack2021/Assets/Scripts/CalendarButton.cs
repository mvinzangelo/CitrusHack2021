using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalendarButton : MonoBehaviour
{
    public GameObject questions;
    List<string> QandA;
    public Data data;
    public GameObject panel;
    public PanelReveal reveal;

    private void Start()
    {
        data = FindObjectOfType<Data>();
    }

    public void Day1()
    {
        reveal.openPanel();    
        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[0].answers[i].quesiton + " - " + data.days[0].answers[i].userAnswer + '\n';
        }
    }
    public void Day2()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {

            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[1].answers[i].quesiton + " - " + data.days[1].answers[i].userAnswer + '\n';
        }
    }
    public void Day3()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[2].answers[i].quesiton + " - " + data.days[2].answers[i].userAnswer + '\n';
        }
    }
    public void Day4()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[3].answers[i].quesiton + " - " + data.days[3].answers[i].userAnswer + '\n';
        }
    }
    public void Day5()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[4].answers[i].quesiton + " - " + data.days[4].answers[i].userAnswer + '\n';
        }
    }
    public void Day6()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[5].answers[i].quesiton + " - " + data.days[5].answers[i].userAnswer + '\n';
        }
    }
    public void Day7()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[6].answers[i].quesiton + " - " + data.days[6].answers[i].userAnswer + '\n';
        }
    }
    public void Day8()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[7].answers[i].quesiton + " - " + data.days[7].answers[i].userAnswer + '\n';
        }
    }
    public void Day9()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[8].answers[i].quesiton + " - " + data.days[8].answers[i].userAnswer + '\n';
        }
    }
    public void Day10()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[9].answers[i].quesiton + " - " + data.days[9].answers[i].userAnswer + '\n';
        }
    }
    public void Day11()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[10].answers[i].quesiton + " - " + data.days[10].answers[i].userAnswer + '\n';
        }
    }
    public void Day12()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[11].answers[i].quesiton + " - " + data.days[11].answers[i].userAnswer + '\n';
        }
    }
    public void Day13()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[12].answers[i].quesiton + " - " + data.days[12].answers[i].userAnswer + '\n';
        }
    }
    public void Day14()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[13].answers[i].quesiton + " - " + data.days[13].answers[i].userAnswer + '\n';
        }
    }
    public void Day15()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[14].answers[i].quesiton + " - " + data.days[14].answers[i].userAnswer + '\n';
        }
    }
    public void Day16()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[15].answers[i].quesiton + " - " + data.days[15].answers[i].userAnswer + '\n';
        }
    }
    public void Day17()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[16].answers[i].quesiton + " - " + data.days[16].answers[i].userAnswer + '\n';
        }
    }
    public void Day18()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[17].answers[i].quesiton + " - " + data.days[17].answers[i].userAnswer + '\n';
        }
    }
    public void Day19()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[18].answers[i].quesiton + " - " + data.days[18].answers[i].userAnswer + '\n';
        }
    }
    public void Day20()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[19].answers[i].quesiton + " - " + data.days[19].answers[i].userAnswer + '\n';
        }
    }
    public void Day21()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[20].answers[i].quesiton + " - " + data.days[20].answers[i].userAnswer + '\n';
        }
    }
    public void Day22()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[21].answers[i].quesiton + " - " + data.days[21].answers[i].userAnswer + '\n';
        }
    }
    public void Day23()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[22].answers[i].quesiton + " - " + data.days[22].answers[i].userAnswer + '\n';
        }
    }
    public void Day24()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[23].answers[i].quesiton + " - " + data.days[23].answers[i].userAnswer + '\n';
        }
    }
    public void Day25()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[24].answers[i].quesiton + " - " + data.days[24].answers[i].userAnswer + '\n';
        }
    }
    public void Day26()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[25].answers[i].quesiton + " - " + data.days[25].answers[i].userAnswer + '\n';
        }
    }
    public void Day27()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[26].answers[i].quesiton + " - " + data.days[26].answers[i].userAnswer + '\n';
        }
    }
    public void Day28()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[27].answers[i].quesiton + " - " + data.days[27].answers[i].userAnswer + '\n';
        }
    }
    public void Day29()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[28].answers[i].quesiton + " - " + data.days[28].answers[i].userAnswer + '\n';
        }
    }
    public void Day30()
    {
        reveal.openPanel();

        for (int i = 0; i < data.days.Count; i++)
        {
            panel.gameObject.transform.Find("DataText").GetComponentInChildren<TextMeshProUGUI>().text += data.days[29].answers[i].quesiton + " - " + data.days[29].answers[i].userAnswer + '\n';
        }
    }

}
