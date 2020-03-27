using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void GotoSetupGame()
    {
        SceneManager.LoadScene("Setup-Game");
    }

    // Update is called once per frame
    public void GotoFirstRound()
    {
        SceneManager.LoadScene("First-Round");
    }

    public void GotoBieden()
    {

    }

    public void GotoBankrun()
    {

    }

    public void GotoEndOfGame()
    {
        SceneManager.LoadScene("end-of-game");
    }
}
