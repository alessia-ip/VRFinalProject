using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public TouchingScriptableObject touching;

    //checks if the player's hand is in contact with the ukulele strings
    
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
