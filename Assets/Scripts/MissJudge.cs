using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissJudge : MonoBehaviour
{
    public GameObject gameManager;
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
            gameManager.GetComponent<Score>().DeclineScore();
            GameObject.Find("GameMaster").GetComponent<SEManager>().PlayMiss();
            Destroy(collision);
        }
    }
}
