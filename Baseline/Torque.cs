using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IndiePixel;

public class Torque : IP_Base_RB_Controller
{
    #region Variables
    public float torqueSpeed = 2.0f;
    public Vector3 rotationDirection = Vector3.up;
    #endregion

    #region Custom Methods
    protected override void HandlePhysics()
    {
        Vector3 wantedTorque = Vector3.up * torqueSpeed;
        rb.AddTorque(wantedTorque);
    }
    #endregion
}
