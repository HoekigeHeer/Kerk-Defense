using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderTower : MonoBehaviour

{

    public Transform boulderSpawn;
    public GameObject boulderPrefab;
    GameObject boulder;
    public float realoadRange;
    bool builderDocked = true;
    


    public float dropForce;

    void Start()
    {
       boulder = Instantiate(boulderPrefab, boulderSpawn.position, Quaternion.identity);
        
    }

    void Update()
    {
        if (Vector3.Distance(boulderSpawn.position,boulder.transform.position) > realoadRange)
        {
            boulder = Instantiate(boulderPrefab, boulderSpawn.position, Quaternion.identity);
            builderDocked = true;
        }
    }

    void OnMouseDown()
    {
        DropBuilder();
    }

    public void DropBuilder()
    {
        if (builderDocked)
        {
            boulder.GetComponent<Rigidbody>().AddForce(0, 0, dropForce);
            Destroy(boulder, 10);
            builderDocked = false;
        }
    }

    
}
