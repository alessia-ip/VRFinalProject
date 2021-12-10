using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TriggerNextBird : MonoBehaviour
{
    private bool noteOneLearned;
    
    public InputActionAsset _actionBasedController;

    public UkuleleChordRegister _chord;

    public GameObject birdTwo;

    public TouchingScriptableObject _Touching;

    // Start is called before the first frame update
    void Start()
    {
        _actionBasedController.Enable();

        _actionBasedController["RightStrum"].performed += CheckStrum;

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
        
    }
    
}
