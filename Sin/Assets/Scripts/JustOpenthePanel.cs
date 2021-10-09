using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustOpenthePanel : MonoBehaviour
{

    public GameObject Panel;
    public void JustOpenIt() 
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
    }
}
