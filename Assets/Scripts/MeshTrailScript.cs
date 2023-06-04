using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MeshTrailScript : MonoBehaviour
{
    public TrailRenderer trail;
    public bool isTrailActive = false ;
    public SonicSpeed sonicSpeed;
    public SuperSpeed superSpeed;
    
    private void Start()
    {
       isTrailActive = false ;
       
    }

    
    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.R))
        {
            trail.emitting = true;
            isTrailActive = true;
            
        }

        else if (Input.GetKeyDown(KeyCode.T))
        {
            trail.emitting = false;
            isTrailActive = false;
        }


            
    }
}