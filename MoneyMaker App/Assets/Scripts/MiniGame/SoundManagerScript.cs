using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip coinPickUp, deathSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        coinPickUp = Resources.Load<AudioClip>("collectable_SFX");
        deathSound = Resources.Load<AudioClip>("mario-oof");

        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "coinPickedUp":
                audioSrc.PlayOneShot(coinPickUp);
                break;
            case "playerDied":
                audioSrc.PlayOneShot(deathSound);
                break;
        }
    }
}
