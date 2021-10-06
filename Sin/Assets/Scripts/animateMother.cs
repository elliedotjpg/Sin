using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animateMother : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;
    [SerializeField] private InventoryItem thisItem;

    private static bool loadedPrefab = false;

    public GameObject motherObject;
    public GameObject keyObject;

    void Start()
    {
        keyObject.SetActive(false);
    }

    void Update()
    {

        if (playerInventory.myInventory.Contains(thisItem) && !loadedPrefab)
        {
            motherObject.SetActive(true);
            loadedPrefab = true;
            Instantiate(motherObject, transform.position, transform.rotation);
            StartCoroutine(DelayCoroutine());
        }
        else
        {
            motherObject.SetActive(false);
        }
    }

    private IEnumerator DelayCoroutine()
    {
        yield return new WaitForSeconds(3f);
        keyObject.SetActive(true);
    }


}
