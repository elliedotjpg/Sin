using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelCloser : MonoBehaviour
{
    public GameObject Panel;

    public void JustOpenThePanel()
    {
        Panel.SetActive(true);
    }
    public void CloseThePanel()
    {
        Panel.SetActive(false);
    }
}

