using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherScript : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;
    [SerializeField] private InventoryItem thisItem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TriggerMother()
    {
        if (playerInventory.myInventory.Contains(thisItem))
        {

        }
    }
}
