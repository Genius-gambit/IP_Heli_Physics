using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forces : IP_Base_RB_Controller
{
    #region Variables
    public float maxSpeed = 1.0f;
    public Vector3 movementDirection = Vector3.forward;
    #endregion

    #region Custom Methods
    protected override void HandlePhysics()
    {
        rb.AddForce(movementDirection * maxSpeed);
    }
    #endregion
}
