using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hitDetect : MonoBehaviour
{
    ///
    /// Changes the color in the UI of art status
    ///
    public Text status;

    ///
    /// Collision detector
    /// If a piece of art detects a collision specifically from the axe,
    /// it will change the text of the status message.
    ///
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Dwarven_Axe_Low_Complete_Display")
        {
            status.text = "DESTROYED!";
            status.color = Color.red;
        }
    }
}
