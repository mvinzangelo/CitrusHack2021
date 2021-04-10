using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: ADD SAVE AND LOAD TO KEEP FLOWER PROGRESS
public class Flower : MonoBehaviour
{
    public int growthLevel;
    public int progressToNextLevel;
    public int timeSinceLastWater;
    public string flowerName;

    public Sprite[] spriteArray;
    public SpriteRenderer spriteRenderer;

    public Flower(string userName)
    {
        growthLevel = 0;
        progressToNextLevel = 0;
        timeSinceLastWater = 0;
        flowerName = userName;
    }

    public void UpdateSprite()
    {
        spriteRenderer.sprite = spriteArray[growthLevel];
    }

    public void WaterTimer()
    {
        timeSinceLastWater++;
    }

    private void Start()
    {
        UpdateSprite();
        InvokeRepeating(nameof(WaterTimer), 1, 1); // will increase timeSinceLastWater by 1 every second
    }

    private void Update()
    {
        UpdateSprite();
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 pos = touch.position;
                Debug.Log("touching");
                // TODO: ADD WATERING FUNCTIONALITY W PARTICLES
                timeSinceLastWater = 0;
            }
        }
    }
}

