using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whiteboard : MonoBehaviour
{
    Collider2D col;
    public SceneLoader sceneLoader;

    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    private void Update()
    {
        if (Input.touchCount != 1) return;

        var wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        var touchPos = new Vector2(wp.x, wp.y);

        if (col == Physics2D.OverlapPoint(touchPos))
        {
            sceneLoader.GoToWhiteboard();
        }
    }
}
