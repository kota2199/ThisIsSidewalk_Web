using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour
{
    private bool allDeleteFlag = false;
    public Text itemOneCounter;
    public Text itemTwoCounter;
    public GameObject whitePanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        itemOneCounter.text = GameObject.Find("GameMaster").GetComponent<SingletonObject>().ItemOneNum.ToString();
        itemTwoCounter.text = GameObject.Find("GameMaster").GetComponent<SingletonObject>().ItemTwoNum.ToString();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bicycle"　|| collision.gameObject.tag == "BicycleB" || collision.gameObject.tag == "BicycleC")
        {
            if (allDeleteFlag)
            {
                Destroy(GameObject.FindWithTag("Bicycle"));
                Destroy(GameObject.FindWithTag("BicycleB"));
                Destroy(GameObject.FindWithTag("BicycleC"));
                GameObject.Find("GameMaster").GetComponent<SEManager>().PlayAttack();
                whitePanel.SetActive(true);
                whitePanel.GetComponent<DeletePanelEffect>().imageA = 1;
                whitePanel.GetComponent<DeletePanelEffect>().flashOn = true;
                Invoke("FalsePanel", 1);
            }
        }
    }
    public void AllDeleteItemPush()
    {
        if (GameObject.Find("GameManager").GetComponent<CountDown>().ItemOneUse == true)
        {
            if (GameObject.Find("GameMaster").GetComponent<SingletonObject>().ItemOneNum >= 1)
            {
                allDeleteFlag = true;
                Debug.Log("delete");
                GameObject.Find("GameMaster").GetComponent<SingletonObject>().ItemOneNum--;
            }
        }
    }
    public void AllDeleteItemPull()
    {
        allDeleteFlag = false;
    }
    public void FalsePanel()
    {
        whitePanel.GetComponent<DeletePanelEffect>().flashOff = true;
        whitePanel.SetActive(false);
    }
}
