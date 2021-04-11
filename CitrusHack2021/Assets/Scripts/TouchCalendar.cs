using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchCalendar : MonoBehaviour
{
    public GameObject Panel;


    public void openPanel()
    {
        if(Panel != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);        }
    }

    string data1 = "Yes";
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            openPanel();
            Debug.Log("Hello");
        }
        /*if (Input.touchCount > .2                                                                                      )
         {
             Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
             if (GetComponent<Collider2D>().OverlapPoint(wp))
             {
                 openPanel();
                 Debug.Log("Hello");


             }
         }*/
    }
}
