using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToMain : MonoBehaviour
{
    public void OnClickbacktoMain()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("TitleScreen");
    }

}
