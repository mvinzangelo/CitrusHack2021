using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: ADD SAVE AND LOAD TO KEEP FLOWER PROGRESS
public class Flower : MonoBehaviour
{
    public int growthLevel;
    public int timeSinceLastWater;
    public string flowerName;

    public Sprite[] spriteArray;
    public SpriteRenderer spriteRenderer;

    public Flower(string userName)
    {
        growthLevel = 0;
        timeSinceLastWater = 0;
        flowerName = userName;
    }

    public void UpdateSprite()
    {
        spriteRenderer.sprite = spriteArray[growthLevel];
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

