using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        //checks collision with the player
        if (col.gameObject.CompareTag("Player"))
        {
            SoundManagerScript.PlaySound("playerDied");
            FindObjectOfType<MiniGameHUDController>().Dead();
        }
    }
}
