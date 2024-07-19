using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DilmerGames.Core.Singletons;
using UnityEngine.InputSystem;

public class InputController : Singleton<InputController>
{
    private bool turnLeft, turnRight, reverse, accelerate;

    private CarController carController;

    public void Bind(CarController carController){
        this.carController = carController;
    }
    private void FixedUpdate() {
        if(accelerate)
            carController.Accelerate();
        if(reverse)
           carController.Reverse();
        if(turnLeft)
            carController.TurnLeft();
        if(turnRight)
            carController.TurnRight();
    }

    public void OnTurnLeft(InputValue inputValue) => turnLeft = inputValue.isPressed;

    public void OnTurnRight(InputValue inputValue) => turnRight = inputValue.isPressed;

    public void OnReverse(InputValue inputValue) => reverse = inputValue.isPressed;

    public void OnAccelerate(InputValue inputValue) => accelerate = inputValue.isPressed;

}
