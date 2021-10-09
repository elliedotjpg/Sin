using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MaskNextScene : MonoBehaviour
{
    public void MaskClick()
    {
        StartCoroutine(Wait());
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(4);
    }
}
