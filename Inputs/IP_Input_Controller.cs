using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
    public enum InputType
    {
        Keyboard,
        Xbox,
    }

    [RequireComponent(typeof(IP_Keyboard_HeliInput), typeof(IP_XBox_HeliInput))]
    public class IP_Input_Controller : MonoBehaviour
    {
        #region Variables
        public InputType inputType = InputType.Keyboard;

        [Header("Input Properties")]
        private IP_Keyboard_HeliInput keyInput;
        private IP_XBox_HeliInput xboxInput;

        private float throttleInput;
        public float ThrottleInput
        {
            get { return throttleInput; }
        }

        private float collectiveInput;
        public float CollectiveInput
        {
            get { return collectiveInput; }
        }

        private Vector2 cyclicInput;
        public Vector2 CyclicInput
        {
            get { return cyclicInput; }
        }

        private float pedalInput;
        public float PedalInput
        {
            get { return pedalInput; }
        }
        private float stickyThrottleInput;
        public float StickyThrottleInput
        {
            get { return stickyThrottleInput; }
        }
        #endregion

        #region BuiltIn Methods
        private void Start()
        {
            keyInput = GetComponent<IP_Keyboard_HeliInput>();
            xboxInput = GetComponent<IP_XBox_HeliInput>();
            if (keyInput && xboxInput)
            {
                SetInputType(inputType);
            }
        }

        private void Update()
        {
            if (keyInput && xboxInput)
            {
                switch(inputType)
                {
                    case InputType.Keyboard:
                        throttleInput = keyInput.RawThrottleInput;
                        collectiveInput = keyInput.CollectiveInput;
                        pedalInput = keyInput.PedalInput;
                        cyclicInput = keyInput.CyclicInput;
                        stickyThrottleInput = keyInput.StickyThrottle;
                        break;

                    case InputType.Xbox:
                        throttleInput = xboxInput.RawThrottleInput;
                        collectiveInput = xboxInput.CollectiveInput;
                        pedalInput = xboxInput.PedalInput;
                        cyclicInput = xboxInput.CyclicInput;
                        stickyThrottleInput = xboxInput.StickyThrottle;
                        break;
                
                    default:
                        break;
                }
            }
        }
        #endregion

        #region Custom Methods
        void    SetInputType(InputType type)
        {
            if (type == InputType.Keyboard)
            {
                keyInput.enabled = true;
                xboxInput.enabled = false;
            }
            if (type == InputType.Xbox)
            {
                keyInput.enabled = false;
                xboxInput.enabled = true;
            }    
        }
        #endregion
    }
}
