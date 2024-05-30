using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class animationHandONinput : MonoBehaviour
{

    public InputActionProperty grab;
    float triggerValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = grab.action.ReadValue<float>();
    }
}
