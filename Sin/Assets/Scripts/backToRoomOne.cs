using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToRoomOne : MonoBehaviour
{
    public void OnClickbacktoRoomOne()
    {
        SceneManager.LoadScene(1);
    }
}
