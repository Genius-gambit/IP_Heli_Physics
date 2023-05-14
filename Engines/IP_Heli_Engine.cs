using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
    public class IP_Heli_Engine : MonoBehaviour
    {
        #region Variables
        public float maxHP = 140.0f;
        public float maxRPM = 2700.0f;
        public float powerDelay = 2.0f;
        public AnimationCurve powerCurve = new AnimationCurve(new Keyframe(0.0f, 0.0f), new Keyframe(1.0f, 1.0f));
        #endregion

        #region Properties
        private float currentHP;
        public float    CurrentHP
        {
            get { return currentHP; }
        }

        private float currentRPM;
        public float CurrentRPM
        {
            get { return currentRPM; }
        }
        #endregion

        #region BuiltIn Methods
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        #endregion
        #region Custom Methods
        public void UpdateEngine(float throttleInput)
        {
            // Calculate HorsePower
            float wantedHP = throttleInput * maxHP;
            currentHP = Mathf.Lerp(currentHP, wantedHP, Time.deltaTime * powerDelay);

            // Calculate RPM's
            float wantedRPM = powerCurve.Evaluate(throttleInput) * maxHP;
            currentRPM = Mathf.Lerp(currentRPM, wantedRPM, Time.deltaTime * powerDelay);
        }
        #endregion
    }
}
