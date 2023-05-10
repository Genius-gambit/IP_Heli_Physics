using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
    public class IP_Keyboard_HeliInput : IP_Base_HeliInput
    {
        #region Variables
        [Header("Heli Keyboard Inputs")]
        private float throttleInput = 0.0f;
        private float collectiveInput = 0.0f;
        private Vector2 cyclicInput = Vector2.zero;
        private float pedalInput = 0.0f;
        #endregion

        #region Properties
        public float    ThrottleInput
        {
            get { return throttleInput;  }
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

            HandleThrottle();
            HandlePedal();
            HandleCyclic();
            HandleCollective();
        }

        void    HandleThrottle()
        {
            throttleInput = throttle;
        }
        void    HandlePedal()
        {
            pedalInput = pedal;
        }
        void HandleCollective()
        {
            collectiveInput = collective;
        }

        void    HandleCyclic()
        {
            cyclicInput.y = vertical;
            cyclicInput.x = horizontal;
        }
        #endregion
    }
}
