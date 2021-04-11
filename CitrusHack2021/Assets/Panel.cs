using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    private static Panel _instance;

    void Awake()
    {

        if (_instance == null)
        {

            _instance = this;
            DontDestroyOnLoad(this.gameObject);

            //Rest of your Awake code

        }
        else
        {
            Destroy(this);
        }
    }
}
