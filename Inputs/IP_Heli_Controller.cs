using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IndiePixel;

namespace IndiePixel
{
    [RequireComponent(typeof(IP_Input_Controller))]
    public class IP_Heli_Controller : IP_Base_RB_Controller
    {
        #region Variables
        [Header("Helicopter Properties")]
        public List<IP_Heli_Engine> engines = new List<IP_Heli_Engine>();

        private IP_Input_Controller input;
        #endregion

        #region Custom Methods
        protected override void HandlePhysics()
        {
            input = GetComponent<IP_Input_Controller>();
            if (input)
            {
                HandleEngines();
                HandleCharacteristics();
            }
        }

        protected virtual void HandleEngines()
        {
            for (int i = 0; i < engines.Count; i++)
            {
                engines[i].UpdateEngine(input.StickyThrottleInput);
                float finalPower = engines[i].CurrentHP;
            }
        }

        protected virtual void HandleCharacteristics()
        {

        }
        #endregion

        #region Helicopter Control Methods
        #endregion
    }
}
