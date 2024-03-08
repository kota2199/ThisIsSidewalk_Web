using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sporn : MonoBehaviour
{
    public GameObject walker;
    public GameObject bicycleA;
    public GameObject bicycleB;
    public GameObject bicycleC;
    public GameObject manager;
    public GameObject speedUpText;
    private float minFreq;
    private float maxFereq;
    private bool spornjudge;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpornStart");
        StartCoroutine("ChangeFreq");
        minFreq = 3;
        maxFereq = 8;
    }

    // Update is called once per frame
    void Update()
    {
        spornjudge = manager.GetComponent<Score>().isSporning;
    }
    private IEnumerator SpornStart()
    {
        yield return new WaitForSeconds(5);
        while (spornjudge)
        {
            float waitTime = Random.Range(minFreq,maxFereq);
            int spornObjectJdg = Random.Range(0,11);
            GameObject spornObj = null;
            yield return new WaitForSeconds(waitTime);
            if (spornObjectJdg <= 4)
            {
                spornObj = walker;
            }
            if (5 <= spornObjectJdg && spornObjectJdg <= 7)
            {
                spornObj = bicycleA;
            }
            if (8 <= spornObjectJdg && spornObjectJdg <= 9)
            {
                spornObj = bicycleB;
            }
            if (spornObjectJdg == 10)
            {
                spornObj = bicycleC;
            }
            Instantiate(spornObj,transform.position,Quaternion.identity);
        }
    }
    private IEnumerator ChangeFreq()
    {
        yield return new WaitForSeconds(25);
        minFreq = 1f;
        maxFereq = 5f;
        speedUpText.SetActive(true);
        Invoke("SpeedUpTextFalse",1);
        yield return new WaitForSeconds(20);
        minFreq = 0.5f;
        maxFereq = 3f;
        speedUpText.SetActive(true);
        Invoke("SpeedUpTextFalse", 1);
        yield return new WaitForSeconds(15);
        minFreq = 0.1f;
        maxFereq = 2f;
        speedUpText.SetActive(true);
        Invoke("SpeedUpTextFalse", 1);
        yield return new WaitForSeconds(10);
        minFreq = 0.1f;
        maxFereq = 1f;
        speedUpText.SetActive(true);
        Invoke("SpeedUpTextFalse", 1);
    }
    public void SpeedUpTextFalse()
    {
        speedUpText.SetActive(false);
    }
}
