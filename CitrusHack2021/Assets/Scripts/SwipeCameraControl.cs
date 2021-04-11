using UnityEngine;

public class SwipeCameraControl : MonoBehaviour
{
    public CameraMovement gameCam;
    private void Awake()
    {
        SwipeDetector.OnSwipe += SwipeDetector_OnSwipe;
    }

    private void SwipeDetector_OnSwipe(SwipeData data)
    {
        if (data.Direction == SwipeDirection.Right)
        {
            if (gameCam.currentPosition > 0)
            {
                //gameCam.currentPosition--;
                //PlayerPrefs.SetInt("Position", gameCam.currentPosition);
            }
        }
        if (data.Direction == SwipeDirection.Left)
        {
            if (gameCam.currentPosition < 3)
            {
                //gameCam.currentPosition++;
                //PlayerPrefs.SetInt("Position", gameCam.currentPosition);
            }
        }
    }
}