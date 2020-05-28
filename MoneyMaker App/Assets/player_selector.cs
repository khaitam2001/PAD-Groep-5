using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player_selector : MonoBehaviour
{
    public int Players = 0;
    public List<GameObject> muntjes;
    public int showPlayerStep = 0;

    public void playersDrie()
    {
        Players = 3;

        if (showPlayerStep > 3)
        {
            putPlayerOff();
        }
        putPlayerOn();
    }
    public void playersVier()
    {
       Players = 4;


        if (showPlayerStep > 4)
        {
            putPlayerOff();
        }
        putPlayerOn();

    }
    public void playersVijf()
    {
        Players = 5;


        if (showPlayerStep > 5)
        {
            putPlayerOff();
        }
        putPlayerOn();

    }
    public void playersZes()
    {
        Players = 6;



        putPlayerOn();

    }

    public void putPlayerOn()
    {
        showPlayerStep = 0;
        for (int i = 0; i < Players ; i++)
        {
            muntjes[showPlayerStep].SetActive(true);

            showPlayerStep++;
        }

    }

    public void putPlayerOff()
    {
        muntjes[4].SetActive(false);
        muntjes[5].SetActive(false);
        muntjes[6].SetActive(false);
    }

}
