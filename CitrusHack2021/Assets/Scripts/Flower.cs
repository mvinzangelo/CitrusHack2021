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

    public int expPerLevel;         // exp gained every time you water when the plant needs it
    public int expToGrow;           // how much exp to grow to next phase
    public int wateringInterval;    // how often, in seconds, you need to water the plant
    public bool needsWater;         // if true, you can water the plant for xp.

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
        if (timeSinceLastWater == 300)
        {
            needsWater = true;
        }
        if (progressToNextLevel == expToGrow)
        {
            progressToNextLevel = 0;
            if (growthLevel < 4)
            {
                growthLevel++;
            }
        }
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                Debug.Log("touching");
                // TODO: ADD WATERING FUNCTIONALITY W PARTICLES
                if (needsWater)
                {
                    timeSinceLastWater = 0;
                    progressToNextLevel += expPerLevel;
                    needsWater = false; 
                }
            }
        }
    }
}

