using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantInteraction : MonoBehaviour
{
    public GameObject canvas;
    public GameObject questionPrompt;
    public GameObject panel;
    public Question[] quesitons;

    private void Awake()
    {
        panel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            LoadNewQuestion();
        }
    }
    void LoadNewQuestion()
    {
        panel.SetActive(true);
    }
}
