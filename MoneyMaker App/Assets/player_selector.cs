using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player_selector : MonoBehaviour
{
    public int Players = 0;
    public List<GameObject> muntjes;
    public List<GameObject> bankrunFiches;

    public int showPlayerStep = 0;

    public void playersDrie()
    {
        Players = 3;

        putPlayerOff();
        putPlayerOn();
    }
    public void playersVier()
    {
       Players = 4;

       putPlayerOff();
        putPlayerOn();

    }
    public void playersVijf()
    {
        Players = 5;

        putPlayerOff();
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
        setBankRun();
    }

    public void putPlayerOff()
    {
        for (int i = 0; i < muntjes.Count; i++)
        {
            muntjes[i].SetActive(false);

        }
    }


    //bankrun fiches based on players
   public void setBankRun()
    {
        
        for(int i = 0; i < bankrunFiches.Count; i++)
        {
            if (Players == 6) {
               bankrunFiches[i].transform.localPosition =  new Vector3(-6.76f, 4.12f, -2);
            }
            else if (Players == 5)
            {
                bankrunFiches[i].transform.localPosition = new Vector3(-6.16f, 3.56f, -2);
            }
           else if (Players == 4)
            {
                bankrunFiches[i].transform.localPosition = new Vector3(-5.59f, 4.12f, -2);
            }
            else if (Players == 3)
            {
                bankrunFiches[i].transform.localPosition = new Vector3(-4.94f, 3.56f, -2);
            }
           
        }
    }
}
