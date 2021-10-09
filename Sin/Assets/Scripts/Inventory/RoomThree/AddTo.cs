using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTo : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;
    [SerializeField] private InventoryItem thisItem;

    public GameObject Panel;

    public void OnClickObject()
    {
        AddItem();
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        { 
            AddItem();
            gameObject.SetActive(false);
        }
    }

    void AddItem()
    {
        
        SoundManagerScript.PlaySound("getItem");
        Debug.Log("Play sound!");
        Panel.SetActive(true);

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
