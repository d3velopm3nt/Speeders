using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XpText : MonoBehaviour
{

    public Text changingText;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private string xp = IncreaseXP.xp.ToString();
    // Update is called once per frame
    void Update()
    {

        changingText.text = (xp);
    }
}
