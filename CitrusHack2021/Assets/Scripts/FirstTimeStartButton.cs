using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstTimeStartButton : MonoBehaviour
{
    [SerializeField] private string level;

    public void MoveScenes(string level)
    {
        SceneManager.LoadScene(level);
    }
}
