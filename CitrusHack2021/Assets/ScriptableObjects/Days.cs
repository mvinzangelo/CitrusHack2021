using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Days", menuName = "Days")]
public class Days
{
    public string date;
    public Question[] answers;
    public int physicalIndex;
    public int mentalIndex;
    public int totalIndex;
    public FRQ FRQ;
}
