using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class fiches_move : FichesPosSet
{
    Vector3 mousePos;
    private float startPosX;
    private float startPosY;
 
    private bool isBeingHeld = false;


    // Update is called once per frame
    void Update()
    {
        if (isBeingHeld == true)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, -2);
        }
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {

            
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;
         
            isBeingHeld = true;
        }
    }

    private void OnMouseUp()
    {
        Debug.Log("Dit is het begin");
        Debug.Log(Position.Count);
        Debug.Log("Dit is het einde");



        //First circle
        if (mousePos.x < -6.35f)
        {
            this.gameObject.transform.localPosition = Position[0];
        }

        //Second circle
        else if (mousePos.x < -5.58f && this.gameObject.transform.localPosition.x > -6.2f)
        {
            this.gameObject.transform.localPosition = Position[1];
        }
        
        //Third circle
        else if (mousePos.x > -5.63f && this.gameObject.transform.localPosition.x < -5.12f)
        {
            this.gameObject.transform.localPosition = Position[2];

        }
        
        //Fourth circle
        else if (mousePos.x > -5.12f && this.gameObject.transform.localPosition.x < -4.45f)
        {
            this.gameObject.transform.localPosition = Position[3];
            Debug.Log("Stupid code4");
        }
        
        //Fifth circle
        else if (mousePos.x > -4.45f && this.gameObject.transform.localPosition.x < -3.98f)
        {
            this.gameObject.transform.localPosition = Position[4];
            Debug.Log("Stupid code5");
        }
        
        //Sixth circle
        else if (mousePos.x > -3.98f && this.gameObject.transform.localPosition.x < -3.25f)
        {
            this.gameObject.transform.localPosition = Position[5];
            Debug.Log("Stupid code6");
        }
        
        //Seventh circle
        else if (mousePos.x > -3.25f && this.gameObject.transform.localPosition.x < -2.56f)
        {
            this.gameObject.transform.localPosition = Position[6];
            Debug.Log("Stupid code27");
        }

        //Eight circle
        else if (mousePos.x > -2.56f && this.gameObject.transform.localPosition.x < -1.86f)
        {
            this.gameObject.transform.localPosition = Position[7];
        }

        //Ninth circle
        else if (mousePos.x > -1.86f && this.gameObject.transform.localPosition.x < -1.25f)
        {
            this.gameObject.transform.localPosition = Position[8];
        }

        //Tenth circle
        else if (mousePos.x > -1.25f && this.gameObject.transform.localPosition.y > 3.56)
        {
            this.gameObject.transform.localPosition = Position[9];
        }

        //Eleventh circle
        else if (mousePos.x > -2.56f && this.gameObject.transform.localPosition.x < -1.86f)
        {
            this.gameObject.transform.localPosition = Position[10];
        }

        isBeingHeld = false;
    }


    // Debug.Log("Stupid code2uifhaiufhawiu");



}

        // if (this.gameObject.transform.localPosition.x < -6.35f)
        // {
        //     this.gameObject.transform.localPosition = new Vector3(-6.76f, 4.12f, -2);
        // }
        //
        // else if (this.gameObject.transform.localPosition.x < -5.58f && this.gameObject.transform.localPosition.x > -6.2f)
        // {
        //     this.gameObject.transform.localPosition = new Vector3(-6.16f, 3.56f, -2);
        // }
        //
        // else if (this.gameObject.transform.localPosition.x > -5.63f && this.gameObject.transform.localPosition.x < -5.12f)
        // {
        //     this.gameObject.transform.localPosition = new Vector3(-5.59f, 4.12f, -2);
        // }
        //
        // else if (this.gameObject.transform.localPosition.x > -5.12f && this.gameObject.transform.localPosition.x < -4.45f)
        // {
        //     this.gameObject.transform.localPosition = new Vector3(-4.94f, 3.56f, -2);
        // }
        //
        // else if (this.gameObject.transform.localPosition.x > -4.45f && this.gameObject.transform.localPosition.x < -3.98f)
        // {
        //     this.gameObject.transform.localPosition = new Vector3(-4.36f, 4.12f, -2);
        // }
        //
        // //Last 2
        // else if (this.gameObject.transform.localPosition.x > -3.98f && this.gameObject.transform.localPosition.x < -3.25f)
        // {
        //     this.gameObject.transform.localPosition = new Vector3(-3.69f, 3.56f, -2);
        // }
        //
        // else if (this.gameObject.transform.localPosition.x > -3.25f && this.gameObject.transform.localPosition.x < -2.56f)
        // {
        //     this.gameObject.transform.localPosition = new Vector3(-3.07f, 4.12f, -2);
        // }
        //
        // else if (this.gameObject.transform.localPosition.x > -4.45f && this.gameObject.transform.localPosition.x < -3.98f)
        // {
        //     this.gameObject.transform.localPosition = new Vector3(-4.36f, 4.12f, -2);
        //     }

