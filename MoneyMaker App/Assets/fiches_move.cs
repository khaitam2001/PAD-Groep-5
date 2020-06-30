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






        //First circle
        if (mousePos.x < Position[1].x)
        {
            Debug.Log("Dit is het begin");
            this.gameObject.transform.localPosition = Position[0];
        }

        //Second circle
        else if (mousePos.x > Position[1].x && this.gameObject.transform.localPosition.x < Position[2].x)
        {
            Debug.Log("Dit is het einde");
            this.gameObject.transform.localPosition = Position[1];
        }
        
        //Third circle
        else if (mousePos.x > Position[2].x && this.gameObject.transform.localPosition.x < Position[3].x)
        {
            this.gameObject.transform.localPosition = Position[2];
        }
        
        //Fourth circle
        else if (mousePos.x > Position[3].x && this.gameObject.transform.localPosition.x < Position[4].x)
        {
            this.gameObject.transform.localPosition = Position[3];
        }
        
        //Fifth circle
        else if (mousePos.x > Position[4].x && this.gameObject.transform.localPosition.x < Position[5].x)
        {
            this.gameObject.transform.localPosition = Position[4];
        }
        
        //Sixth circle
        else if (mousePos.x > Position[5].x && this.gameObject.transform.localPosition.x < Position[6].x)
        {
            this.gameObject.transform.localPosition = Position[5];
        }
        
        //Seventh circle
        else if (mousePos.x > Position[6].x && this.gameObject.transform.localPosition.x < Position[7].x)
        {
            this.gameObject.transform.localPosition = Position[6];
        }

        //Eight circle
        else if (mousePos.x > Position[7].x && this.gameObject.transform.localPosition.x < Position[8].x && this.gameObject.transform.localPosition.y > 3.56)
        {
            this.gameObject.transform.localPosition = Position[7];
        }

        //Ninth circle
        else if (mousePos.x > Position[8].x && this.gameObject.transform.localPosition.x < Position[9].x && this.gameObject.transform.localPosition.y > 3.56)
        {
            this.gameObject.transform.localPosition = Position[8];
        }

        //Tenth circle
        else if (mousePos.x > Position[9].x && this.gameObject.transform.localPosition.y > 3.56)
        {
            this.gameObject.transform.localPosition = Position[9];
        }

        //Twelfth circle 
        else if (mousePos.x > Position[11].x && this.gameObject.transform.localPosition.x < Position[10].x && this.gameObject.transform.localPosition.y < 3.56)
        {
            this.gameObject.transform.localPosition = Position[11];
        }

        //Eleventh circle 
        else if (mousePos.x > Position[10].x && this.gameObject.transform.localPosition.y < 3.56)
        {
            this.gameObject.transform.localPosition = Position[10];
        }

        isBeingHeld = false;
    }



}
