using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputController : MonoBehaviour
{
    public UnityEvent onInputLeft;
    public UnityEvent onInputRight;

    private void Update()
    {
        GetInput();
    }

    private void GetInput()
    {

        if (Input.GetKey("right"))
        {
            SendMoveEvent(KeyCode.RightArrow);
        }

        if (Input.GetKey("left"))
        {
            SendMoveEvent(KeyCode.LeftArrow);
        }
    }
    
    private void SendMoveEvent(KeyCode keyCode)
    {
        switch (keyCode)
        {
            case KeyCode.RightArrow:
                onInputRight.Invoke();
                break;
            case KeyCode.LeftArrow:
                onInputLeft.Invoke();
                break;
        }
    }

    public void ToggleInput(bool isOn)
    {
        gameObject.SetActive(isOn);
    }
}
