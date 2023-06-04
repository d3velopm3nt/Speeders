using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpPower = 6f; // jump power
    public float speed = 5f; // Initial walking speed
    public float xp = 0;  // Player experience
    public float maxXp = 1000; // max experience
    private DateTime lastUpdate = DateTime.Now;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private async void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");// movement left,right
        float verticalInput = Input.GetAxis("Vertical");// movement foreward,backward 
        float Jump = Input.GetAxis("Jump");
        Vector3 movement = new Vector3(horizontalInput, Jump, verticalInput).normalized;
        rb.velocity = movement * speed;
       
        

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A)) // when key is pressed add one xp
        {
            await Task.Delay(1);

            xp = xp + 1;

            Console.WriteLine(xp);
        }

        if (xp == 5 && Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 100;
        }


    }

    private void IncreaseSpeed()
    {
               
    }
}
