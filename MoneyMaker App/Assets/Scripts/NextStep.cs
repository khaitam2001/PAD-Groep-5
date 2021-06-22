using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextStep : MonoBehaviour
{
    public int currentStep = -1;
    public List<GameObject> steps;

    public Vector3 spritePosition = new Vector3();

    public void NextSprite()
    {
        if (currentStep >= 0)
        {
            steps[currentStep].SetActive(false);
        }
        currentStep++;
        if (currentStep >= steps.Count)
        {
            currentStep = steps.Count -1;
        }
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

