using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using TMPro;

public class Interactable : MonoBehaviour
{

    public bool isInRange;
    public GameObject Panel;
    public KeyCode interactKey;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange)
        {

            if (Input.GetKeyDown(interactKey))
            {
                if (Panel  != null)
                {
                    bool isActive = Panel.activeSelf;
                    Panel.SetActive(!isActive);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Player is in range!");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isInRange = false;
        Debug.Log("Player is no longer in range!");
    }
}
