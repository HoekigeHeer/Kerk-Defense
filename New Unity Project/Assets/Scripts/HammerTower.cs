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
        if (swinging)
        {
            rig.constraints = RigidbodyConstraints.None;
            swinging = false;
        }
        

        if (rig.velocity.x < 0)
        {
            rig.constraints = RigidbodyConstraints.FreezeAll;
            swung = true;
            Debug.Log("freeze");
        }

        if (swung)
        {
            hammer.transform.Rotate(0, 0, -swingSpeed);
            
            if (hammer.transform.eulerAngles.z > 90 && hammer.transform.eulerAngles.z < 280 )
            {
                swung = false;
            }
        }
    }


    void OnMouseDown()
    {
        if (!swung)
        {
          //  rig.constraints = RigidbodyConstraints.None;
          //  rig.velocity = new Vector3 (5,0,0) ;
            swinging = true;
        }
    }
}
