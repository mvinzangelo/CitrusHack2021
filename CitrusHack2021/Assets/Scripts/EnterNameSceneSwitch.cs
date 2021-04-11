using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterNameSceneSwitch : MonoBehaviour
{
    public void MoveToMainScene()
    {
        SceneManager.LoadScene("PlantScreen");
    }
}
