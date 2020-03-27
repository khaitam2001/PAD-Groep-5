using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
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
        if (this.gameObject.transform.localPosition.x > 5.9f - 0.225f)
        {
            this.gameObject.transform.localPosition = new Vector3(5.9f, 2.85f, -1);
        }

        else if (this.gameObject.transform.localPosition.x > 5.05f - 0.225f && this.gameObject.transform.localPosition.x < 5.9f + 0.225f)
        {
            this.gameObject.transform.localPosition = new Vector3(5.05f, 2.85f, -1);
        }

        else if (this.gameObject.transform.localPosition.x > 4.1f - 0.225f && this.gameObject.transform.localPosition.x < 5.05f + 0.225f)
        {
            this.gameObject.transform.localPosition = new Vector3(4.1f, 2.85f, -1);
        }

        else if (this.gameObject.transform.localPosition.x > 3.15f - 0.225f && this.gameObject.transform.localPosition.x < 4.1f + 0.225f)
        {
            this.gameObject.transform.localPosition = new Vector3(3.15f, 2.85f, -1);
        }

        else if (this.gameObject.transform.localPosition.x > 2.2f - 0.225f && this.gameObject.transform.localPosition.x < 3.15f + 0.225f)
        {
            this.gameObject.transform.localPosition = new Vector3(2.2f, 2.85f, -1);
        }

        else if (this.gameObject.transform.localPosition.x < 2.2f) 
        {
            this.gameObject.transform.localPosition = new Vector3(1.25f, 2.85f, -1);
        }

        isBeingHeld = false;
    }
}
