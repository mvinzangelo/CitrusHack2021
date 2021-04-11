using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSprite : MonoBehaviour
{
    public Sprite[] spriteArray;
    public SpriteRenderer spriteRenderer;
    Flower currentFlower;

    public void UpdateSprite()
    {
        spriteRenderer.sprite = spriteArray[currentFlower.currentGrowthLevel()];
    }
    // Start is called before the first frame update
    void Start()
    {
        currentFlower = FindObjectOfType<Flower>();
        Invoke("UpdateSprite", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("UpdateSprite", 25.0f);
    }
}
