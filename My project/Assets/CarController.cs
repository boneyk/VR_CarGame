using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
   [SerializeField] WheelCollider frontRight, frontLeft, backRight, backLeft;

   public float acceleration = 500f;
    public float speed = 100f;

   public float breakingForce = 300f;
   public float maxTurnAngle = 15f;

   private float currentAcceleration = 0f;
   private float currentBreakForce = 0f;
   private float currentTurnAngle = 0f;

   public void Accelerate(){
    currentAcceleration = acceleration * speed;

    currentBreakForce = breakingForce;
    frontRight.motorTorque = currentAcceleration;
    frontLeft.motorTorque = currentAcceleration;

    frontRight.brakeTorque = currentBreakForce;
    frontLeft.brakeTorque = currentBreakForce;
    backRight.brakeTorque = currentBreakForce;
    backLeft.brakeTorque = currentBreakForce;

   }

   public void Reverse(){
    currentAcceleration = acceleration * (-speed);

    currentBreakForce = breakingForce;
    frontRight.motorTorque = currentAcceleration;
    frontLeft.motorTorque = currentAcceleration;

    frontRight.brakeTorque = currentBreakForce;
    frontLeft.brakeTorque = currentBreakForce;
    backRight.brakeTorque = currentBreakForce;
    backLeft.brakeTorque = currentBreakForce;

   }

   public void TurnLeft(){
    currentTurnAngle = maxTurnAngle * (-speed);
    frontLeft.steerAngle = currentTurnAngle;
    frontRight.steerAngle = currentTurnAngle;
   }

    public void TurnRight(){
    currentTurnAngle = maxTurnAngle * (speed);
    frontLeft.steerAngle = currentTurnAngle;
    frontRight.steerAngle = currentTurnAngle;
   }

}
