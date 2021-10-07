using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip objectGetSound;
    static AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        objectGetSound = Resources.Load<AudioClip>("itemGet");
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "itemGet":
                audioSource.PlayOneShot(objectGetSound);
                break;
        }
    }
}
