
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrivingScript: MonoBehaviour
{

    public float MotorForce, SteerForce, BreakForce, friction;
    public WheelCollider wheelfrontleft, wheelfrontrightSphere, wheelbackleft, wheelbackright;
    public GameObject car;


    void Update()
    {

        float v = Input.GetAxis("Vertical") * MotorForce;


        wheelbackleft.motorTorque = v;
        wheelbackright.motorTorque = v;

        car.transform.Rotate(Vector3.up * SteerForce * Time.deltaTime * Input.GetAxis("Horizontal"), Space.World);



        if (Input.GetKey(KeyCode.Space))
        {
            wheelbackleft.brakeTorque = BreakForce;
            wheelbackright.brakeTorque = BreakForce;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            wheelbackleft.brakeTorque = 0;
            wheelbackright.brakeTorque = 0;
        }
        if (Input.GetAxis("Vertical") == 0)
        {
            if (wheelbackleft.brakeTorque <= BreakForce && wheelbackright.brakeTorque <= BreakForce)
            {
                wheelbackleft.brakeTorque += friction * Time.deltaTime * BreakForce;
                wheelbackright.brakeTorque += friction * Time.deltaTime * BreakForce;
            }
            else
            {
                wheelbackleft.brakeTorque = BreakForce;
                wheelbackright.brakeTorque = BreakForce;
            }
        }
        else
        {
            wheelbackleft.brakeTorque = 0;
            wheelbackright.brakeTorque = 0;
        }


    }
}