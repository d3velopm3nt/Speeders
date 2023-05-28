using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Initial walking speed
    public float maxSpeed = 1000000f; // Maximum walking speed
    public float acceleration = 1f; // Speed increment

    private DateTime lastUpdate = DateTime.Now;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized;
        rb.velocity = movement * speed;


          TimeSpan ts = new DateTime() - lastUpdate;
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A))
        {
            if (ts.TotalSeconds > 1)
            {
                IncreaseSpeed();
                this.lastUpdate = DateTime.Now;
            }
        }
    }

    private void IncreaseSpeed()
    {

        {
            speed += 1;
        }
    }
}
