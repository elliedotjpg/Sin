using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addToInventory : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;
    [SerializeField] private InventoryItem thisItem;

    public void OnClickObject()
    {
        
        AddItem();
        SoundManagerScript.PlaySound("Obtained");

        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SoundManagerScript.PlaySound("Obtained");
            Debug.Log("Play sound now tsk.");

            AddItem(); 
            gameObject.SetActive(false);
        }
    }

    void AddItem()
    {
        if(playerInventory && thisItem)
        {
            if(playerInventory.myInventory.Contains(thisItem))
            {
                thisItem.numberHeld += 1;
            }
            else
            {
                playerInventory.myInventory.Add(thisItem);
            }
        }
    }
}
