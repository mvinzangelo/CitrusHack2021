using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LocalSave
{
    // Start is called before the first frame update
    public static void SaveGame(Flower currentFlower)
    {
        PlayerPrefs.SetInt("growthLevel", currentFlower.growthLevel);
        PlayerPrefs.SetInt("progressToNextLevel", currentFlower.progressToNextLevel);
        PlayerPrefs.SetInt("timeSinceLastWater", currentFlower.timeSinceLastWater);
        PlayerPrefs.SetInt("expPerLevel", currentFlower.expPerLevel);
        PlayerPrefs.SetInt("expToGrow", currentFlower.expToGrow);
        PlayerPrefs.SetInt("wateringInterval", currentFlower.wateringInterval);
        PlayerPrefs.SetInt("randomNumber", currentFlower.randomNumber);
        PlayerPrefs.SetString("flowerName", currentFlower.flowerName);

    }

    public static Flower LoadGame()
    {
        Flower data = new Flower(PlayerPrefs.GetString("flowerName"));
        data.growthLevel = PlayerPrefs.GetInt("growthLevel");
        data.progressToNextLevel = PlayerPrefs.GetInt("progressToNextLevel");
        data.timeSinceLastWater = PlayerPrefs.GetInt("timeSinceLastWater");
        data.expPerLevel = PlayerPrefs.GetInt("expPerLevel");
        data.expToGrow = PlayerPrefs.GetInt("expToGrow");
        data.wateringInterval = PlayerPrefs.GetInt("wateringInterval");
        data.randomNumber = PlayerPrefs.GetInt("randomNumber");
        return data;
    }
}
