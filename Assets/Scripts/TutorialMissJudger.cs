using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialMissJudger : MonoBehaviour
{
    public GameObject missText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bicycle" || collision.gameObject.tag == "BicycleB" || collision.gameObject.tag == "BicycleC")
        {
            missText.SetActive(missText);
            GameObject.Find("GameMaster").GetComponent<SEManager>().PlayMiss();
            Invoke("MissTextFalse",0.4f);
            Destroy(collision);
        }
    }
    public void MissTextFalse()
    {
        missText.SetActive(false);
    }
}
