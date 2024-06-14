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
            CarController.Accelerate();
        if(reverse)
            CarController.Reverse();
        if(turnLeft)
            CarController.TurnLeft();
        if(turnRight)
            CarController.TurnRight();
    }

    public void OnTurnLeft(InputValue inputValue) => turnLeft = inputValue.isPressed;

    public void OnTurnRight(InputValue inputValue) => turnRight = inputValue.isPressed;

    public void OnReverse(InputValue inputValue) => reverse = inputValue.isPressed;

    public void OnAccelerate(InputValue inputValue) => accelerate = inputValue.isPressed;

}
