using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController1 : MonoBehaviour
{
    public GameObject enterDoor;
    public Collider2D doorCollider;
    public bool isOpen;
    public Animator animator;

    private void Start()
    {
        enterDoor.SetActive(false);
    }
    public void OpenDoor()
    {
        if (!isOpen)
        {
            isOpen = true;

            UnityEngine.Debug.Log("Door unlocked!");
            animator.SetBool("isOpen", isOpen);
        }
    }

    public void UnlockDoor()
    {
        if (isOpen)
        {
            //enterDoor.SetActive(true);
            doorCollider.enabled = false;

            StartCoroutine(Wait());

        }
        else
        {
            enterDoor.SetActive(false);
            doorCollider.enabled = true;
        }
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(2);
    }

   
}

