using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class davidSparks : MonoBehaviour
{
    ///
    /// Code to trigger particle system
    ///
    public ParticleSystem sparks;

    ///
    /// If collision is detected, the location of the collision will be recorded
    /// and used to be the focal point of the particle system to play.
    /// NOTE: not always reliable as the axe is using a box collider.
    ///
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Dwarven_Axe_Low_Complete_Display")
        {
            Debug.Log("Points colliding: " + other.contacts.Length);
            Debug.Log("First point that collided: " + other.contacts[0].point);
            sparks.transform.position = other.contacts[0].point;
            sparks.Play();
        }
    }
}
