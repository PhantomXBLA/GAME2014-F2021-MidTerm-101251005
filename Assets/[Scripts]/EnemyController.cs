using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Full Name:        Tyler Miles
Student ID:       101251005
File:             EnemyController.cs
Description:      This is where the enemy recieves its instructions to move and reset bounds once hitting the border.
Revision history: Changed code to allow for horizontal movement rather than vertical movement.
*/

public class EnemyController : MonoBehaviour
{
    public float horizontalSpeed;
    public float horizontalBoundary;
    public float direction;

    public float verticalSpeed;
    public float verticalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        //transform.position += new Vector3(horizontalSpeed * direction * Time.deltaTime, 0.0f, 0.0f);
        transform.position += new Vector3(0.0f, verticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        //// check right boundary
        //if (transform.position.x >= horizontalBoundary)
        //{
        //    direction = -1.0f;
        //}

        //// check left boundary
        //if (transform.position.x <= -horizontalBoundary)
        //{
        //    direction = 1.0f;
        //}


        // check top boundary
        if (transform.position.y >= verticalBoundary)
        {
            direction = -1.0f;
        }

        // check bottom boundary
        if (transform.position.y <= -verticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
