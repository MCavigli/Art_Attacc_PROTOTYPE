using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArtBreak : MonoBehaviour
{
    public Collider axe;
    Collider art;

    void Awake()
    {
        art = GetComponent<BoxCollider>();
    }

    void FixedUpdate()
    {
        if(axe.bounds.Intersects(art.bounds))
        {
            Debug.Log("SMASH!");
        }
    }
}
