using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class TSPlay : MonoBehaviour
{
    private int sceneToContinue;

    public GameObject FadeObject;

    public AudioSource FadeAudio;

    [SerializeField] private PlayerInventory playerInventory;


    public UnityEvent interactAction;
    public void PlayButton()
    {
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");
        if (sceneToContinue == 0)
        {
            FadeObject.SetActive(true);
            StartCoroutine(AudioFade(FadeAudio, 2.0f));
            StartCoroutine(delayTime());
        }
        else
        {
            interactAction.Invoke();
        }
            
    }

    private IEnumerator delayTime()
    {
        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(1);
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
