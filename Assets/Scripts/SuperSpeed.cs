using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SuperSpeed : MonoBehaviour
{

    private ThirdPersonController rb;
    
    private float superSpeed = 20f;
    private float baseSpeed;
    public TrailRenderer trail;
    public bool togglesuperSpeed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<ThirdPersonController>();
        trail = GetComponent<TrailRenderer>();
        this.baseSpeed = rb.MoveSpeed;
        togglesuperSpeed = false;

     
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) && IncreaseXP.xp >= 0)
        {
            this.togglesuperSpeed = this.togglesuperSpeed ? false : true;
            trail.emitting = togglesuperSpeed;

            if (this.togglesuperSpeed)
            {
                rb.MoveSpeed = superSpeed;
            }
            else
            {
                rb.MoveSpeed = baseSpeed;
            }
        }


        Debug.Log("xp:" + IncreaseXP.xp + "  speed: " + rb?.MoveSpeed ?? "0");
        Debug.Log("SuperSpeed: " + this.togglesuperSpeed);
    }
}

