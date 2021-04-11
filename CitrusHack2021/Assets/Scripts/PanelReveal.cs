using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelReveal : MonoBehaviour
{
    public GameObject Panel;

    public void openPanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Vector3 wp = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            if (GetComponent<Collider2D>().OverlapPoint(wp))
            {
                openPanel();
                Debug.Log("Hello");
            }
        }
    }
}
