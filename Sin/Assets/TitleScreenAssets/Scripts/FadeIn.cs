using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public Image blackFade;
    // Start is called before the first frame update
    void Start()
    {
        blackFade.canvasRenderer.SetAlpha(1.0f);
        fadeIn();
        StartCoroutine(disableImage());

    }

    // Update is called once per frame
    void fadeIn(){
    blackFade.CrossFadeAlpha(0, 2, false);
    }


    private IEnumerator disableImage()
    {
    yield return new WaitForSeconds(2.0f);
    blackFade.enabled = false;
    }

}
