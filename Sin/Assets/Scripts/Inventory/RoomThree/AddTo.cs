using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTo : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;
    [SerializeField] private InventoryItem thisItem;

    public void OnClickObject()
    {
        SoundManagerScript.PlaySound("itemGet");
        AddItem();
        

        gameObject.SetActive(false);
       

        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SoundManagerScript.PlaySound("itemGet");

            AddItem();
            gameObject.SetActive(false);
        }
    }

    void AddItem()
    {
        if (playerInventory && thisItem)
        {
            if (playerInventory.myInventory.Contains(thisItem))
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
