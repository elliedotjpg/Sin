using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class R2OpenVentDialogue : MonoBehaviour
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
    public Text dialogText2;
    public string dialog;
    public bool dialogActive;
    public KeyCode interactKey;
    public bool playerInRange;

    public GameObject Panel;


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

                if (playerInventory.myInventory.Contains(thisItem) && playerInventory.myInventory.Contains(thisItem2))
                {
                    SoundManagerScript.PlaySound("itemObtained");
                    Panel.SetActive(true);

                    playerInventory.myInventory.Add(addThisItem);
                    playerInventory.myInventory.Remove(removeItem);
                    playerInventory.myInventory.Remove(removeItem2);
                }
                else if (!playerInventory.myInventory.Contains(notThisItem) && !playerInventory.myInventory.Contains(notThisItem2))
                {
                    dialogBox.SetActive(true);
                }
                else if (!playerInventory.myInventory.Contains(notThisItem) || !playerInventory.myInventory.Contains(notThisItem2))
                {
                    dialogBox.SetActive(true);
                }
                
                if (playerInRange && !playerInventory.myInventory.Contains(notThisItem) && !playerInventory.myInventory.Contains(notThisItem2) && playerInventory.myInventory.Contains(addThisItem))
                {
                    dialogBox2.SetActive(true);
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
            dialogBox2.SetActive(false);

            Debug.Log("Player left range!");
        }
    }
}
