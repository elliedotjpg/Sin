using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{

    [Header("UI Stuff to Change")]
    [SerializeField] private TextMeshProUGUI itemNameText;
    [SerializeField] private TextMeshProUGUI itemNumberText;
    [SerializeField] private Image itemImage;

    [Header("Item Variables")]
    public InventoryItem thisItem;
    public InventoryManager thisManager;

    public void Setup(InventoryItem newItem, InventoryManager newManager)
    {
        thisItem = newItem;
        thisManager = newManager;
        if(thisItem)
        {
            itemImage.sprite = thisItem.itemImage;
            itemNameText.text = "" + thisItem.itemName;
            itemNumberText.text = "" + thisItem.numberHeld;
        }
    }
}
