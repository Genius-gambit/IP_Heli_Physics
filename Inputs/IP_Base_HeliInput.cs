using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
    public class IP_Base_HeliInput : MonoBehaviour
    {
        #region Variables
        [Header("Base Input Properties")]
        protected float    vertical = 0f;
        protected float    horizontal = 0f;
        protected float    throttle = 0f;
        protected float    collective = 0f;
        protected float    pedal = 0f;
        #endregion

        #region BuiltIn Methods
        private void Update()
        {
            HandleInputs();
        }
        #endregion

        #region Custom Methods
        protected virtual void  HandleInputs()
        {
            vertical = Input.GetAxis("Vertical");
            horizontal = Input.GetAxis("Horizontal");
            throttle = Input.GetAxis("Throttle");
            collective = Input.GetAxis("Collective");
            pedal = Input.GetAxis("Pedal");
        }
        #endregion
    }
}
