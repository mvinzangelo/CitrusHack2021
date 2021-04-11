using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: ADD SAVE AND LOAD TO KEEP FLOWER PROGRESS
public class Flower : MonoBehaviour
{
    [SerializeField] QuestionPrompt questionPrompt;

    public int growthLevel;
    public int progressToNextLevel;
    public int timeSinceLastWater;
    public string flowerName;

    public int expPerLevel;         // exp gained every time you water when the plant needs it
    public int expToGrow;           // how much exp to grow to next phase
    public int wateringInterval;    // how often, in seconds, you need to water the plant
    public bool needsWater;         // if true, you can water the plant for xp.
    public int randomNumber;
    public bool grow;               // if true, the plant grew. use this for events involving growth.

    public Sprite[] spriteArray;
    public SpriteRenderer spriteRenderer;

    public Flower(string userName)
    {
        growthLevel = 0;
        progressToNextLevel = 0;
        timeSinceLastWater = 0;
        flowerName = userName;
    }

    // copy constructor
    public Flower(Flower copy)
    {
        growthLevel = copy.growthLevel;
        progressToNextLevel = copy.progressToNextLevel;
        timeSinceLastWater = copy.progressToNextLevel;
        flowerName = copy.flowerName;
        expPerLevel = copy.expPerLevel;
        expToGrow = copy.expToGrow;
        wateringInterval = copy.wateringInterval;
        needsWater = copy.needsWater;
        randomNumber = copy.randomNumber;
        grow = copy.grow;
        spriteArray = copy.spriteArray;
        spriteRenderer = copy.spriteRenderer;
    }

    public int currentGrowthLevel() { return growthLevel; }
    public int currentProgressToNextLevel() { return progressToNextLevel; }
    public int currentTimeSinceLastWater() { return timeSinceLastWater; }
    public string getFlowerName() { return flowerName; }
    public bool needsWatering() { return needsWater; }
    public bool Grew() { return grow; }
    public void UpdateGrow() { grow = false; }

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
                grow = true;
                Debug.Log("I should only print once.");
            }
        }
    }

    public void WaterTimer()
    {
        timeSinceLastWater++;
    }
    public int GetRandomNumber() 
    {
        randomNumber = Random.Range(1, 100);
        return randomNumber;  
    }
    /*
    public void SaveFlower()
    {
        Save.SaveFlower(this);
    }
    public void LoadFlower()
    {
        Flower copy = Save.LoadFlower();
        growthLevel = copy.growthLevel;
        progressToNextLevel = copy.progressToNextLevel;
        timeSinceLastWater = copy.progressToNextLevel;
        flowerName = copy.flowerName;
        expPerLevel = copy.expPerLevel;
        expToGrow = copy.expToGrow;
        wateringInterval = copy.wateringInterval;
        needsWater = copy.needsWater;
        randomNumber = copy.randomNumber;
        grow = copy.grow;
        spriteArray = copy.spriteArray;
        spriteRenderer = copy.spriteRenderer;
    }
    */
    private void Start()
    {
        //LoadFlower();
        UpdateSprite();
        InvokeRepeating(nameof(WaterTimer), 1, 1);
        InvokeRepeating(nameof(GetRandomNumber), 5, 5);
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
                    if (!questionPrompt.allQuestionsAsked())
                    {
                        questionPrompt.LoadNewQuestion();
                    }
                    timeSinceLastWater = 0;
                    progressToNextLevel += expPerLevel;
                    checkIfGrow();
                    grow = false;
                    needsWater = false;
                    Invoke("UpdateSprite", 10.0f);
                }
            }
        }
    }
}

