using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenVentDialogue : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;
    [SerializeField] private InventoryItem thisItem;
    [SerializeField] private InventoryItem thisItem2;
    [SerializeField] private InventoryItem thisItem3;

    [SerializeField] private InventoryItem notThisItem;
    [SerializeField] private InventoryItem notThisItem2;
    [SerializeField] private InventoryItem notThisItem3;

    [SerializeField] private InventoryItem addThisItem;

    [SerializeField] private InventoryItem removeItem;
    [SerializeField] private InventoryItem removeItem2;

    

    public GameObject dialogBox;
    public GameObject dialogBox2;
    public Text dialogText;
    public string dialog;
    public bool dialogActive;
    public KeyCode interactKey;
    public bool playerInRange;


    void Start()
    {
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {

                if (playerInventory.myInventory.Contains(thisItem) && playerInventory.myInventory.Contains(thisItem2) && playerInventory.myInventory.Contains(thisItem3))
                {
                    SoundManagerScript.PlaySound("itemGet");
                    playerInventory.myInventory.Add(addThisItem);
                }
                else if (!playerInventory.myInventory.Contains(notThisItem) && !playerInventory.myInventory.Contains(notThisItem2) && !playerInventory.myInventory.Contains(notThisItem3))
                {
                    dialogBox.SetActive(true);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            Debug.Log("Player in range!");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            dialogBox.SetActive(false);

            Debug.Log("Player left range!");
        }
    }
}
