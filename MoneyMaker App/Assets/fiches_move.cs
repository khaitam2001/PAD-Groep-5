using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fiches_move : MonoBehaviour
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

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, -1);
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
        if (this.gameObject.transform.localPosition.x < -6.35f)
        {
            this.gameObject.transform.localPosition = new Vector3(-6.76f, 4.12f, -2);
        }

        else if (this.gameObject.transform.localPosition.x < -5.58f && this.gameObject.transform.localPosition.x > -6.2f)
        {
            this.gameObject.transform.localPosition = new Vector3(-6.16f, 3.56f, -2);
        }

        else if (this.gameObject.transform.localPosition.x > -5.63f && this.gameObject.transform.localPosition.x < -5.12f)
        {
            this.gameObject.transform.localPosition = new Vector3(-5.59f, 4.12f, -2);
        }

        else if (this.gameObject.transform.localPosition.x > -5.12f && this.gameObject.transform.localPosition.x < -4.45f)
        {
            this.gameObject.transform.localPosition = new Vector3(-4.94f, 3.56f, -2);
        }

        else if (this.gameObject.transform.localPosition.x > -4.45f && this.gameObject.transform.localPosition.x < -3.98f)
        {
            this.gameObject.transform.localPosition = new Vector3(-4.36f, 4.12f, -2);
        }

        //Last 2
        else if (this.gameObject.transform.localPosition.x > -3.98f && this.gameObject.transform.localPosition.x < -3.25f)
        {
            this.gameObject.transform.localPosition = new Vector3(-3.69f, 3.56f, -2);
        }

        else if (this.gameObject.transform.localPosition.x > -3.25f && this.gameObject.transform.localPosition.x < -2.56f)
        {
            this.gameObject.transform.localPosition = new Vector3(-3.07f, 4.12f, -2);
        }

        else if (this.gameObject.transform.localPosition.x > -4.45f && this.gameObject.transform.localPosition.x < -3.98f)
        {
            this.gameObject.transform.localPosition = new Vector3(-4.36f, 4.12f, -2);
        }


        isBeingHeld = false;
    }
}
