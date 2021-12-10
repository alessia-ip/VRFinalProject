using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/TouchingScriptableObject", order = 1)]

public class TouchingScriptableObject : ScriptableObject
{
    public bool isTouching = false;
}
