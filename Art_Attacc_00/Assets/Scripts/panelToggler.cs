using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelToggler : MonoBehaviour
{
    public GameObject monaText;

    public GameObject starText;

    public GameObject axeText;

    public GameObject manText;

    public GameObject davidText;

    public void showDavid()
    {
        if (davidText.activeSelf)
            davidText.SetActive(false);
        else
            davidText.SetActive(true);
    }

    public void showM()
    {
        if (monaText.activeSelf)
            monaText.SetActive(false);
        else
            monaText.SetActive(true);
    }

    public void showStar()
    {
        if (starText.activeSelf)
            starText.SetActive(false);
        else
            starText.SetActive(true);
    }

    public void showA()
    {
        if (axeText.activeSelf)
            axeText.SetActive(false);
        else
            axeText.SetActive(true);
    }

    public void showMan()
    {
        if (manText.activeSelf)
            manText.SetActive(false);
        else
            manText.SetActive(true);
    }
}
