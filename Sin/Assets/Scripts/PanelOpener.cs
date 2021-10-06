using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{

    public GameObject motherAnim;

    public GameObject Panel;

    public void OpenPanel()
    {
        if(Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }

    public void ClosePanel()
    {
            Panel.SetActive(false);
    }

    void Update()
    {
        if (motherAnim.activeInHierarchy == true)
        {
            Panel.SetActive(false);
        }
        else
        {
            Panel.SetActive(true);
        }
    }

}
