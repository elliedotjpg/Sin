using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addToInventory : MonoBehaviour
{
    //public static AudioClip clip;

    [SerializeField] private PlayerInventory playerInventory;
    [SerializeField] private InventoryItem thisItem;

    public GameObject Panel;

    /* void Start()
    {
        clip = Resources.Load<AudioClip>("itemObtained");
    }*/

    public void OnClickObject()
    {
        AddItem();

        gameObject.SetActive(false);
        Debug.Log("Added item!");
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AddItem();

            gameObject.SetActive(false);
            Debug.Log("Set false?");
        }
    }

    void AddItem()
    {
        SoundManagerScript.PlaySound("itemObtained");
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
