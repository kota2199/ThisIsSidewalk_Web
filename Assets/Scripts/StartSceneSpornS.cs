using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneSpornS : MonoBehaviour
{
    public GameObject walker;
    public GameObject bicycleAS;
    public GameObject bicycleBS;
    public GameObject bicycleCS;
    private float minFreq;
    private float maxFereq;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpornStart");
        minFreq = 1;
        maxFereq = 9;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator SpornStart()
    {
        while (true)
        {
            float waitTime = Random.Range(minFreq, maxFereq);
            int spornObjectJdg = Random.Range(0, 11);
            GameObject spornObj = null;
            yield return new WaitForSeconds(waitTime);
            if (spornObjectJdg <= 2)
            {
                spornObj = walker;
            }
            if (3 <= spornObjectJdg && spornObjectJdg <= 6)
            {
                spornObj = bicycleAS;
            }
            if (7 <= spornObjectJdg && spornObjectJdg <= 8)
            {
                spornObj = bicycleBS;
            }
            if (spornObjectJdg >= 9)
            {
                spornObj = bicycleCS;
            }
            Instantiate(spornObj, transform.position, Quaternion.identity);
        }
    }
}
