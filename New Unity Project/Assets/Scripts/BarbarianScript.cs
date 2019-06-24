using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbarianScript : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3.MoveTowards(transform.position, target.transform.position, movementSpeed * Time.deltaTime);
    }
}
