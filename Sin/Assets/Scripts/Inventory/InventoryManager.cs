using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    [Header("Inventory Information")]

    public PlayerInventory playerInventory;
    [SerializeField] private GameObject blankInventorySlot;
    [SerializeField] private GameObject inventoryPanel;
    [SerializeField] private TextMeshProUGUI itemDescription;

    public void SetText(string description)
    {
        itemDescription.text = description;
    }

    void MakeInventorySlots()
    {
        if (playerInventory)
        {
            for(int i = 0; i < playerInventory.myInventory.Count; i ++)
            {
                GameObject temp =
                    Instantiate(blankInventorySlot,
                    inventoryPanel.transform.position, Quaternion.identity);
                temp.transform.SetParent(inventoryPanel.transform);
                temp.transform.localScale = new Vector3(1.18f, 1.66f, 1f);
                InventorySlot newSlot = temp.GetComponent<InventorySlot>();
                Debug.Log("help");

                if (newSlot)
                {
                    newSlot.Setup(playerInventory.myInventory[i], this);
                    Debug.Log("There is a new slot!");
                }
            }
        }
    }

    // Start is called before the first frame update
    void OnEnable()
    {
        ClearInventorySlots();
        MakeInventorySlots();
        Debug.Log("Made inventory!");
    }

    private void Start()
    {
        SetText("");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ClearInventorySlots()
    {
        for(int i =0; i < inventoryPanel.transform.childCount; i++)
        {
            Destroy(inventoryPanel.transform.GetChild(i).gameObject);
        }
    }

    public void SetupDescription(string newDescriptionString)
    {
        itemDescription.text = newDescriptionString;
        //useButton.SetActive(isButtonUsable);
    }
}
