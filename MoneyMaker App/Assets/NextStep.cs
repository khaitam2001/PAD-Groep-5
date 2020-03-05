using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextStep : MonoBehaviour
{
    public int currentStep;
    public string currentSprite = "Stap";
    public string currentSpriteAndStep;
    public GameObject stap;


    public Vector3 spritePosition = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextSprite()
    {
        if (currentStep > 0)
        {
            stap.SetActive(false);
        }

        currentStep++;

        currentSpriteAndStep = currentSprite + currentStep;

        stap = GameObject.Find(currentSpriteAndStep);

        stap.SetActive(true);

    }
}
