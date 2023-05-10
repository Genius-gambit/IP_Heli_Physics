using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{
    #region Variables
    [Header("Hover Properties")]
    public float hoverHeight = 3.0f;
    public Transform    hoverPosition;
    public float dragFactor = 0.05f;
    public float torqueSpeed = 4.0f;
    private Rigidbody rb;
    private float weight;
    private float currentGroundDistance;
    #endregion

    #region BuiltIn Methods

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb)
        {
            weight = rb.mass * Physics.gravity.magnitude;
        }
    }

    private void FixedUpdate()
    {
        if (rb && hoverPosition)
        {
            CalculateGroundDistance();
            HandleHoverForce();
            HandleTorque();
            HandleDrag();
        }
    }

    #endregion
    #region Custom Methods
    private void    CalculateGroundDistance()
    {
        Ray hoverRay = new Ray(hoverPosition.position, Vector3.down);
        RaycastHit hit;
        if (Physics.Raycast(hoverRay, out hit, 100f))
        {
            if (hit.transform.tag == "ground")
            {
                currentGroundDistance = hit.distance;
            }
        }
    }

    void    HandleHoverForce()
    {
        float groundDiff = hoverHeight - currentGroundDistance;
        Vector3 finalHoverForce = Vector3.up * (1 + groundDiff);
        rb.AddForce(finalHoverForce * weight);
    }

    void    HandleTorque()
    {
        rb.AddTorque(Vector3.up * torqueSpeed);
    }

    void    HandleDrag()
    {
        rb.drag = rb.velocity.magnitude * dragFactor;
    }
    #endregion
}