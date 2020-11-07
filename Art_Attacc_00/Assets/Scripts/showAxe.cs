using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showAxe : MonoBehaviour
{
    ///
    /// OLD CODE. NO LONGER USED IN PROJECT
    ///
    public GameObject axeText;
    public void showA()
    {
        if (axeText.activeSelf)
            axeText.SetActive(false);
        else
            axeText.SetActive(true);
    }

}
