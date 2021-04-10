using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Answer", menuName = "Answer")]

public class Answer : ScriptableObject
{
    public string answer;
    public int pointValue;
    public bool nullAnswer;
}

