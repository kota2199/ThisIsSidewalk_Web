using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeItem : MonoBehaviour
{
    private bool timedelay = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timedelay)
        {
            Time.timeScale = 0.2f;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    public void UseTimeItem()
    {
        if (GameObject.Find("GameManager").GetComponent<CountDown>().ItemTwoUse == true)
        {
            if (GameObject.Find("GameMaster").GetComponent<SingletonObject>().ItemTwoNum >= 1)
            {
                timedelay = true;
                Invoke("FalseTimedelay", 2);
                Debug.Log("time");
            }
        }
    }
    public void FalseTimedelay()
    {
        timedelay = false;
    }
}
