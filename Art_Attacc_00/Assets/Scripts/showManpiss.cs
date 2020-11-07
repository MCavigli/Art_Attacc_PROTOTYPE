using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showManpiss : MonoBehaviour
{
    ///
    /// OLD CODE. NO LONGER USED IN PROJECT
    ///
    public GameObject manText;
    public void showMan()
    {
        if (manText.activeSelf)
            manText.SetActive(false);
        else
            manText.SetActive(true);
    }

}
