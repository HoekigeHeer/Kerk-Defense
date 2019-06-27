using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class camera : MonoBehaviour
{

    public Vector2 maxBorder;
    public Vector2 minBorder;
    public Vector2 zoomLimmit;
    public float speed;
    public float zoomSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 movement = new Vector3(0, 0, 0);

        if (Input.GetKey(KeyCode.W) && transform.position.z > minBorder.x)
        {
            movement.z -= speed;
        }

        if (Input.GetKey(KeyCode.S ) && transform.position.z < maxBorder.x)
        {
            movement.z += speed;
        }

        if (Input.GetKey(KeyCode.A) && transform.position.x < maxBorder.y)
        {
            movement.x += speed;
        }

        if (Input.GetKey(KeyCode.D) && transform.position.x > minBorder.y)
        {
            movement.x -= speed;
        }

        if (Input.GetKey(KeyCode.Q) && transform.position.y < zoomLimmit.y) 
        {
            movement.y += zoomSpeed;
        }

        if (Input.GetKey(KeyCode.E) && transform.position.y > zoomLimmit.x)
        {
            movement.y -= zoomSpeed;
        }

        transform.position += movement;

    }
}
