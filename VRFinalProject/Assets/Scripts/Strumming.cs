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

    public ParticleSystem notes;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _actionBasedController.Enable();

        _actionBasedController["RightStrum"].performed += Strum;
        

    }

    private void Strum(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {

        //if the player's hand is touching the correct section of the ukulele, this works
        //otherwise, no sound is heard when the player 'strums' with their thumb on the grip
        if (touching.isTouching == true)
        {
            Debug.Log("strum");
            aud.PlayOneShot(_chord.currentClip);

            //we immediately stop the previous clip and play the new one
            notes.Stop();
            notes.Play();
        }
        
    }
}
