using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneLoader : MonoBehaviour
{
    public void GoToHomeScreen()
    {
        SceneManager.LoadScene("PlantScreen", LoadSceneMode.Single);
    }

    public void GoToWhiteboard()
    {
        SceneManager.LoadScene("Overall Health", LoadSceneMode.Single);
    }

    public void GoToThermastat()
    {
        SceneManager.LoadScene("ThermostatScreen", LoadSceneMode.Single);
    }

    public void GoToCalendar()
    {
        SceneManager.LoadScene("CalendarScreen", LoadSceneMode.Single);
    }
}
