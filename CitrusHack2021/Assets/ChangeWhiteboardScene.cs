using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeWhiteboardScene : MonoBehaviour
{
    private Vector3 fp;   //First touch position
    private Vector3 lp;   //Last touch position
    private float dragDistance;  //minimum distance for a swipe to be registered

    private void Start()
    {
        dragDistance = Screen.height * 15 / 100;
    }
    private void Update()
    {

        if (Input.touchCount == 1) // user is touching the screen with a single touch
        {
            Touch touch = Input.GetTouch(0); // get the touch
            if (touch.phase == TouchPhase.Began) //check for the first touch
            {
                fp = touch.position;
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Moved) // update the last position based on where they moved
            {
                lp = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended) //check if the finger is removed from the screen
            {
                lp = touch.position;  //last touch position. Ommitted if you use list

                //Check if drag distance is greater than 20% of the screen height
                if (Mathf.Abs(lp.x - fp.x) > dragDistance || Mathf.Abs(lp.y - fp.y) > dragDistance)
                {//It's a drag
                 //check if the drag is vertical or horizontal
                    if (Mathf.Abs(lp.x - fp.x) > Mathf.Abs(lp.y - fp.y))
                    {   //If the horizontal movement is greater than the vertical movement...
                        if ((lp.x > fp.x))  //If the movement was to the right)
                        {   //Right swipe
                            if (SceneManager.GetActiveScene().name != "MentalHealth")
                            {
                                SceneManager.LoadScene("MentalHealth");
                            }
                        }
                        else
                        {   //Left swipe
                            if (SceneManager.GetActiveScene().name != "PhysicalHealth")
                            {
                                SceneManager.LoadScene("PhysicalHealth");
                            }
                        }
                    }
                    else
                    {   //the vertical movement is greater than the horizontal movement
                        if (lp.y > fp.y)  //If the movement was up
                        {   //Up swipe
                            if (SceneManager.GetActiveScene().name != "Overall Health")
                            {
                                SceneManager.LoadScene("Overall Health");
                            }
                            return;
                        }
                        else
                        {   //Down swipe
                            SceneManager.LoadScene("PlantScreen");
                            return;
                        }
                    }
                }
                else
                {   //It's a tap as the drag distance is less than 20% of the screen height
                    return;
                }
            }
        }
    }
}
