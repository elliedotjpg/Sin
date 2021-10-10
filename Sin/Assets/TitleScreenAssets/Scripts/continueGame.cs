using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class continueGame : MonoBehaviour
{
    private int sceneToContinue;

    public GameObject FadeObject;

    public AudioSource FadeAudio;

    public void ContinueGame() { 
    sceneToContinue = PlayerPrefs.GetInt("SavedScene");

        if(sceneToContinue != 0)
        {
            FadeObject.SetActive(true);
            StartCoroutine(delayTime());
            StartCoroutine(AudioFade(FadeAudio, 2.5f));
        }
        else
        {
            return;
        }
    }

    private IEnumerator delayTime()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(sceneToContinue);
    }

    public static IEnumerator AudioFade(AudioSource audioSource, float FadeTime)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;
            yield return null;
        }
        audioSource.Stop();
        audioSource.volume = startVolume;
    }



}
