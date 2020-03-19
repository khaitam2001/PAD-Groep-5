using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.WSA;

public class MenuController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SwitchToGameSetup()
    {
        SceneManager.LoadScene("Setup-Game");
        // buttonText.text = "Hello World";
        // GameObject.CreatePrimitive(PrimitiveType.Cube);
    }
    public void SwitchToFirstRound()
    {
        SceneManager.LoadScene("First-Round");
    }
    public void SwitchToTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void SwitchTo()
    {
        SceneManager.LoadScene("First-Round");
    }
}
