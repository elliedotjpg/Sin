using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//[RequireComponent(typeof(AudioSource))]
public class AddTo : MonoBehaviour
{
    //public static AudioClip clip;

    [SerializeField] private PlayerInventory playerInventory;
    [SerializeField] private InventoryItem thisItem;

    public GameObject Panel;

    /*void Start()
    {
        clip = Resources.Load<AudioClip>("itemObtained");
    }*/
    public void OnClickObject()
    {
        AddItem();
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AddItem();
            gameObject.SetActive(false);
        }
    }

    void AddItem()
    {

        Debug.Log("Play sound!");
        Panel.SetActive(true);

        SoundManagerScript.PlaySound("itemObtained");
        //AudioSource.PlayClipAtPoint(clip, new Vector3(0, 0, 0));

        if (playerInventory && thisItem)
        {
            if (playerInventory.myInventory.Contains(thisItem))
            {
                thisItem.numberHeld += 1;
            }
            else
            {
                playerInventory.myInventory.Add(thisItem);
            }
        }
    }
}
