using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whiteboard : MonoBehaviour
{
    Collider2D col;
    SpriteRenderer this_sprite;
    bool touched;

    void Start()
    {
        col = GetComponent<Collider2D>();
        this_sprite = GetComponent<SpriteRenderer>();
        touched = false;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            
            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchedCollider)
                {
                    touched = true;
                    Debug.Log("touched whiteboard");
                }
            }
            if (touch.phase == TouchPhase.Stationary)
            {
                if (touched)
                {
                    Debug.Log("touched");
                }
            }
            if (touch.phase == TouchPhase.Ended)
            {
                if (touched)
                {
                    Debug.Log("touch end");
                    touched = false;
                }
            }
        }
    }
}
