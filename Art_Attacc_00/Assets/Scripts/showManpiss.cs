using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showManpiss : MonoBehaviour
{
    public GameObject manText;
    public void showMan()
    {
        if (manText.activeSelf)
            manText.SetActive(false);
        else
            manText.SetActive(true);
    }

}
