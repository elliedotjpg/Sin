using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public GameObject inventoryPanel;
    public GameObject pausePanel;
    public Image hideLayer;
    public string mainMenu;
    public bool usingPausePanel;
    public KeyCode interactKey;

    void Start()
    {
        pausePanel.SetActive(false);
        inventoryPanel.SetActive(false);
        usingPausePanel = false;
    }

    // Update is called once per frame
    void Update()
    {
        PauseMore();
        deactivateInventory();
    }


    public void PauseMore()
    {
        if (pausePanel.activeInHierarchy || inventoryPanel.activeInHierarchy == true)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }

    public void deactivateInventory()
    {
        if (pausePanel.activeInHierarchy == true)
        {
            inventoryPanel.SetActive(false);
        }
        else
        {
            pausePanel.SetActive(false);
        } 
    }

    /**public void ChangePause()
    {
        isPaused = !isPaused;
        if (isPaused)
        {
            pausePanel.SetActive(true);
            Time.timeScale = 0f;
            usingPausePanel = true;
        }
        else
        {
            pausePanel.SetActive(false);
            Time.timeScale = 1f;
        }
    }*/

    public void SwitchPanels()
    {
      usingPausePanel = !usingPausePanel;
      if(usingPausePanel)
      {
        pausePanel.SetActive(false);
        inventoryPanel.SetActive(false);
      }
      else
      {
       inventoryPanel.SetActive(true);
       pausePanel.SetActive(true);
      }
    }
}
