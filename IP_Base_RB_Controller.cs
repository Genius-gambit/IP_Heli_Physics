using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IP_Base_RB_Controller : MonoBehaviour
{
    #region Variables
    protected Rigidbody rb;
    #endregion

    #region BuiltIn Methods
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (rb)
        {
            HandlePhysics();
        }
    }
    #endregion

    #region Custom Methods
    protected virtual void  HandlePhysics()
    {

    }
    #endregion
}
