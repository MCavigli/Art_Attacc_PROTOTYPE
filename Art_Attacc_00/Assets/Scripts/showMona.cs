using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showMona : MonoBehaviour
{
    ///
    /// OLD CODE. NO LONGER USED IN PROJECT
    ///
    public GameObject monaText;
    public void showM()
    {
        if (monaText.activeSelf)
            monaText.SetActive(false);
        else
            monaText.SetActive(true);
    }

}
