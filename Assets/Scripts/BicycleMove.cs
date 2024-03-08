using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BicycleMove : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 3;
    }

    void Update()
    // Update is called once per frame   
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(0,-speed,0);
    }
}
