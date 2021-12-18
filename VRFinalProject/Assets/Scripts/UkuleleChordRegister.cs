using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UkuleleChordRegister : MonoBehaviour
{

    public InputActionAsset _actionBasedController;

//all of the playable chords
    [Header("Ukulele Chord Sounds")] 
    public AudioClip A;
    public AudioClip F;
    public AudioClip D;
    public AudioClip C;
    public AudioClip G;
    public AudioClip B;
    public AudioClip Em;
    public AudioClip A7;
    public AudioClip Am7;
    public AudioClip Am;

    [Header("Current Chord")] 
    public AudioClip currentClip;

    [Header("Which Are Active")] 
    public bool cActive;
    public bool eActive;
    public bool gActive;
    public bool aActive;
    
    // Start is called before the first frame update
    void OnEnable()
    {
        //this is just enabling all of the possible actions that can be performed
        _actionBasedController.Enable(); 
        
        _actionBasedController["OculusX"].performed += C_String_Activate;
        _actionBasedController["OculusY"].performed += E_String_Activate;
        _actionBasedController["OculusGrip"].performed += G_String_Activate;
        _actionBasedController["OculusTrigger"].performed += A_String_Activate;
        
        _actionBasedController["OculusX"].canceled += C_String_Deactivate;
        _actionBasedController["OculusY"].canceled += E_String_Deactivate;
        _actionBasedController["OculusGrip"].canceled += G_String_Deactivate;
        _actionBasedController["OculusTrigger"].canceled += A_String_Deactivate;
    }

    // all of the actions just activate or deactivate one of the strings.
    private void G_String_Activate(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        gActive = true;
    }
    private void C_String_Activate(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        cActive = true;
    }
    private void E_String_Activate(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        eActive = true;
    }
    private void A_String_Activate(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        aActive = true;
    }
    
    private void G_String_Deactivate(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        gActive = false;
    }
    private void C_String_Deactivate(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        cActive = false;
    }
    private void E_String_Deactivate(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        eActive = false;
    }
    private void A_String_Deactivate(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        aActive = false;
    }

    private void Update()
    {
        //we want to find out the current chord combination here
        if (gActive && cActive && eActive && aActive)
        {
            currentClip = B;
        }
        else if (!gActive && !cActive && !eActive && !aActive)
        {
            currentClip = Am7;
        } else if (gActive && cActive && eActive && !aActive)
        {
            currentClip = D;
        } else if (!gActive && cActive && eActive && aActive)
        {
            currentClip = G;
        }else if (gActive && cActive && !eActive && aActive)
        {
            currentClip = Em;
        }else if (!gActive && cActive && eActive && aActive)
        {
            currentClip = G;
        }else if (gActive && cActive && !eActive && !aActive)
        {
            currentClip = A;
        }else if (gActive && !cActive && eActive && !aActive)
        {
            currentClip = F;
        }else if (!gActive && !cActive && !eActive && aActive)
        {
            currentClip = C;
        }else if (!gActive && cActive && !eActive && !aActive)
        {
            currentClip = A7;
        }else if (gActive && !cActive && !eActive && !aActive)
        {
            currentClip = Am;
        }else
        {
            currentClip = Am7;
        }

    }
}
