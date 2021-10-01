using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TSFadeOut : MonoBehaviour
{
    public Image blackFade;
    // Start is called before the first frame update
    void Start()
    {
        blackFade.canvasRenderer.SetAlpha(0.0f);
        fadeOut();

    }

    // Update is called once per frame
    void fadeOut()
    {
        blackFade.CrossFadeAlpha(1, 2, false);
    }

    private IEnumerator delayTime()
    {
        yield return new WaitForSeconds(2.0f);
    }

}
