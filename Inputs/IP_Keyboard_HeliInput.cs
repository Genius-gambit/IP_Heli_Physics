using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
    public class IP_Keyboard_HeliInput : IP_Base_HeliInput
    {
        #region Variables
        [Header("Heli Keyboard Inputs")]
        protected float throttleInput = 0.0f;
        protected float collectiveInput = 0.0f;
        protected float stickyThrottle = 0.0f;
        protected Vector2 cyclicInput = Vector2.zero;
        protected float pedalInput = 0.0f;
        #endregion

        #region Properties
        public float    RawThrottleInput
        {
            get { return throttleInput;  }
        }
        public float StickyThrottle
        {
            get { return stickyThrottle; }
        }
        public float CollectiveInput
        {
            get { return collectiveInput; }
        }
        public Vector2 CyclicInput
        {
            get { return cyclicInput; }
        }
        public float PedalInput
        {
            get { return pedalInput; }
        }
        #endregion

        #region BuiltIn Methods
        #endregion

        #region Custom Methods
        protected override void HandleInputs()
        {
            base.HandleInputs();

            // Input Methods
            HandleThrottle();
            HandlePedal();
            HandleCyclic();
            HandleCollective();

            // Utility Methods
            ClampInputs();
            HandleStickyThrottle();
        }

        protected virtual void    HandleThrottle()
        {
            throttleInput = throttle;
        }
        protected virtual void HandlePedal()
        {
            pedalInput = pedal;
        }
        protected virtual void HandleCollective()
        {
            collectiveInput = collective;
        }

        protected virtual void HandleCyclic()
        {
            cyclicInput.y = vertical;
            cyclicInput.x = horizontal;
        }

        protected void  ClampInputs()
        {
            throttleInput = Mathf.Clamp(throttleInput, -1.0f, 1.0f);
            collectiveInput = Mathf.Clamp(collectiveInput, -1.0f, 1.0f);
            cyclicInput = Vector2.ClampMagnitude(cyclicInput, 1);
            pedalInput = Mathf.Clamp(pedalInput, -1.0f, 1.0f);
        }

        protected void  HandleStickyThrottle()
        {
            stickyThrottle += RawThrottleInput * Time.deltaTime;
            stickyThrottle = Mathf.Clamp01(stickyThrottle);
            print("Sticky Throttle: " + stickyThrottle);
        }
        #endregion
    }
}
