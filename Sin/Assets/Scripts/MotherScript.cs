using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MotherScript : MonoBehaviour
{
    //[SerializeField] private PlayerInventory playerInventory;
    public GameObject itemToDrop;
    private Transform Epos;
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
        if (collision.gameObject.CompareTag("DropKeyCollider"))
        {
            Instantiate(itemToDrop, Epos.position, Quaternion.identity);
            Debug.Log("Collided with " + collision.gameObject.name);
            Debug.Log("Key dropped.");
            
            //Debug.Log("Key dropped.");
        }
    }
}
