using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IndiePixel
{
    [RequireComponent(typeof(Rigidbody))]
    public class IP_Base_RB_Controller : MonoBehaviour
    {
        #region Variables
        [Header("Base Properties")]
        public float weightInLbs = 10.0f;
        public Transform cog;
        protected float weight;

        const float lbsToKg = 0.454f;
        const float KgTolbs = 2.205f;

        protected Rigidbody rb;
        #endregion

        #region BuiltIn Methods
        private void Start()
        {
            float finalKg = weightInLbs * lbsToKg;
            weight = finalKg;
            rb = GetComponent<Rigidbody>();
            if (rb)
                rb.mass = weight;
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
        protected virtual void HandlePhysics()
        {

        }
        #endregion
    }
}