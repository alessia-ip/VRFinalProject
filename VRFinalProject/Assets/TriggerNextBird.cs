using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;

public class TriggerNextBird : MonoBehaviour
{
    
    //this script it for keeping track of which birds have gotten close to the player or not
    //and which notes the player has actively 'learned'

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
    
    //these are for when the player has successfully played every note at least once
    public AudioSource aud;
    public AudioClip success;
    bool flourish = false;
    
    // Start is called before the first frame update
    void Start()
    {
        _actionBasedController.Enable();

        //every time we strum, we check these parameters
        _actionBasedController["RightStrum"].performed += CheckStrum;

    }

    private void Update()
    {
        //we only play the success flourish once, on completion
        if (noteFourLearned && noteOneLearned && noteTwoLearned && noteThreeLearned && !flourish)
        {
            flourish = true;
            aud.PlayOneShot(success);
        }
    }

    //this function is for checking if the ukulele is being played
    //if it is, and the note hasn't be learned/played yet, we mark it as learned
    private void CheckStrum(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        if (!noteOneLearned && _Touching.isTouching)
        {
            if (_chord.currentClip == _chord.C)
            {
                noteOneLearned = true;
                //trigger the new bird's animation so it comes close to the player
                //we do this for every note where an animation is called
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
