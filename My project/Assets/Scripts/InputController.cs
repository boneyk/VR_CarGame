using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    private bool turnLeft, turnRight, reverse, accelerate;

    private void FixedUpdate() {
        if(accelerate)
            CarController.Instance.Accelerate();
        else if(reverse)
            CarController.Instance.Reverse();
        else if(turnLeft)
            CarController.Instance.TurnLeft();
        else if(turnRight)
            CarController.Instance.TurnRight();
    }

    public void OnTurnLeft(InputValue inputValue) => turnLeft = inputValue.isPressed;

    public void OnTurnRight(InputValue inputValue) => turnRight = inputValue.isPressed;

    public void OnReverse(InputValue inputValue) => reverse = inputValue.isPressed;

    public void OnAccelerate(InputValue inputValue) => accelerate = inputValue.isPressed;

}
