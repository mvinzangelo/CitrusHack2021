using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{

    //singleton code
    private static Data _instance;

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

    public List<Days> days;

    public float totalPhysicalIndex = 0;
    public float totalMentalIndex = 0;
    public float totalWellnessIndex = 0;

    public float maxPhysicalIndex = 0;
    public float maxMentalIndex = 0;
    public float maxIndex = 0;

    public float physicalRating = 0f;
    public float mentalRating = 0f;
    public float totalRating = 0f;
    
    public void push_back_day(Days day)
    {
        Days currDay = day;
        days.Add(currDay);
        maxIndex += 50;
        maxPhysicalIndex += 25;
        maxMentalIndex += 25;

        totalPhysicalIndex += day.physicalIndex;
        totalMentalIndex += day.mentalIndex;
        totalWellnessIndex += day.totalIndex;

        physicalRating = totalPhysicalIndex / maxPhysicalIndex;
        mentalRating = totalMentalIndex / maxMentalIndex;
        mentalRating = totalMentalIndex / maxMentalIndex;
    }
}
