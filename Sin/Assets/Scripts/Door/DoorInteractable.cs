 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorInteractable : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;
    [SerializeField] private InventoryItem thisItem;

    public KeyCode interactKey;
    public bool isInRange;
    public UnityEvent interactAction;

    private void Start()
    {
        
    }
    private void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                if (playerInventory.myInventory.Contains(thisItem))
                {
                    playerInventory.myInventory.Remove(thisItem);
                    interactAction.Invoke();
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            print("Player is in range with door!");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isInRange = false;
        print("Player is no longer in range with door!");
    }
}
