using StarterAssets;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TMPro;
using Unity.VisualScripting;
using UnityEditor.PackageManager;
using UnityEngine;

public class IncreaseXP : MonoBehaviour
{
    public static float xp = 0f;

    private ThirdPersonController rb;
    private TextMeshProUGUI XpText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<ThirdPersonController>();
        var obj = GameObject.Find("XPAmount");
        XpText =  obj.GetComponent<TextMeshProUGUI>();
        
    }   
    int delayCount = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            if(delayCount > 200)
            {
                xp += 1;
                XpText.text = xp.ToString();
                delayCount = 0;    
            }
            delayCount +=1;

        }

       
    }
}
