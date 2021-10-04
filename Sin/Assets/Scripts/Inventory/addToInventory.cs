using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class addToInventory : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;
    [SerializeField] private InventoryItem thisItem;

    public void OnClickObject()
    {
        AddItem();
        //Destroy(this.gameObject);
        gameObject.SetActive(false);
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
