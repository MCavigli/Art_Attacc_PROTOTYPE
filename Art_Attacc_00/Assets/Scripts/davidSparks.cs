using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class davidSparks : MonoBehaviour
{
    public ParticleSystem sparks;
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
