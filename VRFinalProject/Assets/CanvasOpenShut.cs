using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CanvasOpenShut : MonoBehaviour
{

    public InputActionAsset _actionBasedController;

    public GameObject phone;
    
    // Start is called before the first frame update
    void Start()
    {
        _actionBasedController.Enable();

        _actionBasedController["RightTrigger"].performed += ToggleUI;
    }

    private void ToggleUI(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        phone.SetActive(!phone.activeSelf);
    }
}
