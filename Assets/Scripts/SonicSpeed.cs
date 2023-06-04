using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SonicSpeed : MonoBehaviour
{
    private ThirdPersonController rb;
    private float sonicSpeed = 100f;
    private float baseSpeed;
    public bool togglesonicSpeed = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<ThirdPersonController>();
        this.baseSpeed = rb.MoveSpeed;
        togglesonicSpeed = false;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && IncreaseSpeed.xp >= 0)
        {
            this.togglesonicSpeed = this.togglesonicSpeed ? false : true;

            if (this.togglesonicSpeed)
            {
                rb.MoveSpeed = sonicSpeed;
            }
            else
            {
                rb.MoveSpeed = baseSpeed;
            }
        }
    }
}
