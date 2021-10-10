using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Events;

public class TSPlay : MonoBehaviour
{
    private int sceneToContinue;

    public UnityEvent interactAction;
    public void PlayButton()
    {
        sceneToContinue = PlayerPrefs.GetInt("SavedScene");
        if (sceneToContinue == 0)
        {
            StartCoroutine(delayTime());
        }
        else
        {
            interactAction.Invoke();
        }
            
    }

    private IEnumerator delayTime()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(1);
    }

}
