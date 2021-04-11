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
  
}
