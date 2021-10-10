using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OverwriteData : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;

    public void Overwrite()
    {
            StartCoroutine(delayTime());

    }
    private IEnumerator delayTime()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene(1);
        playerInventory.myInventory.Clear();
    }
}
