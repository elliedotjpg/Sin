using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyCarpet : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;

    [SerializeField] private InventoryItem thisKey;

    public GameObject Panel;

    // Update is called once per frame
    void Update()
    {
        if (playerInventory.myInventory.Contains(thisKey))
        {
            Destroy(Panel);
        }
    }

}
