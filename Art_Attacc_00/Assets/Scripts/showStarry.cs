using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showStarry : MonoBehaviour
{
    ///
    /// OLD CODE. NO LONGER USED IN PROJECT
    ///
    public GameObject starText;

    public void showStar()
    {
        if (starText.activeSelf)
            starText.SetActive(false);
        else
            starText.SetActive(true);
    }
}
