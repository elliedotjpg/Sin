using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCollider : DoorController1
{
    public GameObject Collider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isOpen == true)
        {
            Debug.Log("Ble = " + isOpen);
            Collider.SetActive(true);
        }
        else
        {
            Collider.SetActive(false);
        }
    }
}
