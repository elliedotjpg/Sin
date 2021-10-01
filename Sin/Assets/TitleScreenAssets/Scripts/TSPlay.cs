using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TSPlay : MonoBehaviour
{

    public void PlayButton()
    {
        StartCoroutine(delayTime());
    }

    private IEnumerator delayTime()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("RoomOne");

    }

}
