using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TSFadeIn : MonoBehaviour
{
    public Image blackFade;

    void Start()
    {
        StartCoroutine(disableImage());
    }

    private void OnEnable()
    {
        StartCoroutine(disableImage());
    }


    private IEnumerator disableImage()
    {
    yield return new WaitForSeconds(2.0f);
    blackFade.enabled = false;
    }

}
