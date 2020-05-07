using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.WSA;

public class MenuController : MonoBehaviour
{
    public void SwitchToGameSetup()
    {
        SceneManager.LoadScene("Setup-Game");
    }
    public void SwitchToFirstRound()
    {
        SceneManager.LoadScene("First-Round");
    }
    public void SwitchToSpelersKeuze()
    {
        SceneManager.LoadScene("Spelers-Keuze");
    }
    public void SwitchToBankRun()
    {
        SceneManager.LoadScene("Bankrun");
    }
    public void SwitchToPromoFeature()
    {
        SceneManager.LoadScene("Test");
    }
    public void SwitchToTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void SwitchToBieden()
    {
        SceneManager.LoadScene("bieden");
    }
    public void SwitchToEndOfGame()
    {
        SceneManager.LoadScene("end-of-game");
    }
    public void SwitchToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void SwitchToBankrun()
    {
        SceneManager.LoadScene("Bankrun");
    }
}
