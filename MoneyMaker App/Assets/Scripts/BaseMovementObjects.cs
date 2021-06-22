using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovementObjects : MonoBehaviour
{
    public List<Transform> positions;
    [SerializeField] private float speed;
    [SerializeField] private Transform startPos;
    Vector3 nextPos;
    private int currentPositionStep = 0;


    private void Start()
    {

        //Sets start position and first point to go to
        transform.position = startPos.position;
        nextPos = startPos.position;
    }

    private void Update()
    {
        //Checks if the current position is equal to the next point
        if (transform.position == nextPos)
        {
            currentPositionStep++;
            //Checks if the step is higher then the list
            if (currentPositionStep > positions.Count)
            {
                currentPositionStep = 0;
            }
            nextPos = positions[currentPositionStep].position;
        }
        //Moves towards the next position in list
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        //Draws a line from position 1 to 2 to 3 etc.
        for (int i = 0; i < positions.Count; i++)
        {
            Gizmos.DrawLine(positions[i].position, positions[i + 1].position);
        }
    }
}
