using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/TouchingScriptableObject", order = 1)]

public class TouchingScriptableObject : ScriptableObject
{
    //this makes the 'touching' variable accessible to other scripts more easily
    //since it's a scriptable object
    public bool isTouching = false;
}
