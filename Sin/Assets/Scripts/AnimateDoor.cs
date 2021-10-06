using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateDoor : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;
    [SerializeField] private InventoryItem thisItem;

    private static bool loadedPrefab = false;

    public GameObject doorObject;

    void Start()
    {
        doorObject.SetActive(false);
    }

    void Update()
    {

        if (playerInventory.myInventory.Contains(thisItem) && !loadedPrefab)
        {
            doorObject.SetActive(true);
            loadedPrefab = true;
            Instantiate(doorObject, transform.position, transform.rotation);
            StartCoroutine(DelayCoroutine());
        }
        else
        {
            doorObject.SetActive(false);
        }
    }

    private IEnumerator DelayCoroutine()
    {
        yield return new WaitForSeconds(3f);
        doorObject.SetActive(false);
    }


}
