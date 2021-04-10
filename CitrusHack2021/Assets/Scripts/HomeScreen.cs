using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScreen : MonoBehaviour
{
    public CameraMovement gameCamera;
    public QuestionPrompt questionPrompt;

    public void Update()
    {
        if (gameCamera.currentPosition == 1)
        {
            questionPrompt.setPlantActive();
        }
        else
        {
            questionPrompt.deactivatePlantScene();
        }
    }
}
