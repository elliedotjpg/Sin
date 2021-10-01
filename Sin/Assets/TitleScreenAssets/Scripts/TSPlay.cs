using UnityEngine;
using UnityEngine.SceneManagement;

public class TSPlay : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("RoomOne");
    }

}
