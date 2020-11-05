using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showStarry : MonoBehaviour
{
    public GameObject starText;

    public void showStar()
    {
        if (starText.activeSelf)
            starText.SetActive(false);
        else
            starText.SetActive(true);
    }
}
