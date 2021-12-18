using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CanvasOpenShut : MonoBehaviour
{

    //this script it to tackle turning on the 'phone' ui on the player's left hand
    
    public InputActionAsset _actionBasedController;

    public GameObject phone;
    
    // Start is called before the first frame update
    void Start()
    {
        _actionBasedController.Enable();

        //the button is supposed to be 'a'
        //but it accepts other buttons too for ease of use
        _actionBasedController["RightTrigger"].performed += ToggleUI;
    }

    private void ToggleUI(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        phone.SetActive(!phone.activeSelf);
    }
}
