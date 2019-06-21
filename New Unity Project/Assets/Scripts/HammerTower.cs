using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerTower : MonoBehaviour
{

    public GameObject hammer;
    bool swingBack = false;
    bool swinging = false;
    public float swingSpeed;
    public float maxSwingAmount;
    float SwingAmount = 0;

    
    void Update()
    {
        if (swinging)
        {
            if (swingBack)
            {
                hammer.transform.Rotate(0, 0, -swingSpeed);
            }
            else
            {
                hammer.transform.Rotate(0, 0, swingSpeed);
            }

            SwingAmount += swingSpeed;
            if(SwingAmount >= maxSwingAmount)
            {
                swinging = false;
                SwingAmount = 0;
                swingBack = !swingBack;
            }
        }
    }


    void OnMouseDown()
    {
        
        swinging = true;
    }
}
