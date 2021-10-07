using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentInteractable : MonoBehaviour
{
    //addToInventory add = new addToInventory(); 
    [SerializeField] private PlayerInventory playerInventory;
    [SerializeField] private InventoryItem thisItem;
    [SerializeField] private InventoryItem newItem;

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
                if (playerInventory.myInventory.Contains(thisItem))
                {
                    AddNew(newItem);
                    SoundManagerScript.PlaySound("itemGet");
                    Debug.Log("New item added!");
                }
            }
        }
    }

    void AddNew(InventoryItem newItem)
    {
        if (playerInventory && newItem)
        {
            if (playerInventory.myInventory.Contains(newItem))
            {
                thisItem.numberHeld += 1;
            }
            else
            {
                playerInventory.myInventory.Add(newItem);
                Debug.Log("Added new item!");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            print("Player is in range with vent!");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isInRange = false;
        print("Player is no longer in range with vent!");
    }
}
