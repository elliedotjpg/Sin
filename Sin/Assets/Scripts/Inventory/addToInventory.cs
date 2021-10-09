using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addToInventory : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;
    [SerializeField] private InventoryItem thisItem;

    public GameObject Panel;

    public void OnClickObject()
    {
        Panel.SetActive(true);
        AddItem();
        SoundManagerScript.PlaySound("itemGet");

        gameObject.SetActive(false);
        Debug.Log("Added item!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Panel.SetActive(true);

            AddItem();
            SoundManagerScript.PlaySound("itemGet");

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
