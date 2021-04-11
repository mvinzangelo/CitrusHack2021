using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayName : MonoBehaviour
{
    [SerializeField] Flower flower;
    [SerializeField] TextMeshProUGUI text;

    private void Start()
    {
        flower = FindObjectOfType<Flower>();
        text.text = flower.name;
    }
}
