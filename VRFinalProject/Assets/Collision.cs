using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public TouchingScriptableObject touching;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hand")
        {
            touching.isTouching = true;
        }
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "hand")
        {
            touching.isTouching = true;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "hand")
        {
            touching.isTouching = false;
        }
    }
}
