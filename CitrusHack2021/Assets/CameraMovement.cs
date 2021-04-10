using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraMoveSpeed = 5.0f;
    int currentPosition = 1;
    [SerializeField] GameObject[] positions;

    private void Awake()
    {
        SwipeDetector.OnSwipe += SwipeDetector_OnSwipe;
    }

    private void Start()
    {
        transform.position = positions[currentPosition].transform.position;
    }
    private void Update()
    {
        if (transform.position != positions[currentPosition].transform.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, positions[currentPosition].transform.position, cameraMoveSpeed * Time.deltaTime);
        }
    }

    private void SwipeDetector_OnSwipe(SwipeData data)
    {
        if (data.Direction == SwipeDirection.Left)
        {
            if (currentPosition > 0)
            {
                currentPosition--;
            }
        }
        if (data.Direction == SwipeDirection.Right)
        {
            if (currentPosition < 3)
            {
                currentPosition++;
            }
        }
    }
}
