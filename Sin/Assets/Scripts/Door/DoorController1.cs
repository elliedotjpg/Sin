using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController1 : MonoBehaviour
{
    //public GameObject EnterDoor;

    public new Collider2D collider;
    public bool isOpen;
    public Animator animator;

    private void Start()
    {    
        collider = GetComponent<Collider2D>();
        //EnterDoor.SetActive(false);;
    }
    public void OpenDoor()
    {
        if (!isOpen)
        {
            isOpen = true;
            collider.enabled = true;

            UnityEngine.Debug.Log("Door unlocked!");
            animator.SetBool("isOpen", isOpen);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Collider Enabled = " + GetComponent<Collider>().enabled);
        if (isOpen == true)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}

