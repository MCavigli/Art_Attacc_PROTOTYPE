using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableKimatic : MonoBehaviour
{
    Collider coll;
    public Collider axe;

    void Awake()
    {
        coll = GetComponent<Collider>();
    }

    void OnTriggerEnter(Collider axe)
    {
        if(axe.attachedRigidbody)
        {
            axe.attachedRigidbody.isKinematic = false;
        }
    }
}
