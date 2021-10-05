using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController1 : MonoBehaviour
{
    //public Collider2D collider;
    public bool isOpen;
    public Animator animator;

    public void OpenDoor()
    {
        if (!isOpen)
        {
            isOpen = true;
            UnityEngine.Debug.Log("Door unlocked!");
            animator.SetBool("isOpen", isOpen);
        }
        /**else if(isOpen)
        {
            collider.enabled = !collider.enabled;
        }*/
    }
}

