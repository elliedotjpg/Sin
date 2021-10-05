using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene : MonoBehaviour
{
    public GameObject Player;
    public GameObject cutsceneCam;

    void OnTriggerEnter(Collider other)
    {
        cutsceneCam.SetActive(true);
        Player.SetActive(false);
    }
}
