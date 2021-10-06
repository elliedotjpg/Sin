using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeView : MonoBehaviour
{
    private GameManager gameManager = new GameManager();
    private bool FreezeViewDone;

    private void Start()
    {
        StartCoroutine(FreezeRoutine());
    }

    private IEnumerator FreezeRoutine()
    {
        var freezeTimer = 10;
        while (freezeTimer >= 0)
        {
            yield return new WaitForSeconds(10);
            freezeTimer--;
        }
        FreezeViewDone = true;
    }   

    public bool FreezeComplete()
    {
        return FreezeComplete();
    }
}
