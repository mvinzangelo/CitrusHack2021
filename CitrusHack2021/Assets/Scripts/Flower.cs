using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: ADD SAVE AND LOAD TO KEEP FLOWER PROGRESS
public class Flower : MonoBehaviour
{
    [SerializeField] QuestionPrompt questionPrompt;
    private static Flower _instance;
    private readonly string[] names = { "Holly", "Lilly", "Pointy", "Katniss", "Bloomy", "Sneezy", "Smeagol", "Chungus", "Baba", "Corny" };

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

    //public Sprite[] spriteArray;
    //public SpriteRenderer spriteRenderer;

    public Flower()
    {
        growthLevel = 0;
        progressToNextLevel = 0;
        timeSinceLastWater = 0;
        flowerName = names[Random.Range(0,9)];
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
        //spriteArray = copy.spriteArray;
        //spriteRenderer = copy.spriteRenderer;
    }

    public int currentGrowthLevel() { return growthLevel; }
    public int currentProgressToNextLevel() { return progressToNextLevel; }
    public int currentTimeSinceLastWater() { return timeSinceLastWater; }
    public string getFlowerName() { return flowerName; }
    public bool needsWatering() { return needsWater; }
    public bool Grew() { return grow; }
    public void UpdateGrow() { grow = false; }

    //public void UpdateSprite()
    //{
    //spriteRenderer.sprite = spriteArray[growthLevel];
    //}


    public void checkIfGrow()
    {
        if (progressToNextLevel >= expToGrow)
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
    public void SetFlowerName(string s)
    {
        flowerName = s;
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

    public void SaveFlower()
    {
        LocalSave.SaveGame(this);
    }

    public void LoadFlower()
    {
        Flower copy = LocalSave.LoadGame();

        growthLevel = copy.growthLevel;
        progressToNextLevel = copy.progressToNextLevel;
        timeSinceLastWater = copy.timeSinceLastWater;
        flowerName = copy.flowerName;
        expPerLevel = copy.expPerLevel;
        expToGrow = copy.expToGrow;
        wateringInterval = copy.wateringInterval;
        needsWater = copy.needsWater;
        randomNumber = copy.randomNumber;
        grow = copy.grow;
    }
    private void Start()
    {

        //UpdateSprite();
        //LoadFlower();
        InvokeRepeating(nameof(WaterTimer), 1, 1);
        InvokeRepeating(nameof(GetRandomNumber), 5, 5);
    }

    private void Update()
    {
        questionPrompt = FindObjectOfType<QuestionPrompt>();
        if (timeSinceLastWater > wateringInterval)
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
                    grow = false;
                    needsWater = false;
                    if (!questionPrompt.allQuestionsAsked())
                    {
                        questionPrompt.LoadNewQuestion();
                    }

                    //Invoke("UpdateSprite", 10.0f);

                }
            }
        }
    }
}
