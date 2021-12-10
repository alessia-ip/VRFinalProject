using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Strumming : MonoBehaviour
{
    
    public InputActionAsset _actionBasedController;

    public AudioSource aud;

    public UkuleleChordRegister _chord;

    public TouchingScriptableObject touching;
    
    // Start is called before the first frame update
    void Start()
    {
        _actionBasedController.Enable();

        _actionBasedController["RightStrum"].performed += Strum;

    }

    private void Strum(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {

        if (touching.isTouching == true)
        {
            Debug.Log("strum");
            aud.PlayOneShot(_chord.currentClip);
            
        }
        
        
        
    }
}