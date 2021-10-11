using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clearPlayerInventory : MonoBehaviour
{

    [SerializeField] private PlayerInventory playerInventory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Clear()
    {
        playerInventory.myInventory.Clear();
    }
}
