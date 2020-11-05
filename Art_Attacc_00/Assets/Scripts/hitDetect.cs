using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hitDetect : MonoBehaviour
{
    public Text status;

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Dwarven_Axe_Low_Complete_Display")
        {
            status.text = "DESTROYED!";
            status.color = Color.red;
        }
    }
}
