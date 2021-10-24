using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Full Name:        Tyler Miles
Student ID:       101251005
File:             BulletController.cs
Description:      This is where the bullet recieves its instructions to move and reset bounds once hitting the border.
Revision history: Created a horizontalboundary variable and changed all the vertical boundary lines to account for the horizontal boundary instead. Also made the bullet travel horizontally rather than vertically.
*/

public class BulletController : MonoBehaviour, IApplyDamage
{
    public float verticalSpeed;
    public float verticalBoundary;

    public float horizontalSpeed;
    public float horizontalBoundary;

    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        //transform.position += new Vector3(0.0f, verticalSpeed, 0.0f) * Time.deltaTime;
        transform.position += new Vector3(horizontalSpeed, 0.0f , 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        //if (transform.position.y > verticalBoundary)
        //{
        //    bulletManager.ReturnBullet(gameObject);
        //}

        if (transform.position.x > horizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        bulletManager.ReturnBullet(gameObject);
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
