using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BicycleCMove : MonoBehaviour
{
    public int speed ;
    // Start is called before the first frame update
    void Start()
    {
        speed = 8;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, -speed, 0);
    }
}
