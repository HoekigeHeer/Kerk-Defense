using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerTower : MonoBehaviour
{

    public GameObject hammer;
    bool swung = false;
    bool swinging = false;
    public float swingSpeed;
    public float startRoration;
    public float resetRotation;
    float SwingAmount = 0;

    Rigidbody rig;

    void Start()
    {
        startRoration = hammer.transform.rotation.z;
        rig = hammer.GetComponent<Rigidbody>();
       // startRoration = hammer.transform.rotation.z;
    }

    
    void Update()
    {
        

        if (rig.velocity.z < 0)
        {
            rig.constraints = RigidbodyConstraints.FreezeAll;
            swung = true;
        }

        if (swung)
        {
            hammer.transform.Rotate(0, 0, swingSpeed);
            Debug.Log(hammer.transform.rotation.z);
            if (hammer.transform.rotation.y >= startRoration)
            {
                swung = false;
            }
        }
    }


    void OnMouseDown()
    {
        if (!swung)
        {
            rig.constraints = RigidbodyConstraints.None;
        }
    }
}
