using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneSporn : MonoBehaviour
{
    public GameObject walker;
    public GameObject bicycleAR;
    public GameObject bicycleBR;
    public GameObject bicycleCR;
    private float minFreq;
    private float maxFereq;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpornStart");
        minFreq = 2;
        maxFereq = 7;
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
                spornObj = bicycleAR;
            }
            if (7 <= spornObjectJdg && spornObjectJdg <= 8)
            {
                spornObj = bicycleBR;
            }
            if (spornObjectJdg >= 9)
            {
                spornObj = bicycleCR;
            }
            Instantiate(spornObj, transform.position, Quaternion.identity);
        }
    }
}
