using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Full Name:        Tyler Miles
Student ID:       101251005
File:             BackgroundController.cs
Description:      This is the background controller script that moves the background, and if it reaches the boundary, reset.
Revision history: Created a horizontalboundary variable and changed all the vertical boundary lines to account for the horizontal boundary instead.
*/

public class BackgroundController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;

    public float horizontalSpeed;
    public float horizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(horizontalBoundary, 0.0f);
        //transform.position = new Vector3(0.0f, verticalBoundary);
    }

    private void _Move()
    {
        //transform.position -= new Vector3(0.0f, verticalSpeed) * Time.deltaTime;
        transform.position -= new Vector3(horizontalSpeed, 0.0f ) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        //if (transform.position.y <= -verticalBoundary)
        //{
        //    _Reset();
        //}

        if (transform.position.x <= -horizontalBoundary)
        {
            _Reset();
        }
    }
}
