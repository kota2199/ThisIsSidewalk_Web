using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpeed : MonoBehaviour
{
    private bool step1;
    private bool step2;
    private bool step3;
    private bool step4;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Change");
        step1 = false;
        step2 = false;
        step3 = false;
        step4 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ((step1 = true) && (step2 = false) && (step3 = false) && (step4 = false))
        {
            GameObject.FindWithTag("Bicycle").GetComponent<BicycleMove>().speed = 4;
            GameObject.FindWithTag("BicycleB").GetComponent<BicycleBMove>().speed = 6;
            GameObject.FindWithTag("BicycleC").GetComponent<BicycleCMove>().speed = 9;
        }
        if ((step1 = false) && (step2 = true) && (step3 = false) && (step4 = false))
        {
            GameObject.FindWithTag("Bicycle").GetComponent<BicycleMove>().speed = 5;
            GameObject.FindWithTag("BicycleB").GetComponent<BicycleBMove>().speed = 7;
            GameObject.FindWithTag("BicycleC").GetComponent<BicycleCMove>().speed = 10;
        }
        if ((step1 = false) && (step2 = false) && (step3 = true) && (step4 = false))
        {
            GameObject.FindWithTag("Bicycle").GetComponent<BicycleMove>().speed = 7;
            GameObject.FindWithTag("BicycleB").GetComponent<BicycleBMove>().speed = 9;
            GameObject.FindWithTag("BicycleC").GetComponent<BicycleCMove>().speed = 12;
        }
        if ((step1 = false) && (step2 = false) && (step3 = false) && (step4 = true))
        {
            GameObject.FindWithTag("Bicycle").GetComponent<BicycleMove>().speed = 8;
            GameObject.FindWithTag("BicycleB").GetComponent<BicycleBMove>().speed = 11;
            GameObject.FindWithTag("BicycleC").GetComponent<BicycleCMove>().speed = 14;
        }
    }
    private IEnumerator Change()
    {
        yield return new WaitForSeconds(25);
        step1 = true;
        yield return new WaitForSeconds(20);
        step1 = false;
        step2 = true;
        yield return new WaitForSeconds(15);
        step2 = false;
        step3 = true;
        yield return new WaitForSeconds(10);
        step3 = false;
        step4 = true;
    }
}
