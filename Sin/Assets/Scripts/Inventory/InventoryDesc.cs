using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InventoryDesc : MonoBehaviour
{
    [Header("UI Stuff to Change")]
    [SerializeField] private TextMeshProUGUI itemDescription;
    [SerializeField] private TextMeshProUGUI itemName;
    [SerializeField] private Image itemImage;

    [Header("Item Variables")]
    public InventoryItem thisItem;
    public InventoryManager thisManager;

    public void Setup(InventoryItem newItem, InventoryManager newManager)
    {
        thisItem = newItem;
        thisManager = newManager;
        if (thisItem)
        {
            itemImage.sprite = thisItem.itemImage;
            itemName.text = "" + thisItem.itemName;
            itemDescription.text = "" + thisItem.itemDescription;
        }
    }
}
