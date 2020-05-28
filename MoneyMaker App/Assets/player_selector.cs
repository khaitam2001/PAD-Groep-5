using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player_selector : MonoBehaviour
{
    public int Players = 0;
    public Text mytext = null;

    void start() { }

    void update() { }

    public void playersDrie()
    {
        Debug.Log("Hello");
        mytext.text = "3 Spelers";
        Players = 3;
    }
    public void playersVier()
    {

        mytext.text = "4 Spelers";
    }
    public void playersVijf()
    {

        mytext.text = "5 Spelers";
    }
    public void playersZes()
    {

        mytext.text = "6 Spelers";
    }
}
