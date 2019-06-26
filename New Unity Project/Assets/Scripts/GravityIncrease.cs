using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityIncrease : MonoBehaviour
{
    Rigidbody rig;
    public float increase;

    void Start()
    {
      rig = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        rig.AddForce ( Physics.gravity * increase);
    }
}
