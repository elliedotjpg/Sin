using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip MainRoom;
    
    static AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        MainRoom = Resources.Load<AudioClip>("Muni");

        audioSource = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "Muni":
                audioSource.PlayDelayed(5);
                break;
        }
    }
}
