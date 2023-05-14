using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
    public class IP_XBox_HeliInput : IP_Keyboard_HeliInput
    {
        #region Custom Methods
        protected override void HandleThrottle()
        {
            throttleInput = Input.GetAxis("XboxThrottleUp") - Input.GetAxis("XboxThrottleDown");
        }
        protected override void HandlePedal()
        {
            pedalInput = Input.GetAxis("XboxPedal");
        }
        protected override void HandleCyclic()
        {
            cyclicInput.y = Input.GetAxis("XboxCyclicVertical");
            cyclicInput.x = Input.GetAxis("XboxCyclicHorizontal");
        }
        protected override void HandleCollective()
        {
            collectiveInput = Input.GetAxis("XboxCollective");
        }
        #endregion
    }
}
