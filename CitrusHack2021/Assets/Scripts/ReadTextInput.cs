using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReadTextInput : MonoBehaviour
{
    public string theName;
    public GameObject inputField;

    public void StoreName()
    {
        inputField.GetComponent<InputField>();
        theName = inputField.GetComponent<Text>().text;
        Debug.Log(theName);
    }

}
