using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StayAnimated : MonoBehaviour
{
    private int ph_frame = 0;

    void FixedUpdate()
    {
        ph_frame += 1;
        Time.timeScale = 1;
        Debug.Log("--FixedUpdate-- [ Time.timeScale=" + Time.timeScale.ToString() + "], frame num: " + ph_frame.ToString());
    }
}
