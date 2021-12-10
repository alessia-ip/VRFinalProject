using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class TriggerNextBird : MonoBehaviour
{
    public bool noteOneLearned;
    public bool noteTwoLearned;
    public bool noteThreeLearned;
    public bool noteFourLearned;
    
    public InputActionAsset _actionBasedController;

    public UkuleleChordRegister _chord;

    public GameObject birdTwo;
    public GameObject birdFive;
    public GameObject birdSeven;
    public GameObject birdSix;

    public TouchingScriptableObject _Touching;
    
    public AudioSource aud;
    public AudioClip success;
    bool flourish = false;
    
    // Start is called before the first frame update
    void Start()
    {
        _actionBasedController.Enable();

        _actionBasedController["RightStrum"].performed += CheckStrum;

    }

    private void Update()
    {
        if (noteFourLearned && noteOneLearned && noteTwoLearned && noteThreeLearned && !flourish)
        {
            flourish = true;
            aud.PlayOneShot(success);
        }
    }

    private void CheckStrum(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        if (!noteOneLearned && _Touching.isTouching)
        {
            if (_chord.currentClip == _chord.C)
            {
                noteOneLearned = true;
                birdTwo.GetComponent<Animator>().SetBool("play", true);
            }
        }
        
        if (!noteTwoLearned && _Touching.isTouching)
        {
            if (_chord.currentClip == _chord.F)
            {
                noteTwoLearned = true;
                birdFive.GetComponent<Animator>().SetBool("play", true);
            }
        }
        
        if (!noteThreeLearned && _Touching.isTouching)
        {
            if (_chord.currentClip == _chord.Am7)
            {
                noteThreeLearned = true;
                birdSeven.GetComponent<Animator>().SetBool("play", true);
            }
        }
        
        if (!noteFourLearned && _Touching.isTouching)
        {
            if (_chord.currentClip == _chord.B)
            {
                noteFourLearned = true;
                birdSix.GetComponent<Animator>().SetBool("play", true);
            }
        }

       
        
    }
    
}
