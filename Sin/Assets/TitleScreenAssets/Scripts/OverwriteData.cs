using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverwriteData : MonoBehaviour
{
    public GameObject FadeObject;

    public AudioSource FadeAudio;

    [SerializeField] private PlayerInventory playerInventory;

    public void Overwrite()
    {
        FadeObject.SetActive(true);
        StartCoroutine(AudioFade(FadeAudio, 2.0f));
        StartCoroutine(delayTime());

    }

    private IEnumerator delayTime()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(1);
        playerInventory.myInventory.Clear();
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
