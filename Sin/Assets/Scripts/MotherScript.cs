using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MotherScript : MonoBehaviour
{
    //[SerializeField] private PlayerInventory playerInventory;
    public GameObject itemToDrop;
    private Transform Epos;

    void Start()
    {
        itemToDrop.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Mother")
        {
            itemToDrop.SetActive(true);
            Instantiate(itemToDrop, transform.position, transform.rotation);
            Debug.Log("Collided with " + collision.gameObject.name);
            Debug.Log("Key dropped.");
            
            //Debug.Log("Key dropped.");
        }

    }
}
