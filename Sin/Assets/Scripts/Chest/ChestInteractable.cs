using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChestInteractable : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;
    [SerializeField] private InventoryItem thisItem;
    [SerializeField] private InventoryItem thisItem2;

    public UnityEvent interactAction;

    public KeyCode interactKey;
    public bool isInRange;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                if (playerInventory.myInventory.Contains(thisItem) && playerInventory.myInventory.Contains(thisItem2))
                {
                    playerInventory.myInventory.Remove(thisItem);
                    interactAction.Invoke();

                    SoundManagerScript.PlaySound("itemGet");
                    Debug.Log("New item added!");
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            print("Player is in range with chest!");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isInRange = false;
        print("Player is no longer in range with chest!");
    }
}
