using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextStep : MonoBehaviour
{
    public int currentStep = -1;
    public List<GameObject> steps;

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

        if (currentStep >= 0)
        {
            steps[currentStep].SetActive(false);
        }

        currentStep++;

        Debug.Log(currentStep);

        steps[currentStep].SetActive(true);

    }

     public void PreviousSprite()
     {
         if (currentStep >= 0)
         {
             steps[currentStep].SetActive(false);

             currentStep--;
         }
         
        steps[currentStep].SetActive(true);

     }
}

