using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeGravity : MonoBehaviour
{
    bool grav = false;
    Rigidbody axe;
    Collider axeCollider;

    void Awake()
    {
        axe = GetComponent<Rigidbody>();
        axeCollider = GetComponent<BoxCollider>();
    }

    void FixedUpdate()
    {
        if (!grav && transform.GetComponent<OVRGrabbable>().isGrabbed)
        {
            turnOffKin();
            grav = true;
        }
    }

    void turnOffKin()
    {
        axe.isKinematic = false;
        axe.detectCollisions = true;
    }
}
