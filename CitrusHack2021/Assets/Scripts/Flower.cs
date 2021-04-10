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

    public int currentGrowthLevel() { return growthLevel; }
    public int currentProgressToNextLevel() { return progressToNextLevel; }
    public int currentTimeSinceLastWater() { return timeSinceLastWater; }
    public string getFlowerName() { return flowerName; }

    public bool needsWatering() { return needsWater; }

    public void UpdateSprite()
    {
        spriteRenderer.sprite = spriteArray[growthLevel];
    }

    public void checkIfGrow()
    {
        if (progressToNextLevel == expToGrow)
        {
            progressToNextLevel = 0;
            if (growthLevel < 4)
            {
                growthLevel++;
            }
        }
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
        if (timeSinceLastWater == wateringInterval)
        {
            needsWater = true;
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                Debug.Log("touching");
                if (needsWater)
                {
                    timeSinceLastWater = 0;
                    progressToNextLevel += expPerLevel;
                    checkIfGrow();
                    needsWater = false;
                    Invoke("UpdateSprite", 10.0f);
                }
            }
        }
    }
}

