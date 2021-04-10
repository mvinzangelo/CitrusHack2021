using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraMoveSpeed = 5.0f;
    public int currentPosition = 1;
    [SerializeField] GameObject[] positions;

    // swipe controls
    private void Awake()
    {

    }

    private void Start()
    {
        currentPosition = PlayerPrefs.GetInt("Position");
        transform.position = positions[currentPosition].transform.position;
        dragDistance = Screen.height * 15 / 100;
    }
    private void Update()
    {
        if (transform.position != positions[currentPosition].transform.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, positions[currentPosition].transform.position, cameraMoveSpeed * Time.deltaTime);
        }

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
                            if (currentPosition > 0)
                            {
                                currentPosition--;
                                PlayerPrefs.SetInt("Position", currentPosition);
                            }
                        }
                        else
                        {   //Left swipe
                            if (currentPosition < 3)
                            {
                                currentPosition++;
                                PlayerPrefs.SetInt("Position", currentPosition);
                            }
                        }
                    }
                    else
                    {   //the vertical movement is greater than the horizontal movement
                        if (lp.y > fp.y)  //If the movement was up
                        {   //Up swipe
                            return;
                        }
                        else
                        {   //Down swipe
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

    private Vector3 fp;   //First touch position
    private Vector3 lp;   //Last touch position
    private float dragDistance;  //minimum distance for a swipe to be registered
}
