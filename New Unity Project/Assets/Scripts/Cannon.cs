using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour

{

    public Transform boulderSpawn;
    public GameObject boulderPrefab;
    GameObject boulder;
    public float realoadRange;
    bool builderDocked = true;
    public Transform pivot;
    public float rotationSpeed;
    public Vector2 minRotation;
    public Vector2 maxRotation;
    public Transform direction;

    public float reloadTime;
    float relodeTimer;
    bool reloading = false;    


    public float dropForce;

    void Start()
    {
       boulder = Instantiate(boulderPrefab, boulderSpawn.position, Quaternion.identity);
        
    }

    void Update()
    {
        if (Input.GetKey (KeyCode.UpArrow)&&pivot.eulerAngles.x > maxRotation.x)
        {
            pivot.Rotate(-rotationSpeed, 0, 0);
        } else if (Input.GetKey(KeyCode.DownArrow) && pivot.eulerAngles.x < minRotation.x)
        {
            pivot.Rotate(rotationSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && pivot.eulerAngles.y > minRotation.y )
        {
            pivot.Rotate(0, -rotationSpeed, 0);
        } else if (Input.GetKey(KeyCode.RightArrow) && pivot.eulerAngles.y < maxRotation.y)
        {
            pivot.Rotate(0, rotationSpeed, 0);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            DropBuilder();
        }


        if (Time.time - relodeTimer > reloadTime && reloading)
        {
            reloading = false;
            boulder = Instantiate(boulderPrefab, boulderSpawn.position, Quaternion.identity);
            builderDocked = true;
        }
    }


    public void DropBuilder()
    {
        if (builderDocked)
        {
            boulder.transform.LookAt(direction);

            
            boulder.GetComponent<Rigidbody>().AddForce(boulder.transform.forward * dropForce);
            
            Destroy(boulder, 10);
            builderDocked = false;
            relodeTimer = Time.time;
            reloading = true;
        }
    }

    
}
