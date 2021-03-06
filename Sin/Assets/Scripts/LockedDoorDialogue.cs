using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LockedDoorDialogue : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;
    [SerializeField] private InventoryItem thisItem;
    [SerializeField] private InventoryItem thisItem2;
    [SerializeField] private InventoryItem notThisItem;
    [SerializeField] private InventoryItem notThisItem2;

    [SerializeField] private InventoryItem addThisItem;

    public GameObject DoorAnim;
    public GameObject LockedDoor;
    public GameObject dialogBox;
    public GameObject dialogBox2;
    public Text dialogText;
    public string dialog;
    public bool dialogActive;
    public KeyCode interactKey;
    public bool playerInRange;


    void Start()
    {
        LockedDoor.SetActive(true);
        DoorAnim.SetActive(false);
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
                    DoorAnim.SetActive(true);
                    LockedDoor.SetActive(false);
                    StartCoroutine(Wait());
                }
                else if (!playerInventory.myInventory.Contains(notThisItem))
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

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(2);
    }

}
