﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ClicksTillNext : MonoBehaviour
{
    public int PhotoNumber;
    public int PhotoID;

    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            PhotoNumber++;
        }

        if (PhotoID == PhotoNumber)
        {
            
        }
    }
}
