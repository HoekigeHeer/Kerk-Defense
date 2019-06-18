using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{

    public Vector3 setGravity;

    void Start()
    {
        Physics.gravity = setGravity;
    }

   
}
