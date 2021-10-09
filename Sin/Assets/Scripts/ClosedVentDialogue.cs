using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClosedVentDialogue : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;
    [SerializeField] private InventoryItem thisItem;
    [SerializeField] private InventoryItem thisItem2;
    [SerializeField] private InventoryItem thisItem3;

    [SerializeField] private InventoryItem notThisItem;

    [SerializeField] private InventoryItem addThisItem;

    public GameObject ClosedVent;
    public GameObject OpenVent;

    public GameObject dialogBox;
    public GameObject dialogBox2;

    public Text dialogText;
    public string dialog;
    public bool dialogActive;
    public KeyCode interactKey;
    public bool playerInRange;

    [SerializeField] private InventoryItem removeItem;


    void Start()
    {
        OpenVent.SetActive(false);
        ClosedVent.SetActive(true);
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {

                if (playerInventory.myInventory.Contains(thisItem))
                {
                    playerInventory.myInventory.Remove(removeItem);

                    OpenVent.SetActive(true);

                    SoundManagerScript.PlaySound("itemGet");
                    playerInventory.myInventory.Add(addThisItem);

                    ClosedVent.SetActive(false);
                }

                else if(!playerInventory.myInventory.Contains(notThisItem))
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
            Debug.Log("Player is in range with vent!");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            dialogBox.SetActive(false);
            Debug.Log("Player is no longer in range with vent!");
        }
    }
}
