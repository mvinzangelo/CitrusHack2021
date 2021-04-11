using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data
{
    public List<Days> days;

    public int totalPhysicalIndex = 0;
    public int totalMentalIndex = 0;
    public int totalWellnessIndex = 0;

    public int maxPhysicalIndex = 0;
    public int maxMentalIndex = 0;
    public int maxIndex = 0;

    public double physicalRating = 0f;
    public double mentalRating = 0f;
    public double totalRating = 0f;
    
    public void push_back_day(Days day)
    {
        Days currDay = day;
        days.Add(currDay);
        maxIndex += 100;
        maxPhysicalIndex += 50;
        maxMentalIndex += 50;

        totalPhysicalIndex += day.physicalIndex;
        totalMentalIndex += day.mentalIndex;
        totalWellnessIndex += day.totalIndex;

        physicalRating = (1.0 * totalPhysicalIndex) / (1.0 * maxPhysicalIndex);
        mentalRating = (1.0 * totalMentalIndex) / (1.0 * maxMentalIndex);
        mentalRating = (1.0 * totalMentalIndex) / (1.0 * maxMentalIndex);
    }
}
